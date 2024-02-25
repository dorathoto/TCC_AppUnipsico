﻿namespace AppUnipsico.Api.Servicos.Interfaces
{
    public interface ICriptografiaServico
    {
        public string CriptografaSenha(string password);
        public bool VerificaSenha(string password, string hashedPassword);
    }
}
