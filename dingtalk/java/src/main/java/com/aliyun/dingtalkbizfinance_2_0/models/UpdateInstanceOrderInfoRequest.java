// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_2_0.models;

import com.aliyun.tea.*;

public class UpdateInstanceOrderInfoRequest extends TeaModel {
    @NameInMap("failReason")
    public String failReason;

    @NameInMap("orderNo")
    public String orderNo;

    @NameInMap("outOrderNo")
    public String outOrderNo;

    @NameInMap("payerBank")
    public UpdateInstanceOrderInfoRequestPayerBank payerBank;

    @NameInMap("paymentTime")
    public Long paymentTime;

    @NameInMap("status")
    public String status;

    @NameInMap("userId")
    public String userId;

    public static UpdateInstanceOrderInfoRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateInstanceOrderInfoRequest self = new UpdateInstanceOrderInfoRequest();
        return TeaModel.build(map, self);
    }

    public UpdateInstanceOrderInfoRequest setFailReason(String failReason) {
        this.failReason = failReason;
        return this;
    }
    public String getFailReason() {
        return this.failReason;
    }

    public UpdateInstanceOrderInfoRequest setOrderNo(String orderNo) {
        this.orderNo = orderNo;
        return this;
    }
    public String getOrderNo() {
        return this.orderNo;
    }

    public UpdateInstanceOrderInfoRequest setOutOrderNo(String outOrderNo) {
        this.outOrderNo = outOrderNo;
        return this;
    }
    public String getOutOrderNo() {
        return this.outOrderNo;
    }

    public UpdateInstanceOrderInfoRequest setPayerBank(UpdateInstanceOrderInfoRequestPayerBank payerBank) {
        this.payerBank = payerBank;
        return this;
    }
    public UpdateInstanceOrderInfoRequestPayerBank getPayerBank() {
        return this.payerBank;
    }

    public UpdateInstanceOrderInfoRequest setPaymentTime(Long paymentTime) {
        this.paymentTime = paymentTime;
        return this;
    }
    public Long getPaymentTime() {
        return this.paymentTime;
    }

    public UpdateInstanceOrderInfoRequest setStatus(String status) {
        this.status = status;
        return this;
    }
    public String getStatus() {
        return this.status;
    }

    public UpdateInstanceOrderInfoRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

    public static class UpdateInstanceOrderInfoRequestPayerBank extends TeaModel {
        @NameInMap("cardNo")
        public String cardNo;

        @NameInMap("name")
        public String name;

        public static UpdateInstanceOrderInfoRequestPayerBank build(java.util.Map<String, ?> map) throws Exception {
            UpdateInstanceOrderInfoRequestPayerBank self = new UpdateInstanceOrderInfoRequestPayerBank();
            return TeaModel.build(map, self);
        }

        public UpdateInstanceOrderInfoRequestPayerBank setCardNo(String cardNo) {
            this.cardNo = cardNo;
            return this;
        }
        public String getCardNo() {
            return this.cardNo;
        }

        public UpdateInstanceOrderInfoRequestPayerBank setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

    }

}
