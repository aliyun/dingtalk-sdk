// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkbizfinance_1_0.Models
{
    public class CreateCustomerRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>55001121</para>
        /// </summary>
        [NameInMap("creator")]
        [Validation(Required=false)]
        public string Creator { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>abc</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="http://www.abc.com">www.abc.com</a></para>
        /// </summary>
        [NameInMap("drawerEmail")]
        [Validation(Required=false)]
        public string DrawerEmail { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>12345678901</para>
        /// </summary>
        [NameInMap("drawerTelephone")]
        [Validation(Required=false)]
        public string DrawerTelephone { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>张三</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>abc</para>
        /// </summary>
        [NameInMap("purchaserAccount")]
        [Validation(Required=false)]
        public string PurchaserAccount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>杭州市</para>
        /// </summary>
        [NameInMap("purchaserAddress")]
        [Validation(Required=false)]
        public string PurchaserAddress { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>建行</para>
        /// </summary>
        [NameInMap("purchaserBankName")]
        [Validation(Required=false)]
        public string PurchaserBankName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>李四</para>
        /// </summary>
        [NameInMap("purchaserName")]
        [Validation(Required=false)]
        public string PurchaserName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1333</para>
        /// </summary>
        [NameInMap("purchaserTaxNo")]
        [Validation(Required=false)]
        public string PurchaserTaxNo { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>13333333333</para>
        /// </summary>
        [NameInMap("purchaserTel")]
        [Validation(Required=false)]
        public string PurchaserTel { get; set; }

    }

}
