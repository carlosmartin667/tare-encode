import { Component, OnInit } from '@angular/core';
import Swal from 'sweetalert2';
import { UsuarioServicio } from '../services/usuario.service';

@Component({
  selector: 'app-lista',
  templateUrl: './lista.component.html',
})
export class ListaComponent implements OnInit {
  credencialesUsuarioList: Array<any> = [];

  constructor(private usuarioServicio: UsuarioServicio) {}

  onDataTable() {
    this.usuarioServicio.getcredencialesUsuario().subscribe((res: any) => {
      this.credencialesUsuarioList = res;
    });
  }

  async remover(id: any) {
    await this.usuarioServicio
      .deletecredencialesUsuario(id)
      .subscribe((res: any) => {
        Swal.fire({
          position: 'top-end',
          icon: 'success',
          title: `el ususario fue eliminado con exito!`,
          showConfirmButton: false,
          timer: 4000,
        });
        this.onDataTable();
      });
  }
  ngOnInit(): void {
    this.onDataTable();
  }
}
