﻿using Application.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DAL
{
    public class Loan : ISoftDeleteable
    {
        public Guid LoanId { get; set; } = Guid.NewGuid();

        public DateTime LoanDate { get; set; } = DateTime.UtcNow;
        /// <summary>
        /// 7 days is te maximum number of days the book can be in loan 
        /// </summary>
        public DateTime DueDate { get; set; } = DateTime.UtcNow.AddDays(7);
        public DateTime? ReturnDate { get; set; }
        public bool IsReturned { get; set; } = false;
        public bool IsDeleted { set; get; } = false;

        /// relations
        public Guid? BookId { get; set; }
        public Book? Book { get; set; }
        /// <summary>
        /// <summary>
        ///  IdentityUser Id is a GUID ( string ) 
        /// </summary>
        public Guid? MemberId { get; set; }
        public ApplicationUser? Member { get; set; }
        public Penalty? Penalty { get; set; }
    }
}
