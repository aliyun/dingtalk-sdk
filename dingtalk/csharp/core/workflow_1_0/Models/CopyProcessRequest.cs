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
            [NameInMap("copyType")]
            [Validation(Required=false)]
            public int? CopyType { get; set; }

        }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("sourceCorpId")]
        [Validation(Required=false)]
        public string SourceCorpId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("sourceProcessVOList")]
        [Validation(Required=false)]
        public List<CopyProcessRequestSourceProcessVOList> SourceProcessVOList { get; set; }
        public class CopyProcessRequestSourceProcessVOList : TeaModel {
            [NameInMap("bizType")]
            [Validation(Required=false)]
            public string BizType { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("processCode")]
            [Validation(Required=false)]
            public string ProcessCode { get; set; }

        }

    }

}
