using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Ulatina.PrograAvanzada.AW.Wcf
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        string GetData(int value);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);


        [OperationContract]
        Model.Product EncontrarProductoPorNumero(string elNumero);

        [OperationContract]
        IList<Model.Product> ListarTodos();

        [OperationContract]
        IList <Model.Product> BuscarProductoPorRangoDePrecio(decimal elPrecioInferior, decimal elPrecioSuperior);

        [OperationContract]
        IList<Model.SalesOrderHeader> BuscarVentas();
        //examen
        [OperationContract]
        IList<Model.SalesOrderHeader> BuscarVentasPorRangoFechaEnOrden(DateTime fecha1, DateTime fecha2);

        [OperationContract]
        IList<Model.SalesOrderHeader> BuscarVentasPorRangoTotal(decimal total1, decimal total2);

        [OperationContract]
        IList<Model.SalesOrderHeader> BuscarVentasPorDescuento(decimal desc);

        [OperationContract]
        IList<Model.SalesOrderHeader> BuscarVentasPorVentasPorCantidad(short canti);

        [OperationContract]
        IList<Model.SalesOrderHeader> BuscarVentasPorVentasPorGenero(string gen);

        [OperationContract]
        IList<Model.SalesOrderHeader> BuscarVentasPorRangoEdad(DateTime fecha1, DateTime fecha2);

        [OperationContract]
        IList<Model.SalesOrderHeader> BuscarVentasPorAntiguedad(DateTime fecha1, DateTime fecha2);

        [OperationContract]
        IList<Model.SalesOrderHeader> BuscarVentasPorContieneNombreApellido(string name);
        //examen
    }


    // Utilice un contrato de datos, como se ilustra en el ejemplo siguiente, para agregar tipos compuestos a las operaciones de servicio.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
