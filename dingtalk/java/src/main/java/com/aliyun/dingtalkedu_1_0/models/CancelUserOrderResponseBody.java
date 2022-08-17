// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class CancelUserOrderResponseBody extends TeaModel {
    // 应用id。
    @NameInMap("appId")
    public String appId;

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

    public static CancelUserOrderResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CancelUserOrderResponseBody self = new CancelUserOrderResponseBody();
        return TeaModel.build(map, self);
    }

    public CancelUserOrderResponseBody setAppId(String appId) {
        this.appId = appId;
        return this;
    }
    public String getAppId() {
        return this.appId;
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
