using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Repository
{
    public class StreamEmpleadoRepository : IEmpleadoModel
    {


        private BinaryReader binaryReader;
        private BinaryWriter binaryWriter;
        private string fileName = "Empleado.dat";
        public StreamEmpleadoRepository()
        {
        }

        public void Add(Empleado t)
        {
            try
            {
                int id = 0;
                Empleado last = Read().LastOrDefault();

                if (last == null)
                {
                    id = 1;
                }
                else
                {
                    id = last.Id + 1;
                }
                using (FileStream fileStream = new FileStream(fileName, FileMode.Append, FileAccess.Write))
                {
                    binaryWriter = new BinaryWriter(fileStream);
                    binaryWriter.Write(id);
                    binaryWriter.Write(t.Nombres);
                    binaryWriter.Write(t.Email);
                    
                    binaryWriter.Write(t.Telefono);
                }
            }
            catch (IOException)
            {
                throw;
            }
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id, List<int> listaIds)
        {
            throw new NotImplementedException();
        }

        public Empleado GetById(int id)
        {
            Empleado empledo = null;
            bool success = false;

            try
            {
                using (FileStream fileStream = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Read))
                {
                    binaryReader = new BinaryReader(fileStream);
                    long length = binaryReader.BaseStream.Length;

                    if (length == 0)
                    {
                        return empledo;
                    }
                    binaryReader.BaseStream.Seek(0, SeekOrigin.Begin);
                    while (binaryReader.BaseStream.Position < length)
                    {
                        empledo = new Empleado()
                        {
                            Id = binaryReader.ReadInt32(),
                            Nombres = binaryReader.ReadString(),

                            Cedula = binaryReader.ReadString(),
                            Email = binaryReader.ReadString(),

                            Telefono = binaryReader.ReadInt32(),
                            CodigoEmpleado = binaryReader.ReadInt32(),
                            
                           


                        };



                        if (empledo.Id == id)
                        {
                            success = true;
                            break;
                        }
                    }
                }
                return success ? empledo : null;
            }
            catch (IOException)
            {
                throw;
            }





        }

        public List<Empleado> Read()
        {
            List<Empleado> empleado = new List<Empleado>();
            try
            {
                using (FileStream fileStream = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Read))
                {
                    binaryReader = new BinaryReader(fileStream);
                    long length = binaryReader.BaseStream.Length;

                    if (length == 0)
                    {
                        return empleado;
                    }
                    binaryReader.BaseStream.Seek(0, SeekOrigin.Begin);
                    while (binaryReader.BaseStream.Position < length)
                    {
                        empleado.Add(new Empleado()
                        {
                            Id = binaryReader.ReadInt32(),
                            Nombres = binaryReader.ReadString(),

                            Cedula = binaryReader.ReadString(),
                            Email = binaryReader.ReadString(),

                            Telefono = binaryReader.ReadInt32(),
                            CodigoEmpleado = binaryReader.ReadInt32(),

                        });
                    }
                }
                return empleado;
            }
            catch (IOException)
            {
                throw;
            }
        }

        public void Update(Empleado t, int id)
        {
            throw new NotImplementedException();
        }
    }
}
