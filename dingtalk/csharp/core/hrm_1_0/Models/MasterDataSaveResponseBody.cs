// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkhrm_1_0.Models
{
    public class MasterDataSaveResponseBody : TeaModel {
        /// <summary>
        /// 是否全部保存成功
        /// </summary>
        [NameInMap("allSuccess")]
        [Validation(Required=false)]
        public bool? AllSuccess { get; set; }

        /// <summary>
        /// 保存失败的结果，全部保存成功时为空
        /// </summary>
        [NameInMap("failResult")]
        [Validation(Required=false)]
        public List<MasterDataSaveResponseBodyFailResult> FailResult { get; set; }
        public class MasterDataSaveResponseBodyFailResult : TeaModel {
            /// <summary>
            /// 业务流水唯一标识，和入参一致
            /// </summary>
            [NameInMap("bizUk")]
            [Validation(Required=false)]
            public string BizUk { get; set; }

            /// <summary>
            /// 是否成功
            /// </summary>
            [NameInMap("success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }

            /// <summary>
            /// 错误码
            /// </summary>
            [NameInMap("errorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            /// <summary>
            /// 错误信息
            /// </summary>
            [NameInMap("errorMsg")]
            [Validation(Required=false)]
            public string ErrorMsg { get; set; }

        }

    }

}
