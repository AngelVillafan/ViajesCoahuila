using FluentValidation;

namespace ViajesCoahuilaAPI.Validations
{
    public class UsuariosValidator:AbstractValidator<Usuario>
    {
        public UsuariosValidator()
        {
            RuleFor(x => x.Alias)
                .NotEmpty()
                .WithMessage("No se proporcionó un valor para Alias");
            RuleFor(x => x.Alias)
                .MaximumLength(30)
                .WithMessage("El valor para Alias excede los 30 caracteres");
            RuleFor(x => x.Nombre)
                .NotEmpty()
                .WithMessage("No se proporcionó un valor para Nombre");
            RuleFor(x => x.Nombre)
                .MaximumLength(60)
                .WithMessage("El valor para Nombre excede los 60 caracteres");
            RuleFor(x => x.Telefono)
                .NotEmpty()
                .WithMessage("No se proporcionó un valor para Telefono");
            RuleFor(x => x.Telefono)
                .MaximumLength(10)
                .WithMessage("El valor para Telefono excede los 10 caracteres");
            RuleFor(x => x.CalificacionChofer)
                .InclusiveBetween(1, 5)
                .WithMessage("El valor para la califiación " +
                "como chofer esta fuera del rango");
            RuleFor(x => x.CalificacionPasajero)
                .InclusiveBetween(1, 5)
                .WithMessage("El valor para la califiación " +
                "como pasajero esta fuera del rango");
        }
    }
}
