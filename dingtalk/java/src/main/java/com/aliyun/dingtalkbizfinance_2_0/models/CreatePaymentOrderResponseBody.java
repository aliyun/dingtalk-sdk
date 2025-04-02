// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_2_0.models;

import com.aliyun.tea.*;

public class CreatePaymentOrderResponseBody extends TeaModel {
    @NameInMap("expireTime")
    public Long expireTime;

    @NameInMap("orderNo")
    public String orderNo;

    @NameInMap("outBizNo")
    public String outBizNo;

    public static CreatePaymentOrderResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CreatePaymentOrderResponseBody self = new CreatePaymentOrderResponseBody();
        return TeaModel.build(map, self);
    }

    public CreatePaymentOrderResponseBody setExpireTime(Long expireTime) {
        this.expireTime = expireTime;
        return this;
    }
    public Long getExpireTime() {
        return this.expireTime;
    }

    public CreatePaymentOrderResponseBody setOrderNo(String orderNo) {
        this.orderNo = orderNo;
        return this;
    }
    public String getOrderNo() {
        return this.orderNo;
    }

    public CreatePaymentOrderResponseBody setOutBizNo(String outBizNo) {
        this.outBizNo = outBizNo;
        return this;
    }
    public String getOutBizNo() {
        return this.outBizNo;
    }

}
