import { Member } from './../../_models/member';
import { MembersService } from './../../_services/members.service';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-member-list',
  templateUrl: './member-list.component.html',
  styleUrls: ['./member-list.component.css']
})
export class MemberListComponent implements OnInit {

  members:Member[];
  constructor(private memberService :MembersService) { }

  ngOnInit(): void {
    this.getMembers();
  }

  getMembers(){
    this.memberService.getMembers().subscribe(members=> {
      this.members = members;
    });
  }

}
