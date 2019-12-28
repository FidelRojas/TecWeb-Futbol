import { Component, OnInit } from '@angular/core';
import { Equipo } from '../../models/Equipo';
import { ActivatedRoute } from '@angular/router';
import { EquipoService } from 'src/app/services/equipo.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-equipo-detalle',
  templateUrl: './equipo-detalle.component.html',
  styleUrls: ['./equipo-detalle.component.css']
})
export class EquipoDetalleComponent implements OnInit {
  equipo:Equipo;

  constructor(private equipoService:EquipoService, private route: ActivatedRoute, private router:  Router) {
    this.equipo=new Equipo;
   }

  ngOnInit() {
    const equipoId = this.route.snapshot.paramMap.get("equipoId");
    this.equipoService.getEquipo(equipoId).subscribe(e => {
      this.equipo = e;
    });   
  }
  onEdit(){ 
    this.router.navigateByUrl(`/equipos/${this.equipo.id}/edit`);
  }

  onDelete(equipo:Equipo){
    this.equipoService.deleteEquipo(equipo).subscribe();
    this.router.navigateByUrl(`/`);

  }

}
