import { Injectable } from '@angular/core';
import { NgxSpinnerService } from 'ngx-spinner';

@Injectable({
  providedIn: 'root'
})
export class BusyService {
  bussyRquestCount = 0;

  constructor(private spinnerService: NgxSpinnerService) { }

  busy(){
    this.bussyRquestCount++;
    this.spinnerService.show(undefined, {
      bdColor: 'rgba(255,255,255,0)',
      color: '#333333',
      type: 'line-scale-party'
    });
  }

  idle() {
    this.bussyRquestCount--;
    if (this.bussyRquestCount <= 0) {
      this.bussyRquestCount = 0;
      this.spinnerService.hide();
    }
  }
}
