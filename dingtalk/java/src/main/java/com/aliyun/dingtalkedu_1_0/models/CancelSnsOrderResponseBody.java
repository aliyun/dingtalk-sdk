// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class CancelSnsOrderResponseBody extends TeaModel {
    // 支付宝应用id。
    @NameInMap("alipayAppId")
    public String alipayAppId;

    // 商户id。
    @NameInMap("merchantId")
    public String merchantId;

    // 商户订单号。
    @NameInMap("merchantOrderNo")
    public String merchantOrderNo;

    // 订单号。
    @NameInMap("orderNo")
    public String orderNo;

    @NameInMap("payStatus")
    public Integer payStatus;

    @NameInMap("refundStatus")
    public Integer refundStatus;

    @NameInMap("totalAmount")
    public Long totalAmount;

    public static CancelSnsOrderResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CancelSnsOrderResponseBody self = new CancelSnsOrderResponseBody();
        return TeaModel.build(map, self);
    }

    public CancelSnsOrderResponseBody setAlipayAppId(String alipayAppId) {
        this.alipayAppId = alipayAppId;
        return this;
    }
    public String getAlipayAppId() {
        return this.alipayAppId;
    }

    public CancelSnsOrderResponseBody setMerchantId(String merchantId) {
        this.merchantId = merchantId;
        return this;
    }
    public String getMerchantId() {
        return this.merchantId;
    }

    public CancelSnsOrderResponseBody setMerchantOrderNo(String merchantOrderNo) {
        this.merchantOrderNo = merchantOrderNo;
        return this;
    }
    public String getMerchantOrderNo() {
        return this.merchantOrderNo;
    }

    public CancelSnsOrderResponseBody setOrderNo(String orderNo) {
        this.orderNo = orderNo;
        return this;
    }
    public String getOrderNo() {
        return this.orderNo;
    }

    public CancelSnsOrderResponseBody setPayStatus(Integer payStatus) {
        this.payStatus = payStatus;
        return this;
    }
    public Integer getPayStatus() {
        return this.payStatus;
    }

    public CancelSnsOrderResponseBody setRefundStatus(Integer refundStatus) {
        this.refundStatus = refundStatus;
        return this;
    }
    public Integer getRefundStatus() {
        return this.refundStatus;
    }

    public CancelSnsOrderResponseBody setTotalAmount(Long totalAmount) {
        this.totalAmount = totalAmount;
        return this;
    }
    public Long getTotalAmount() {
        return this.totalAmount;
    }

}
