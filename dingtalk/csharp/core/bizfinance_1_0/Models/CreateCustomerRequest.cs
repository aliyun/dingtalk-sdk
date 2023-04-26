// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkbizfinance_1_0.Models
{
    public class CreateCustomerRequest : TeaModel {
        [NameInMap("creator")]
        [Validation(Required=false)]
        public string Creator { get; set; }

        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("drawerEmail")]
        [Validation(Required=false)]
        public string DrawerEmail { get; set; }

        [NameInMap("drawerTelephone")]
        [Validation(Required=false)]
        public string DrawerTelephone { get; set; }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("purchaserAccount")]
        [Validation(Required=false)]
        public string PurchaserAccount { get; set; }

        [NameInMap("purchaserAddress")]
        [Validation(Required=false)]
        public string PurchaserAddress { get; set; }

        [NameInMap("purchaserBankName")]
        [Validation(Required=false)]
        public string PurchaserBankName { get; set; }

        [NameInMap("purchaserName")]
        [Validation(Required=false)]
        public string PurchaserName { get; set; }

        [NameInMap("purchaserTaxNo")]
        [Validation(Required=false)]
        public string PurchaserTaxNo { get; set; }

        [NameInMap("purchaserTel")]
        [Validation(Required=false)]
        public string PurchaserTel { get; set; }

    }

}
