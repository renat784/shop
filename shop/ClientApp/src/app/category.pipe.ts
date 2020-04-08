import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'category'
})
export class CategoryPipe implements PipeTransform {

  transform(items: any[], args: any[]): any {
    return items.filter(item => item.categoryId == args);
}

}
