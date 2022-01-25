// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class QueryPayResultRequest extends TeaModel {
    // 订单号
    @NameInMap("orderNo")
    public String orderNo;

    // 设备序列号
    @NameInMap("sn")
    public String sn;

    // 用户id
    @NameInMap("userId")
    public String userId;

    public static QueryPayResultRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryPayResultRequest self = new QueryPayResultRequest();
        return TeaModel.build(map, self);
    }

    public QueryPayResultRequest setOrderNo(String orderNo) {
        this.orderNo = orderNo;
        return this;
    }
    public String getOrderNo() {
        return this.orderNo;
    }

    public QueryPayResultRequest setSn(String sn) {
        this.sn = sn;
        return this;
    }
    public String getSn() {
        return this.sn;
    }

    public QueryPayResultRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
