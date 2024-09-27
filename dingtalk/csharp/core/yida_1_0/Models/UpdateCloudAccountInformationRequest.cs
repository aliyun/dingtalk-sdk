// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkyida_1_0.Models
{
    public class UpdateCloudAccountInformationRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>hexaaaa</para>
        /// </summary>
        [NameInMap("accessKey")]
        [Validation(Required=false)]
        public string AccessKey { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("accountNumber")]
        [Validation(Required=false)]
        public string AccountNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>44234122</para>
        /// </summary>
        [NameInMap("callerUnionId")]
        [Validation(Required=false)]
        public string CallerUnionId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Business</para>
        /// </summary>
        [NameInMap("commodityType")]
        [Validation(Required=false)]
        public string CommodityType { get; set; }

    }

}
