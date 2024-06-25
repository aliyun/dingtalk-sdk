// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_2_0.models;

import com.aliyun.tea.*;

public class UpdateInstanceOrderInfoShrinkRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>xxx错误</p>
     */
    @NameInMap("failReason")
    public String failReason;

    /**
     * <strong>example:</strong>
     * <p>abc</p>
     */
    @NameInMap("orderNo")
    public String orderNo;

    /**
     * <strong>example:</strong>
     * <p>123</p>
     */
    @NameInMap("outOrderNo")
    public String outOrderNo;

    @NameInMap("payerBank")
    public String payerBankShrink;

    /**
     * <strong>example:</strong>
     * <p>1709691000682</p>
     */
    @NameInMap("paymentTime")
    public Long paymentTime;

    /**
     * <strong>example:</strong>
     * <p>PAYING</p>
     */
    @NameInMap("status")
    public String status;

    /**
     * <strong>example:</strong>
     * <p>123</p>
     */
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

    public UpdateInstanceOrderInfoShrinkRequest setPaymentTime(Long paymentTime) {
        this.paymentTime = paymentTime;
        return this;
    }
    public Long getPaymentTime() {
        return this.paymentTime;
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
