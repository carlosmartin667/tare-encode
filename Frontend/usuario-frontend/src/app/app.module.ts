import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { ActividadUsuarioModule } from './actividad-usuario/actividad-usuario.module';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { NavbarComponent } from './layout/navbar/navbar.component';

@NgModule({
  declarations: [AppComponent, NavbarComponent],
  imports: [BrowserModule, AppRoutingModule, ActividadUsuarioModule],
  providers: [],
  bootstrap: [AppComponent],
})
export class AppModule {}
