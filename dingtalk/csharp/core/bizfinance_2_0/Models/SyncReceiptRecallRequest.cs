// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkbizfinance_2_0.Models
{
    public class SyncReceiptRecallRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>https:xxxx.pdf</para>
        /// </summary>
        [NameInMap("fileDownloadUrl")]
        [Validation(Required=false)]
        public string FileDownloadUrl { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1234.pdf</para>
        /// </summary>
        [NameInMap("fileName")]
        [Validation(Required=false)]
        public string FileName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("orderNo")]
        [Validation(Required=false)]
        public string OrderNo { get; set; }

    }

}
