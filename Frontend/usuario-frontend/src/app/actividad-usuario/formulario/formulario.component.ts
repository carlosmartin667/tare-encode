import { Component, OnInit } from '@angular/core';
import { CredencialesUsuarioModel } from '../models/CredencialesUsuarioModel';
import { UsuarioServicio } from '../services/usuario.service';

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
      .subscribe((res) => {
        if (res) {
          alert(
            `el ususario ${credencialesUsuarioModel.nombre} se ha registrado con exito!`
          );
          // this.clear();
          // this.onDataTable();
        } else {
          alert('Error! :(');
        }
      });
  }
}
