// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdatacenter_1_0.Models
{
    public class GetTrademarkInfoResponseBody : TeaModel {
        /// <summary>
        /// 返回结果
        /// entName:企业名称
        /// trademarkName:商标名称
        /// regNum:商标注册号
        /// trademarkType:商标类型
        /// trademarkForm:商标形式
        /// trademarkStatus:商标状态
        /// applyDate:申请日期
        /// imageUrl:图片链接
        /// typeName:商标类型名
        /// period:专用权期限
        /// agent:代理人名称
        /// regPubNo:注册公告号
        /// regPubDate:注册公告日期
        /// firstPubNo:初审公告号
        /// firstPubDate:初审公告日期
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
