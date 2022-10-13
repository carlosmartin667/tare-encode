import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { UsuarioServicio } from '../services/usuario.service';
import { ActivatedRoute, Params } from '@angular/router';
@Component({
  selector: 'app-lista-actividad',
  templateUrl: './lista-actividad.component.html',
})
export class ListaActividadComponent implements OnInit {
  actividadUsuarioList: Array<any> = [];


  constructor(
    private usuarioServicio: UsuarioServicio,
    private rutaActiva: ActivatedRoute
  ) {

    usuarioServicio
      .getActividadesUsuario(this.rutaActiva.snapshot.params['id'])
      .subscribe((res: any) => {
        this.actividadUsuarioList = res;
      });
  }

  ngOnInit(): void {}
}
