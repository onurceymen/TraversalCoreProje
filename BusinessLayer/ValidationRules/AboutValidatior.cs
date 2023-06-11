using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
	public class AboutValidatior : AbstractValidator<About>
	{
		public AboutValidatior()
		{
			RuleFor(x => x.Description).NotEmpty().WithMessage("Bu Alan boş geçilemez");
		}
	}
}
