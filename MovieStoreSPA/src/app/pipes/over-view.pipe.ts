import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'overView'
})
export class OverViewPipe implements PipeTransform {

  transform(value: string): any {
    return value.substr(0,50)+"...";
  }

}
