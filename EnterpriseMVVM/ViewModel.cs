using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EnterpriseMVVM
{
    public abstract class ViewModel : ObservableObject, IDataErrorInfo
    {
        public string this[string columnName]
        {
            get
            {
                return OnValidate(columnName);
            }
        }

        public string Error
        {
            get;
            private set;
        }


        protected virtual string OnValidate(string propertyName)
        {
            var context = new ValidationContext(this)
            {
                MemberName = propertyName
            };

            var results = new Collection<ValidationResult>();
            var isvalid = Validator.TryValidateObject(this, context, results, true);
            if (isvalid)
            {
                this.Error = "";
            }
            else
            {
                foreach(var r in results)
                {
                    this.Error += r;
                }
               
            }

            return !isvalid ? results[0].ErrorMessage : null;



        }


    }
}
