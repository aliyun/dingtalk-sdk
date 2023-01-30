// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdatacenter_1_0.Models
{
    public class GetSoftwareCopyrightResponseBody : TeaModel {
        /// <summary>
        /// 返回结果
        /// EntName:企业名称
        /// CopyNum:登记号
        /// TypeNum:分类号
        /// ShortName:作品简称
        /// CopyName:作品全称
        /// Version:版本号
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
