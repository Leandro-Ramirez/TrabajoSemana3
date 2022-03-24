#region Usos
using Autofac;
using System;
using System.Linq;
using AppCore.Services;
using Domain.Interfaces;
using AppCore.IServices;
using System.Windows.Forms;
using System.Threading.Tasks;
using Infraestructure.Repository;
using System.Collections.Generic;
#endregion

namespace practicaDepreciacion
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]

        #region Accion
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var builder = new ContainerBuilder();

            builder.RegisterType<BinaryActivoRepository>().As<IActivoModel>();
            builder.RegisterType<ActivoServices>().As<IActivoServices>();

            var container = builder.Build();

            Application.Run(new FrmActivos(container.Resolve<IActivoServices>()));
        }
        #endregion
    }
}