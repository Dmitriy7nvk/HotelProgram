//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HotelProgram
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;

    public partial class service
    {
        public int service_id { get; set; }
        public int additional_orders_id { get; set; }
        public int service_name_id { get; set; }
    
        public virtual additional_orders additional_orders { get; set; }
        public virtual service_name service_name
        {
            get => _service_name;
            set
            {
                if (_service_name != value)
                {
                    _service_name = value;
                    OnPropertyChanged(nameof(service_name));
                    OnPropertyChanged(nameof(service_cost));
                }
            }
        }
        private service_name _service_name;

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public decimal service_cost => _service_name?.service_cost ?? 0;
    }
}