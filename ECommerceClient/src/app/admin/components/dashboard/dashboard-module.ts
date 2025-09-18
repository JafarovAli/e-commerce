import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { Dashboard } from './dashboard';
import { RouterModule } from '@angular/router';



@NgModule({
  declarations: [],
  imports: [
    CommonModule,
    Dashboard,
    RouterModule.forChild([
      { path: "", component: Dashboard }
    ])
  ]
})
export class DashboardModule { }
