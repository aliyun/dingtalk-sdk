// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class OrderConvertRequest : TeaModel {
        [NameInMap("attachments")]
        [Validation(Required=false)]
        public List<OrderConvertRequestAttachments> Attachments { get; set; }
        public class OrderConvertRequestAttachments : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("fileName")]
            [Validation(Required=false)]
            public string FileName { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("fileUrl")]
            [Validation(Required=false)]
            public string FileUrl { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("operateUserId")]
        [Validation(Required=false)]
        public string OperateUserId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ruleBizId")]
        [Validation(Required=false)]
        public string RuleBizId { get; set; }

    }

}
