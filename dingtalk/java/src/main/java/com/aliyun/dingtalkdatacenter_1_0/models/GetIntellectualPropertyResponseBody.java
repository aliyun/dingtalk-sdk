// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class GetIntellectualPropertyResponseBody extends TeaModel {
    /**
     * <p>返回结果</p>
     * <p>EntName:公司名称</p>
     * <p>Number:登记证号</p>
     * <p>Type:种类</p>
     * <p>Pledgor:出质人名称</p>
     * <p>Pawnee:质权人名称</p>
     * <p>Period:质权登记期限</p>
     * <p>Status:出质状态</p>
     * <p>PublicDate:公示日期</p>
     */
    @NameInMap("data")
    public String data;

    /**
     * <p>总条数</p>
     */
    @NameInMap("total")
    public Long total;

    public static GetIntellectualPropertyResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetIntellectualPropertyResponseBody self = new GetIntellectualPropertyResponseBody();
        return TeaModel.build(map, self);
    }

    public GetIntellectualPropertyResponseBody setData(String data) {
        this.data = data;
        return this;
    }
    public String getData() {
        return this.data;
    }

    public GetIntellectualPropertyResponseBody setTotal(Long total) {
        this.total = total;
        return this;
    }
    public Long getTotal() {
        return this.total;
    }

}
