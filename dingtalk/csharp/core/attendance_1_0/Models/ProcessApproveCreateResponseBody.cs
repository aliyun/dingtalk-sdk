// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkattendance_1_0.Models
{
    public class ProcessApproveCreateResponseBody : TeaModel {
        /// <summary>
        /// 审批单返回对象
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public ProcessApproveCreateResponseBodyResult Result { get; set; }
        public class ProcessApproveCreateResponseBodyResult : TeaModel {
            /// <summary>
            /// 钉钉侧生成的审批单id
            /// </summary>
            [NameInMap("dingtalkApproveId")]
            [Validation(Required=false)]
            public string DingtalkApproveId { get; set; }

        }

    }

}
