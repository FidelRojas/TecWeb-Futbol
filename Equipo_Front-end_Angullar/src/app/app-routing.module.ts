import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { EquiposComponent } from './components/equipos/equipos.component';
import{ContactoComponent}from './components/pages/contacto/contacto.component';
import{AddEquipoComponent}from './components/add-equipo/add-equipo.component';
import{EquipoDetalleComponent}from './components/equipo-detalle/equipo-detalle.component';
import{EquipoEditComponent} from './components/equipo-edit/equipo-edit.component'


const routes: Routes = [
  {path: '',component: EquiposComponent},
  {path: 'Contacto',component: ContactoComponent},
  {path: 'AddEquipo',component: AddEquipoComponent},
  {path:'equipos/:equipoId',component:EquipoDetalleComponent},
  {path:'equipos/:equipoId/edit',component:EquipoEditComponent}




];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
