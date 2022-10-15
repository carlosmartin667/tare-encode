import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { CredencialesUsuarioModel } from '../models/CredencialesUsuarioModel';

@Component({
  selector: 'app-editar',
  templateUrl: './editar.component.html',
})
export class EditarComponent implements OnInit {
  credencialesUsuarioModel: CredencialesUsuarioModel =
    new CredencialesUsuarioModel();

  constructor(private rutaActiva: ActivatedRoute) {}

  ngOnInit(): void {}

  onEditarCredencialesUsuario(
    credencialesUsuarioModel: CredencialesUsuarioModel
  ) {}
}
