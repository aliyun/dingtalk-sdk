// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontract_1_0.Models
{
    public class FinishReviewOrderRequest : TeaModel {
        [NameInMap("endFiles")]
        [Validation(Required=false)]
        public List<FinishReviewOrderRequestEndFiles> EndFiles { get; set; }
        public class FinishReviewOrderRequestEndFiles : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>合同文件</para>
            /// </summary>
            [NameInMap("fileName")]
            [Validation(Required=false)]
            public string FileName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>12</para>
            /// </summary>
            [NameInMap("fileSize")]
            [Validation(Required=false)]
            public string FileSize { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>word</para>
            /// </summary>
            [NameInMap("fileType")]
            [Validation(Required=false)]
            public string FileType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("fileVersion")]
            [Validation(Required=false)]
            public int? FileVersion { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="http://oss.com">http://oss.com</a></para>
            /// </summary>
            [NameInMap("url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("extension")]
        [Validation(Required=false)]
        public string Extension { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>12345678</para>
        /// </summary>
        [NameInMap("orderId")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

    }

}
