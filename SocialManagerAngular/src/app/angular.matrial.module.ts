import { NgModule } from '@angular/core';
import {MatMenuModule} from '@angular/material/menu';
import {MatButtonModule} from '@angular/material/button';

@NgModule({
  imports: [MatMenuModule, MatButtonModule ],
  exports: [MatMenuModule, MatButtonModule ]
})
export class AngularMatrialModule { }
