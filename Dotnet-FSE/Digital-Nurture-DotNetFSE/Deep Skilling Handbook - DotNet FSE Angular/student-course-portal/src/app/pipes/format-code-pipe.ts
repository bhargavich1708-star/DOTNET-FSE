import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'formatCode',
  standalone: true
})
export class FormatCodePipe implements PipeTransform {
  transform(value: string): string {
    if (!value) return '';
    // Inserts a dash between letters and numbers (e.g., CS101 -> CS-101)
    const formatted = value.replace(/([a-zA-Z]+)(\d+)/, '$1-$2');
    return `Code: ${formatted}`;
  }
}