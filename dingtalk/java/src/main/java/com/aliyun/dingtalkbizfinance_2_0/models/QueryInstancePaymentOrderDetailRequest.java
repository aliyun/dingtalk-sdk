// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_2_0.models;

import com.aliyun.tea.*;

public class QueryInstancePaymentOrderDetailRequest extends TeaModel {
    @NameInMap("orderNo")
    public String orderNo;

    public static QueryInstancePaymentOrderDetailRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryInstancePaymentOrderDetailRequest self = new QueryInstancePaymentOrderDetailRequest();
        return TeaModel.build(map, self);
    }

    public QueryInstancePaymentOrderDetailRequest setOrderNo(String orderNo) {
        this.orderNo = orderNo;
        return this;
    }
    public String getOrderNo() {
        return this.orderNo;
    }

}
