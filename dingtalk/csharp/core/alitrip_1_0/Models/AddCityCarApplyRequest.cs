// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkalitrip_1_0.Models
{
    public class AddCityCarApplyRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("cause")]
        [Validation(Required=false)]
        public string Cause { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("city")]
        [Validation(Required=false)]
        public string City { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("corpId")]
        [Validation(Required=false)]
        public string CorpId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("date")]
        [Validation(Required=false)]
        public string Date { get; set; }

        [NameInMap("finishedDate")]
        [Validation(Required=false)]
        public string FinishedDate { get; set; }

        [NameInMap("projectCode")]
        [Validation(Required=false)]
        public string ProjectCode { get; set; }

        [NameInMap("projectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public long? Status { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("thirdPartApplyId")]
        [Validation(Required=false)]
        public string ThirdPartApplyId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("thirdPartCostCenterId")]
        [Validation(Required=false)]
        public string ThirdPartCostCenterId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("thirdPartInvoiceId")]
        [Validation(Required=false)]
        public string ThirdPartInvoiceId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("timesTotal")]
        [Validation(Required=false)]
        public long? TimesTotal { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("timesType")]
        [Validation(Required=false)]
        public long? TimesType { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("timesUsed")]
        [Validation(Required=false)]
        public long? TimesUsed { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
