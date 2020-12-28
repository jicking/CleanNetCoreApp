using $ext_safeprojectname$.Domain.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace $ext_safeprojectname$.Application.Validators
{
    public class TodoItemValidator: AbstractValidator<TodoItem>
    {
        public TodoItemValidator()
        {
            RuleFor(x => x.Description).NotEmpty().Length(4, 24);
        }
    }
}
