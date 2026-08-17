import { Component, Input, Output, EventEmitter, OnChanges, SimpleChanges } from '@angular/core';
import { CommonModule } from '@angular/common'; 
import { FormatCodePipe } from '../../pipes/format-code'; 

@Component({
  selector: 'app-course-card',
  standalone: true,
  imports: [CommonModule, FormatCodePipe], 
  templateUrl: './course-card.html',
  styleUrl: './course-card.css'
})
export class CourseCard implements OnChanges {
  @Input() course!: { id: number, name: string, code: string, credits: number, gradeStatus: string, price: number, startDate: Date };
  @Output() enrollRequested = new EventEmitter<number>();

  ngOnChanges(changes: SimpleChanges) {
    if (changes['course']) {
      console.log('Course changed from:', changes['course'].previousValue, 'to:', changes['course'].currentValue);
    }
  }
}