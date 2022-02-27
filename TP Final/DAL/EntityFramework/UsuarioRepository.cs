﻿using Microsoft.EntityFrameworkCore;
using System.Linq;
using TP_Final.DAL;
using TP_Final.DAL.EntityFramework;
using TP_Final.Domain;

namespace EJ_2.DAL.EntityFramework
{
    public class UsuarioRepository : Repository<Usuario, AccountManagerDbContext>, IUsuarioRepository
    {
        private readonly DbContext iDbContext;

        public UsuarioRepository(AccountManagerDbContext pContext) : base(pContext)
        {
            iDbContext = pContext;
        }

        public Usuario GetPorUsuario(string pNombreUsuario)
        {
            return this.iDbContext.Set<Usuario>().FirstOrDefault(usuario => usuario.Nombre == pNombreUsuario);
        }
    }
}
