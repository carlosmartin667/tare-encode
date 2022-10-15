import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { HttpClientModule } from '@angular/common/http';
import { ListaComponent } from './lista/lista.component';
import { FormularioComponent } from './formulario/formulario.component';
import { UsuarioServicio } from './services/usuario.service';
import { ListaActividadComponent } from './lista-actividad/lista-actividad.component';
import { FormsModule } from '@angular/forms';
import { EditarComponent } from './editar/editar.component';

@NgModule({
  declarations: [ListaComponent, FormularioComponent, ListaActividadComponent, EditarComponent],
  imports: [CommonModule, HttpClientModule, FormsModule],
  exports: [ListaComponent],
  providers: [UsuarioServicio],
})
export class ActividadUsuarioModule {}
