// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkworkflow_1_0.Models
{
    public class CopyProcessRequest : TeaModel {
        [NameInMap("copyOptions")]
        [Validation(Required=false)]
        public CopyProcessRequestCopyOptions CopyOptions { get; set; }
        public class CopyProcessRequestCopyOptions : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("copyType")]
            [Validation(Required=false)]
            public int? CopyType { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dingabc</para>
        /// </summary>
        [NameInMap("sourceCorpId")]
        [Validation(Required=false)]
        public string SourceCorpId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("sourceProcessVOList")]
        [Validation(Required=false)]
        public List<CopyProcessRequestSourceProcessVOList> SourceProcessVOList { get; set; }
        public class CopyProcessRequestSourceProcessVOList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>abc</para>
            /// </summary>
            [NameInMap("bizType")]
            [Validation(Required=false)]
            public string BizType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>abc</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>proc-abc</para>
            /// </summary>
            [NameInMap("processCode")]
            [Validation(Required=false)]
            public string ProcessCode { get; set; }

        }

    }

}
