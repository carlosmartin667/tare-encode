import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable()
export class UsuarioServicio {
  constructor(private http: HttpClient) {}
  getcredencialesUsuario() {
    return this.http.get('https://localhost:44350/api/CredencialesUsuario');
  }

  deletecredencialesUsuario(id: any) {
    console.log(id);

    return this.http.delete(
      'https://localhost:44350/api/CredencialesUsuario/(id:int)?id='+id
    );
  }
  getActividadesUsuario(id: any) {
    console.log(id);

    return this.http.get(
      'https://localhost:44350/api/ActividadesUsuario/' + id
    );
  }
  saludar: string = 'hola';
}
