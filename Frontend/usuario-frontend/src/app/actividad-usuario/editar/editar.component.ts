import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import Swal from 'sweetalert2';
import { CredencialesUsuarioModel } from '../models/CredencialesUsuarioModel';
import { UsuarioServicio } from '../services/usuario.service';

@Component({
  selector: 'app-editar',
  templateUrl: './editar.component.html',
})
export class EditarComponent implements OnInit {
  credencialesUsuarioModel: CredencialesUsuarioModel =
    new CredencialesUsuarioModel();

  constructor(
    private rutaActiva: ActivatedRoute,
    private usuarioServicio: UsuarioServicio
  ) {}

  ngOnInit(): void {
    this.onGetcredencialesUsuarioDetalle();
  }

  onEditarCredencialesUsuario(
    credencialesUsuarioModel: CredencialesUsuarioModel
  ): void {
    this.usuarioServicio
      .putCredencialesUsuario(
        credencialesUsuarioModel,
        this.rutaActiva.snapshot.params['id']
      )
      .subscribe(() => {
        Swal.fire({
          position: 'top-end',
          icon: 'success',
          title: `el ususario ${credencialesUsuarioModel.nombre} se ha editado con exito!`,
          showConfirmButton: false,
          timer: 4000,
        });
        this.onGetcredencialesUsuarioDetalle();
      });
  }
  onGetcredencialesUsuarioDetalle() {
    this.usuarioServicio
      .getcredencialesUsuarioDetalle(this.rutaActiva.snapshot.params['id'])
      .subscribe((res: any) => {
        this.credencialesUsuarioModel = res;
      });
  }
}
