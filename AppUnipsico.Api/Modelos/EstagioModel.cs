﻿using AppUnipsico.Api.Modelos;

namespace AppUnipsico.Api.Models
{
    public class EstagioModel
    {
        public Guid EstagioId { get; set; }
        public DateTime EstagioDataRealizacao { get; set; }
        public Guid AlunoId { get; set; }
        public AlunoModel Aluno { get; set; } = new AlunoModel();
        public Guid InstituicaoId { get; set; }
        public InstituicaoModel Instituicao { get; set; } = new InstituicaoModel();
    }
}
