import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'category'
})
export class CategoryPipe implements PipeTransform {
  // returns array where categoryId == args, for example: 'category: 2'; args = 2
  transform(items: any[], args: any[]): any {
    return items.filter(item => item.categoryId == args);
  }

}
