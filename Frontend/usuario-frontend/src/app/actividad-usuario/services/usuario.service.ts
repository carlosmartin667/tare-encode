import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { CredencialesUsuarioModel } from '../models/CredencialesUsuarioModel';
import { Observable } from 'rxjs';
@Injectable()
export class UsuarioServicio {
  constructor(private http: HttpClient) {}

  url: string = 'https://localhost:44350/api/CredencialesUsuario';

  getcredencialesUsuario() {
    return this.http.get(this.url);
  }
  getcredencialesUsuarioDetalle(id:any) {
    return this.http.get(this.url + '/' + id);
  }
  deletecredencialesUsuario(id: number) {
    return this.http.delete(this.url + '/' + id);
  }

  addCredencialesUsuario(
    credencialesUsuarioModel: CredencialesUsuarioModel
  ): Observable<CredencialesUsuarioModel> {
    return this.http.post<CredencialesUsuarioModel>(
      this.url + '/Post',
      credencialesUsuarioModel
    );
  }

  getActividadesUsuario(id: any) {
    return this.http.get(
      'https://localhost:44350/api/ActividadesUsuario/' + id
    );
  }
  saludar: string = 'hola';
}
