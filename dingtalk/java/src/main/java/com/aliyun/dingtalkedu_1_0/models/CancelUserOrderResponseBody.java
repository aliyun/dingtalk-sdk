// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class CancelUserOrderResponseBody extends TeaModel {
    /**
     * <p>支付宝应用id。</p>
     */
    @NameInMap("alipayAppId")
    public String alipayAppId;

    /**
     * <p>商户id。</p>
     */
    @NameInMap("merchantId")
    public String merchantId;

    /**
     * <p>商户订单号。</p>
     */
    @NameInMap("merchantOrderNo")
    public String merchantOrderNo;

    /**
     * <p>订单号。</p>
     */
    @NameInMap("orderNo")
    public String orderNo;

    @NameInMap("payStatus")
    public Integer payStatus;

    @NameInMap("refundStatus")
    public Integer refundStatus;

    @NameInMap("totalAmount")
    public Long totalAmount;

    public static CancelUserOrderResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CancelUserOrderResponseBody self = new CancelUserOrderResponseBody();
        return TeaModel.build(map, self);
    }

    public CancelUserOrderResponseBody setAlipayAppId(String alipayAppId) {
        this.alipayAppId = alipayAppId;
        return this;
    }
    public String getAlipayAppId() {
        return this.alipayAppId;
    }

    public CancelUserOrderResponseBody setMerchantId(String merchantId) {
        this.merchantId = merchantId;
        return this;
    }
    public String getMerchantId() {
        return this.merchantId;
    }

    public CancelUserOrderResponseBody setMerchantOrderNo(String merchantOrderNo) {
        this.merchantOrderNo = merchantOrderNo;
        return this;
    }
    public String getMerchantOrderNo() {
        return this.merchantOrderNo;
    }

    public CancelUserOrderResponseBody setOrderNo(String orderNo) {
        this.orderNo = orderNo;
        return this;
    }
    public String getOrderNo() {
        return this.orderNo;
    }

    public CancelUserOrderResponseBody setPayStatus(Integer payStatus) {
        this.payStatus = payStatus;
        return this;
    }
    public Integer getPayStatus() {
        return this.payStatus;
    }

    public CancelUserOrderResponseBody setRefundStatus(Integer refundStatus) {
        this.refundStatus = refundStatus;
        return this;
    }
    public Integer getRefundStatus() {
        return this.refundStatus;
    }

    public CancelUserOrderResponseBody setTotalAmount(Long totalAmount) {
        this.totalAmount = totalAmount;
        return this;
    }
    public Long getTotalAmount() {
        return this.totalAmount;
    }

}
