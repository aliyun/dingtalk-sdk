// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class ChatMemoFaqAddRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>办公室的电话是：13222333232</para>
        /// </summary>
        [NameInMap("answer")]
        [Validation(Required=false)]
        public string Answer { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>aaaaa</para>
        /// </summary>
        [NameInMap("bizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>111111</para>
        /// </summary>
        [NameInMap("datasetId")]
        [Validation(Required=false)]
        public long? DatasetId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>办公室的电话是多少</para>
        /// </summary>
        [NameInMap("question")]
        [Validation(Required=false)]
        public string Question { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://xxxxxxx.com/xxxxxx">https://xxxxxxx.com/xxxxxx</a></para>
        /// </summary>
        [NameInMap("redirection")]
        [Validation(Required=false)]
        public string Redirection { get; set; }

    }

}
