using CleanApp.Domain.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanApp.Application.Validators
{
    public class TodoItemValidator: AbstractValidator<TodoItem>
    {
        public TodoItemValidator()
        {
            RuleFor(x => x.Description).NotEmpty().Length(4, 24);
        }
    }
}
