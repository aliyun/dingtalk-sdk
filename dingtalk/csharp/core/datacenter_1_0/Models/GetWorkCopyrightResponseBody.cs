// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdatacenter_1_0.Models
{
    public class GetWorkCopyrightResponseBody : TeaModel {
        /// <summary>
        /// 返回结果
        /// EntName:企业名称
        /// CopyName:作品全称
        /// TypeName:作品类别
        /// CopyNum:登记号
        /// SuccessDate:创作完成日期
        /// FirstDate:首次发表日期
        /// ApprovalDate:登记批准日期
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public string Data { get; set; }

        /// <summary>
        /// 总条数
        /// </summary>
        [NameInMap("total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
