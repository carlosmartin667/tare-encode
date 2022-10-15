import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
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
  ) {}
  onGetcredencialesUsuarioDetalle() {
    this.usuarioServicio
      .getcredencialesUsuarioDetalle(this.rutaActiva.snapshot.params['id'])
      .subscribe((res: any) => {
        this.credencialesUsuarioModel = res;
      });
  }
}
