import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { FormularioComponent } from './actividad-usuario/formulario/formulario.component';
import { ListaActividadComponent } from './actividad-usuario/lista-actividad/lista-actividad.component';
import { ListaComponent } from './actividad-usuario/lista/lista.component';

const routes: Routes = [
  { path: 'lista', component: ListaComponent },
  { path: '', component: FormularioComponent },
  { path: 'listaUsuario/:id', component: ListaActividadComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
