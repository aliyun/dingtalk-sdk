// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdatacenter_1_0.Models
{
    public class GetTrademarkInfoResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>[{ &quot;entName:企业名称&quot;, &quot;trademarkName:商标名称&quot;, &quot;regNum:商标注册号&quot;, &quot;trademarkType:商标类型&quot;, &quot;trademarkForm:商标形式&quot;, &quot;trademarkStatus:商标状态&quot;, &quot;applyDate:申请日期&quot;, &quot;imageUrl:图片链接&quot;, &quot;typeName:商标类型名&quot;, &quot;period:专用权期限&quot;, &quot;agent:代理人名称&quot;, &quot;regPubNo:注册公告号&quot;, &quot;regPubDate:注册公告日期&quot;, &quot;firstPubNo:初审公告号&quot;, &quot;firstPubDate:初审公告日期&quot;}]</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public string Data { get; set; }

        [NameInMap("total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
