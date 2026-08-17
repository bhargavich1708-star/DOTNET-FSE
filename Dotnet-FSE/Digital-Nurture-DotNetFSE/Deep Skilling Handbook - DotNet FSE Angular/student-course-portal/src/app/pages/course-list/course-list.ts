import { Component, OnInit } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CourseCard } from '../../components/course-card/course-card'; 

@Component({
  selector: 'app-course-list',
  standalone: true,
  imports: [CommonModule, CourseCard], 
  templateUrl: './course-list.html',
  styleUrl: './course-list.css'
})
export class CourseList implements OnInit {
  isLoading = true;
  
  // Updated with gradeStatus
  courses = [
    { id: 1, name: 'Cyber Security Basics', code: 'CS101', credits: 3, gradeStatus: 'passed', price: 49.99, startDate: new Date('2026-08-01') },
    { id: 2, name: 'Ethical Hacking', code: 'CS201', credits: 4, gradeStatus: 'pending', price: 79.50, startDate: new Date('2026-08-15') },
    { id: 3, name: 'Network Defense', code: 'CS301', credits: 3, gradeStatus: 'failed', price: 59.00, startDate: new Date('2026-09-10') }
  ];

  selectedCourseId: number | null = null;

  ngOnInit() {
    // Simulate loading for 1.5 seconds
    setTimeout(() => {
      this.isLoading = false;
    }, 1500);
  }

  onEnroll(courseId: number) {
    this.selectedCourseId = courseId;
  }

  // trackBy improves performance by only re-rendering changed items[cite: 15]
  trackByCourseId(index: number, course: any): number {
    return course.id;
  }
}