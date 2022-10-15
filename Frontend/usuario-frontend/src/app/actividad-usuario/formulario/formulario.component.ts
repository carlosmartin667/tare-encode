import { Component, OnInit } from '@angular/core';
import { CredencialesUsuarioModel } from '../models/CredencialesUsuarioModel';
import { UsuarioServicio } from '../services/usuario.service';
import Swal from 'sweetalert2';


@Component({
  selector: 'app-formulario',
  templateUrl: './formulario.component.html',
})
export class FormularioComponent implements OnInit {
  credencialesUsuarioModel: CredencialesUsuarioModel =
    new CredencialesUsuarioModel();

  constructor(private usuarioServicio: UsuarioServicio) {}

  ngOnInit(): void {}
  onAddCredencialesUsuario(
    credencialesUsuarioModel: CredencialesUsuarioModel
  ): void {
    this.usuarioServicio
      .addCredencialesUsuario(credencialesUsuarioModel)
      .subscribe(() => {
        Swal.fire({
          position: 'top-end',
          icon: 'success',
          title: `el ususario ${credencialesUsuarioModel.nombre} se ha registrado con exito!`,
          showConfirmButton: false,
          timer: 4000,
        });
      });
  }
}
