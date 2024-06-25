// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_2_0.models;

import com.aliyun.tea.*;

public class UpdateInstanceOrderInfoRequest extends TeaModel {
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
    public UpdateInstanceOrderInfoRequestPayerBank payerBank;

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
        /**
         * <strong>example:</strong>
         * <p>64112222</p>
         */
        @NameInMap("cardNo")
        public String cardNo;

        /**
         * <strong>example:</strong>
         * <p>招商银行</p>
         */
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
