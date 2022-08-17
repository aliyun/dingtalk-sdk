// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class QueryOrderResponseBody extends TeaModel {
    @NameInMap("actualAmount")
    public Long actualAmount;

    // 应用id。
    @NameInMap("appId")
    public String appId;

    // 订单关单时间。
    @NameInMap("closeTime")
    public Long closeTime;

    // 订单创建时间。
    @NameInMap("createTime")
    public Long createTime;

    // 扩展字段。
    @NameInMap("feature")
    public String feature;

    @NameInMap("labelAmount")
    public Long labelAmount;

    // 商户id。
    @NameInMap("merchantId")
    public String merchantId;

    // 商户聚合支付订单号。
    @NameInMap("merchantMergeOrderNo")
    public String merchantMergeOrderNo;

    // 商户订单号。
    @NameInMap("merchantOrderNo")
    public String merchantOrderNo;

    // 订单号。
    @NameInMap("orderNo")
    public String orderNo;

    // 订单类型。
    @NameInMap("orderType")
    public String orderType;

    // 买家支付id。
    @NameInMap("payId")
    public String payId;

    // 买家支付登陆id。
    @NameInMap("payLogonId")
    public String payLogonId;

    @NameInMap("payStatus")
    public Integer payStatus;

    // 订单支付时间。
    @NameInMap("payTime")
    public Long payTime;

    // 买家支付渠道类型。
    @NameInMap("payType")
    public String payType;

    @NameInMap("refundAmount")
    public Long refundAmount;

    @NameInMap("refundStatus")
    public Integer refundStatus;

    // 订单退款时间。
    @NameInMap("refundTime")
    public Long refundTime;

    // 订单标题。
    @NameInMap("subject")
    public String subject;

    // 交易流水号。
    @NameInMap("tradeNo")
    public String tradeNo;

    // 用户唯一id。
    @NameInMap("userId")
    public String userId;

    public static QueryOrderResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryOrderResponseBody self = new QueryOrderResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryOrderResponseBody setActualAmount(Long actualAmount) {
        this.actualAmount = actualAmount;
        return this;
    }
    public Long getActualAmount() {
        return this.actualAmount;
    }

    public QueryOrderResponseBody setAppId(String appId) {
        this.appId = appId;
        return this;
    }
    public String getAppId() {
        return this.appId;
    }

    public QueryOrderResponseBody setCloseTime(Long closeTime) {
        this.closeTime = closeTime;
        return this;
    }
    public Long getCloseTime() {
        return this.closeTime;
    }

    public QueryOrderResponseBody setCreateTime(Long createTime) {
        this.createTime = createTime;
        return this;
    }
    public Long getCreateTime() {
        return this.createTime;
    }

    public QueryOrderResponseBody setFeature(String feature) {
        this.feature = feature;
        return this;
    }
    public String getFeature() {
        return this.feature;
    }

    public QueryOrderResponseBody setLabelAmount(Long labelAmount) {
        this.labelAmount = labelAmount;
        return this;
    }
    public Long getLabelAmount() {
        return this.labelAmount;
    }

    public QueryOrderResponseBody setMerchantId(String merchantId) {
        this.merchantId = merchantId;
        return this;
    }
    public String getMerchantId() {
        return this.merchantId;
    }

    public QueryOrderResponseBody setMerchantMergeOrderNo(String merchantMergeOrderNo) {
        this.merchantMergeOrderNo = merchantMergeOrderNo;
        return this;
    }
    public String getMerchantMergeOrderNo() {
        return this.merchantMergeOrderNo;
    }

    public QueryOrderResponseBody setMerchantOrderNo(String merchantOrderNo) {
        this.merchantOrderNo = merchantOrderNo;
        return this;
    }
    public String getMerchantOrderNo() {
        return this.merchantOrderNo;
    }

    public QueryOrderResponseBody setOrderNo(String orderNo) {
        this.orderNo = orderNo;
        return this;
    }
    public String getOrderNo() {
        return this.orderNo;
    }

    public QueryOrderResponseBody setOrderType(String orderType) {
        this.orderType = orderType;
        return this;
    }
    public String getOrderType() {
        return this.orderType;
    }

    public QueryOrderResponseBody setPayId(String payId) {
        this.payId = payId;
        return this;
    }
    public String getPayId() {
        return this.payId;
    }

    public QueryOrderResponseBody setPayLogonId(String payLogonId) {
        this.payLogonId = payLogonId;
        return this;
    }
    public String getPayLogonId() {
        return this.payLogonId;
    }

    public QueryOrderResponseBody setPayStatus(Integer payStatus) {
        this.payStatus = payStatus;
        return this;
    }
    public Integer getPayStatus() {
        return this.payStatus;
    }

    public QueryOrderResponseBody setPayTime(Long payTime) {
        this.payTime = payTime;
        return this;
    }
    public Long getPayTime() {
        return this.payTime;
    }

    public QueryOrderResponseBody setPayType(String payType) {
        this.payType = payType;
        return this;
    }
    public String getPayType() {
        return this.payType;
    }

    public QueryOrderResponseBody setRefundAmount(Long refundAmount) {
        this.refundAmount = refundAmount;
        return this;
    }
    public Long getRefundAmount() {
        return this.refundAmount;
    }

    public QueryOrderResponseBody setRefundStatus(Integer refundStatus) {
        this.refundStatus = refundStatus;
        return this;
    }
    public Integer getRefundStatus() {
        return this.refundStatus;
    }

    public QueryOrderResponseBody setRefundTime(Long refundTime) {
        this.refundTime = refundTime;
        return this;
    }
    public Long getRefundTime() {
        return this.refundTime;
    }

    public QueryOrderResponseBody setSubject(String subject) {
        this.subject = subject;
        return this;
    }
    public String getSubject() {
        return this.subject;
    }

    public QueryOrderResponseBody setTradeNo(String tradeNo) {
        this.tradeNo = tradeNo;
        return this;
    }
    public String getTradeNo() {
        return this.tradeNo;
    }

    public QueryOrderResponseBody setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
