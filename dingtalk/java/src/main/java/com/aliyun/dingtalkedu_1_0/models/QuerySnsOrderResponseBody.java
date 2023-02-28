// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class QuerySnsOrderResponseBody extends TeaModel {
    @NameInMap("actualAmount")
    public Long actualAmount;

    /**
     * <p>支付宝应用id。</p>
     */
    @NameInMap("alipayAppId")
    public String alipayAppId;

    /**
     * <p>订单关闭时间</p>
     */
    @NameInMap("closeTime")
    public String closeTime;

    /**
     * <p>订单关闭时间戳</p>
     */
    @NameInMap("closeTimestamp")
    public Long closeTimestamp;

    /**
     * <p>订单创建时间</p>
     */
    @NameInMap("createTime")
    public String createTime;

    /**
     * <p>订单创建时间戳</p>
     */
    @NameInMap("createTimestamp")
    public Long createTimestamp;

    @NameInMap("labelAmount")
    public Long labelAmount;

    /**
     * <p>商户id。</p>
     */
    @NameInMap("merchantId")
    public String merchantId;

    /**
     * <p>商户聚合支付订单号。</p>
     */
    @NameInMap("merchantMergeOrderNo")
    public String merchantMergeOrderNo;

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

    /**
     * <p>订单类型。</p>
     */
    @NameInMap("orderType")
    public String orderType;

    /**
     * <p>用户唯一id。</p>
     */
    @NameInMap("outerUserId")
    public String outerUserId;

    /**
     * <p>买家支付id。</p>
     */
    @NameInMap("payId")
    public String payId;

    /**
     * <p>买家支付登陆id。</p>
     */
    @NameInMap("payLogonId")
    public String payLogonId;

    @NameInMap("payStatus")
    public Integer payStatus;

    /**
     * <p>订单支付时间</p>
     */
    @NameInMap("payTime")
    public String payTime;

    /**
     * <p>订单支付时间戳</p>
     */
    @NameInMap("payTimestamp")
    public Long payTimestamp;

    /**
     * <p>买家支付渠道类型。</p>
     */
    @NameInMap("payType")
    public String payType;

    @NameInMap("refundAmount")
    public Long refundAmount;

    @NameInMap("refundStatus")
    public Integer refundStatus;

    /**
     * <p>订单退款时间</p>
     */
    @NameInMap("refundTime")
    public String refundTime;

    /**
     * <p>订单退款时间戳</p>
     */
    @NameInMap("refundTimestamp")
    public Long refundTimestamp;

    /**
     * <p>订单标题。</p>
     */
    @NameInMap("subject")
    public String subject;

    /**
     * <p>交易流水号。</p>
     */
    @NameInMap("tradeNo")
    public String tradeNo;

    public static QuerySnsOrderResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QuerySnsOrderResponseBody self = new QuerySnsOrderResponseBody();
        return TeaModel.build(map, self);
    }

    public QuerySnsOrderResponseBody setActualAmount(Long actualAmount) {
        this.actualAmount = actualAmount;
        return this;
    }
    public Long getActualAmount() {
        return this.actualAmount;
    }

    public QuerySnsOrderResponseBody setAlipayAppId(String alipayAppId) {
        this.alipayAppId = alipayAppId;
        return this;
    }
    public String getAlipayAppId() {
        return this.alipayAppId;
    }

    public QuerySnsOrderResponseBody setCloseTime(String closeTime) {
        this.closeTime = closeTime;
        return this;
    }
    public String getCloseTime() {
        return this.closeTime;
    }

    public QuerySnsOrderResponseBody setCloseTimestamp(Long closeTimestamp) {
        this.closeTimestamp = closeTimestamp;
        return this;
    }
    public Long getCloseTimestamp() {
        return this.closeTimestamp;
    }

    public QuerySnsOrderResponseBody setCreateTime(String createTime) {
        this.createTime = createTime;
        return this;
    }
    public String getCreateTime() {
        return this.createTime;
    }

    public QuerySnsOrderResponseBody setCreateTimestamp(Long createTimestamp) {
        this.createTimestamp = createTimestamp;
        return this;
    }
    public Long getCreateTimestamp() {
        return this.createTimestamp;
    }

    public QuerySnsOrderResponseBody setLabelAmount(Long labelAmount) {
        this.labelAmount = labelAmount;
        return this;
    }
    public Long getLabelAmount() {
        return this.labelAmount;
    }

    public QuerySnsOrderResponseBody setMerchantId(String merchantId) {
        this.merchantId = merchantId;
        return this;
    }
    public String getMerchantId() {
        return this.merchantId;
    }

    public QuerySnsOrderResponseBody setMerchantMergeOrderNo(String merchantMergeOrderNo) {
        this.merchantMergeOrderNo = merchantMergeOrderNo;
        return this;
    }
    public String getMerchantMergeOrderNo() {
        return this.merchantMergeOrderNo;
    }

    public QuerySnsOrderResponseBody setMerchantOrderNo(String merchantOrderNo) {
        this.merchantOrderNo = merchantOrderNo;
        return this;
    }
    public String getMerchantOrderNo() {
        return this.merchantOrderNo;
    }

    public QuerySnsOrderResponseBody setOrderNo(String orderNo) {
        this.orderNo = orderNo;
        return this;
    }
    public String getOrderNo() {
        return this.orderNo;
    }

    public QuerySnsOrderResponseBody setOrderType(String orderType) {
        this.orderType = orderType;
        return this;
    }
    public String getOrderType() {
        return this.orderType;
    }

    public QuerySnsOrderResponseBody setOuterUserId(String outerUserId) {
        this.outerUserId = outerUserId;
        return this;
    }
    public String getOuterUserId() {
        return this.outerUserId;
    }

    public QuerySnsOrderResponseBody setPayId(String payId) {
        this.payId = payId;
        return this;
    }
    public String getPayId() {
        return this.payId;
    }

    public QuerySnsOrderResponseBody setPayLogonId(String payLogonId) {
        this.payLogonId = payLogonId;
        return this;
    }
    public String getPayLogonId() {
        return this.payLogonId;
    }

    public QuerySnsOrderResponseBody setPayStatus(Integer payStatus) {
        this.payStatus = payStatus;
        return this;
    }
    public Integer getPayStatus() {
        return this.payStatus;
    }

    public QuerySnsOrderResponseBody setPayTime(String payTime) {
        this.payTime = payTime;
        return this;
    }
    public String getPayTime() {
        return this.payTime;
    }

    public QuerySnsOrderResponseBody setPayTimestamp(Long payTimestamp) {
        this.payTimestamp = payTimestamp;
        return this;
    }
    public Long getPayTimestamp() {
        return this.payTimestamp;
    }

    public QuerySnsOrderResponseBody setPayType(String payType) {
        this.payType = payType;
        return this;
    }
    public String getPayType() {
        return this.payType;
    }

    public QuerySnsOrderResponseBody setRefundAmount(Long refundAmount) {
        this.refundAmount = refundAmount;
        return this;
    }
    public Long getRefundAmount() {
        return this.refundAmount;
    }

    public QuerySnsOrderResponseBody setRefundStatus(Integer refundStatus) {
        this.refundStatus = refundStatus;
        return this;
    }
    public Integer getRefundStatus() {
        return this.refundStatus;
    }

    public QuerySnsOrderResponseBody setRefundTime(String refundTime) {
        this.refundTime = refundTime;
        return this;
    }
    public String getRefundTime() {
        return this.refundTime;
    }

    public QuerySnsOrderResponseBody setRefundTimestamp(Long refundTimestamp) {
        this.refundTimestamp = refundTimestamp;
        return this;
    }
    public Long getRefundTimestamp() {
        return this.refundTimestamp;
    }

    public QuerySnsOrderResponseBody setSubject(String subject) {
        this.subject = subject;
        return this;
    }
    public String getSubject() {
        return this.subject;
    }

    public QuerySnsOrderResponseBody setTradeNo(String tradeNo) {
        this.tradeNo = tradeNo;
        return this;
    }
    public String getTradeNo() {
        return this.tradeNo;
    }

}
