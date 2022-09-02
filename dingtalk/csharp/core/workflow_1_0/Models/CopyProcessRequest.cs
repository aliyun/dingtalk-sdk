// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkworkflow_1_0.Models
{
    public class CopyProcessRequest : TeaModel {
        /// <summary>
        /// 复制选项
        /// </summary>
        [NameInMap("copyOptions")]
        [Validation(Required=false)]
        public CopyProcessRequestCopyOptions CopyOptions { get; set; }
        public class CopyProcessRequestCopyOptions : TeaModel {
            /// <summary>
            /// 默认为1
            /// COPE_TYPE_DEFAULT = 1 默认会使用groupId进行隔离分组，审批首页不可见
            /// COPE_TYPE_INCLUDE_FLOW = 2 使用dingtalk 2作为隔离分组，审批首页可见
            /// </summary>
            [NameInMap("copyType")]
            [Validation(Required=false)]
            public int? CopyType { get; set; }

        }

        [NameInMap("sourceCorpId")]
        [Validation(Required=false)]
        public string SourceCorpId { get; set; }

        /// <summary>
        /// 源模版列表
        /// </summary>
        [NameInMap("sourceProcessVOList")]
        [Validation(Required=false)]
        public List<CopyProcessRequestSourceProcessVOList> SourceProcessVOList { get; set; }
        public class CopyProcessRequestSourceProcessVOList : TeaModel {
            /// <summary>
            /// 套件业务标识
            /// </summary>
            [NameInMap("bizType")]
            [Validation(Required=false)]
            public string BizType { get; set; }

            /// <summary>
            /// 模板名称
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// 模板code
            /// </summary>
            [NameInMap("processCode")]
            [Validation(Required=false)]
            public string ProcessCode { get; set; }

        }

    }

}
