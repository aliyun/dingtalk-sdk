// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_2_0.models;

import com.aliyun.tea.*;

public class UpdateInstanceOrderInfoShrinkRequest extends TeaModel {
    @NameInMap("failReason")
    public String failReason;

    @NameInMap("orderNo")
    public String orderNo;

    @NameInMap("outOrderNo")
    public String outOrderNo;

    @NameInMap("payerBank")
    public String payerBankShrink;

    @NameInMap("status")
    public String status;

    @NameInMap("userId")
    public String userId;

    public static UpdateInstanceOrderInfoShrinkRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateInstanceOrderInfoShrinkRequest self = new UpdateInstanceOrderInfoShrinkRequest();
        return TeaModel.build(map, self);
    }

    public UpdateInstanceOrderInfoShrinkRequest setFailReason(String failReason) {
        this.failReason = failReason;
        return this;
    }
    public String getFailReason() {
        return this.failReason;
    }

    public UpdateInstanceOrderInfoShrinkRequest setOrderNo(String orderNo) {
        this.orderNo = orderNo;
        return this;
    }
    public String getOrderNo() {
        return this.orderNo;
    }

    public UpdateInstanceOrderInfoShrinkRequest setOutOrderNo(String outOrderNo) {
        this.outOrderNo = outOrderNo;
        return this;
    }
    public String getOutOrderNo() {
        return this.outOrderNo;
    }

    public UpdateInstanceOrderInfoShrinkRequest setPayerBankShrink(String payerBankShrink) {
        this.payerBankShrink = payerBankShrink;
        return this;
    }
    public String getPayerBankShrink() {
        return this.payerBankShrink;
    }

    public UpdateInstanceOrderInfoShrinkRequest setStatus(String status) {
        this.status = status;
        return this;
    }
    public String getStatus() {
        return this.status;
    }

    public UpdateInstanceOrderInfoShrinkRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
