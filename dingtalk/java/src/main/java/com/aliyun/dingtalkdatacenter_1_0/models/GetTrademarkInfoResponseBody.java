// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class GetTrademarkInfoResponseBody extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>[{ &quot;entName:企业名称&quot;, &quot;trademarkName:商标名称&quot;, &quot;regNum:商标注册号&quot;, &quot;trademarkType:商标类型&quot;, &quot;trademarkForm:商标形式&quot;, &quot;trademarkStatus:商标状态&quot;, &quot;applyDate:申请日期&quot;, &quot;imageUrl:图片链接&quot;, &quot;typeName:商标类型名&quot;, &quot;period:专用权期限&quot;, &quot;agent:代理人名称&quot;, &quot;regPubNo:注册公告号&quot;, &quot;regPubDate:注册公告日期&quot;, &quot;firstPubNo:初审公告号&quot;, &quot;firstPubDate:初审公告日期&quot;}]</p>
     */
    @NameInMap("data")
    public String data;

    @NameInMap("total")
    public Long total;

    public static GetTrademarkInfoResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetTrademarkInfoResponseBody self = new GetTrademarkInfoResponseBody();
        return TeaModel.build(map, self);
    }

    public GetTrademarkInfoResponseBody setData(String data) {
        this.data = data;
        return this;
    }
    public String getData() {
        return this.data;
    }

    public GetTrademarkInfoResponseBody setTotal(Long total) {
        this.total = total;
        return this;
    }
    public Long getTotal() {
        return this.total;
    }

}
