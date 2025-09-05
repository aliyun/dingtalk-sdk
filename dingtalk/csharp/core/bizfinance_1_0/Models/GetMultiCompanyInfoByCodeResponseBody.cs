// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkbizfinance_1_0.Models
{
    public class GetMultiCompanyInfoByCodeResponseBody : TeaModel {
        [NameInMap("accountantEnableDate")]
        [Validation(Required=false)]
        public string AccountantEnableDate { get; set; }

        [NameInMap("accountingStandard")]
        [Validation(Required=false)]
        public string AccountingStandard { get; set; }

        [NameInMap("advancedSettingList")]
        [Validation(Required=false)]
        public List<GetMultiCompanyInfoByCodeResponseBodyAdvancedSettingList> AdvancedSettingList { get; set; }
        public class GetMultiCompanyInfoByCodeResponseBodyAdvancedSettingList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>relateedInvoice</para>
            /// </summary>
            [NameInMap("advancedSettingKey")]
            [Validation(Required=false)]
            public string AdvancedSettingKey { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>关联发票</para>
            /// </summary>
            [NameInMap("advancedSettingName")]
            [Validation(Required=false)]
            public string AdvancedSettingName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>123456789</para>
            /// </summary>
            [NameInMap("endDate")]
            [Validation(Required=false)]
            public long? EndDate { get; set; }

            [NameInMap("value")]
            [Validation(Required=false)]
            public bool? Value { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>COM_DEFAULT</para>
        /// </summary>
        [NameInMap("companyCode")]
        [Validation(Required=false)]
        public string CompanyCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>钉钉</para>
        /// </summary>
        [NameInMap("companyName")]
        [Validation(Required=false)]
        public string CompanyName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>备注</para>
        /// </summary>
        [NameInMap("remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>valid</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>generalTaxpayer</para>
        /// </summary>
        [NameInMap("taxNature")]
        [Validation(Required=false)]
        public string TaxNature { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>123456789012345</para>
        /// </summary>
        [NameInMap("taxNo")]
        [Validation(Required=false)]
        public string TaxNo { get; set; }

    }

}
