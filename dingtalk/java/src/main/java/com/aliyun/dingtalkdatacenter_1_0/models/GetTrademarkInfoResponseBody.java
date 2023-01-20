// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class GetTrademarkInfoResponseBody extends TeaModel {
    /**
     * <p>返回结果</p>
     * <p>entName:企业名称</p>
     * <p>trademarkName:商标名称</p>
     * <p>regNum:商标注册号</p>
     * <p>trademarkType:商标类型</p>
     * <p>trademarkForm:商标形式</p>
     * <p>trademarkStatus:商标状态</p>
     * <p>applyDate:申请日期</p>
     * <p>imageUrl:图片链接</p>
     * <p>typeName:商标类型名</p>
     * <p>period:专用权期限</p>
     * <p>agent:代理人名称</p>
     * <p>regPubNo:注册公告号</p>
     * <p>regPubDate:注册公告日期</p>
     * <p>firstPubNo:初审公告号</p>
     * <p>firstPubDate:初审公告日期</p>
     */
    @NameInMap("data")
    public String data;

    /**
     * <p>总条数</p>
     */
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
