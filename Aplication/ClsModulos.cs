﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
    public class ClsModulos : IContrato
    {
        public static List<string> ModulosUsuario;
        public override bool agragar(object ob)
        {
            using (CapaDatos.bulonera2Entities1 db = new CapaDatos.bulonera2Entities1())
            {
                using (var Transaction = db.Database.BeginTransaction())
                {
                    try
                    {

                        db.MODULOS.Add(((CapaDatos.MODULOS)ob));
                        db.SaveChanges();
                        Transaction.Commit();
                        Transaction.Dispose();
                    }
                    catch (Exception)
                    {

                        Transaction.Rollback();
                    }

                }
            }
            return true;
        }

        public override bool eliminar(int Id)
        {
            using (CapaDatos.bulonera2Entities1 db = new CapaDatos.bulonera2Entities1())
            {
                try
                {
                    CapaDatos.MODULOS ModuloBorrar = (from x in db.MODULOS where x.ID_MODULO == Id select x).FirstOrDefault();
                    db.MODULOS.Remove(ModuloBorrar);
                    db.SaveChanges();
                    return true;
                }
                catch (Exception)
                {

                    return false;
                }
            }
        }

        public override bool MOdificar(int id)
        {
            throw new NotImplementedException();
        }

        public override int OptenerId(string Text)
        {
            using (CapaDatos.bulonera2Entities1 db = new CapaDatos.bulonera2Entities1())
            {
                int _id = Convert.ToInt32((from x in db.MODULOS where x.NOMBRE_MOD == Text select x.ID_MODULO).FirstOrDefault());
                return _id;
            }
        }

        public override List<object> traerTodos(object ob)
        {
            throw new NotImplementedException();
        }
    }
}