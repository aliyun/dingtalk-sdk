// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class QueryOrderResponseBody extends TeaModel {
    @NameInMap("actualAmount")
    public Long actualAmount;

    /**
     * <strong>example:</strong>
     * <p>123400</p>
     */
    @NameInMap("alipayAppId")
    public String alipayAppId;

    /**
     * <strong>example:</strong>
     * <p>2022-11-04T17:15Z</p>
     */
    @NameInMap("closeTime")
    public String closeTime;

    /**
     * <strong>example:</strong>
     * <p>1672973971107</p>
     */
    @NameInMap("closeTimestamp")
    public Long closeTimestamp;

    /**
     * <strong>example:</strong>
     * <p>2022-11-04T17:15Z</p>
     */
    @NameInMap("createTime")
    public String createTime;

    /**
     * <strong>example:</strong>
     * <p>1672973971107</p>
     */
    @NameInMap("createTimestamp")
    public Long createTimestamp;

    @NameInMap("labelAmount")
    public Long labelAmount;

    /**
     * <strong>example:</strong>
     * <p>10000</p>
     */
    @NameInMap("merchantId")
    public String merchantId;

    /**
     * <strong>example:</strong>
     * <p>M20000100</p>
     */
    @NameInMap("merchantMergeOrderNo")
    public String merchantMergeOrderNo;

    /**
     * <strong>example:</strong>
     * <p>M20000100</p>
     */
    @NameInMap("merchantOrderNo")
    public String merchantOrderNo;

    /**
     * <strong>example:</strong>
     * <p>CM0001</p>
     */
    @NameInMap("orderNo")
    public String orderNo;

    /**
     * <strong>example:</strong>
     * <p>1</p>
     */
    @NameInMap("orderType")
    public String orderType;

    /**
     * <strong>example:</strong>
     * <p>fagweefdsdgfa</p>
     */
    @NameInMap("outerUserId")
    public String outerUserId;

    /**
     * <strong>example:</strong>
     * <p>138***</p>
     */
    @NameInMap("payLogonId")
    public String payLogonId;

    @NameInMap("payStatus")
    public Integer payStatus;

    /**
     * <strong>example:</strong>
     * <p>2022-11-04T17:15Z</p>
     */
    @NameInMap("payTime")
    public String payTime;

    /**
     * <strong>example:</strong>
     * <p>1672973971107</p>
     */
    @NameInMap("payTimestamp")
    public Long payTimestamp;

    /**
     * <strong>example:</strong>
     * <p>1</p>
     */
    @NameInMap("payType")
    public String payType;

    @NameInMap("refundAmount")
    public Long refundAmount;

    @NameInMap("refundStatus")
    public Integer refundStatus;

    /**
     * <strong>example:</strong>
     * <p>2022-11-04T17:15Z</p>
     */
    @NameInMap("refundTime")
    public String refundTime;

    /**
     * <strong>example:</strong>
     * <p>1672973971107</p>
     */
    @NameInMap("refundTimestamp")
    public Long refundTimestamp;

    /**
     * <strong>example:</strong>
     * <p>教育产品</p>
     */
    @NameInMap("subject")
    public String subject;

    /**
     * <strong>example:</strong>
     * <p>2022080311111</p>
     */
    @NameInMap("tradeNo")
    public String tradeNo;

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

    public QueryOrderResponseBody setAlipayAppId(String alipayAppId) {
        this.alipayAppId = alipayAppId;
        return this;
    }
    public String getAlipayAppId() {
        return this.alipayAppId;
    }

    public QueryOrderResponseBody setCloseTime(String closeTime) {
        this.closeTime = closeTime;
        return this;
    }
    public String getCloseTime() {
        return this.closeTime;
    }

    public QueryOrderResponseBody setCloseTimestamp(Long closeTimestamp) {
        this.closeTimestamp = closeTimestamp;
        return this;
    }
    public Long getCloseTimestamp() {
        return this.closeTimestamp;
    }

    public QueryOrderResponseBody setCreateTime(String createTime) {
        this.createTime = createTime;
        return this;
    }
    public String getCreateTime() {
        return this.createTime;
    }

    public QueryOrderResponseBody setCreateTimestamp(Long createTimestamp) {
        this.createTimestamp = createTimestamp;
        return this;
    }
    public Long getCreateTimestamp() {
        return this.createTimestamp;
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

    public QueryOrderResponseBody setOuterUserId(String outerUserId) {
        this.outerUserId = outerUserId;
        return this;
    }
    public String getOuterUserId() {
        return this.outerUserId;
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

    public QueryOrderResponseBody setPayTime(String payTime) {
        this.payTime = payTime;
        return this;
    }
    public String getPayTime() {
        return this.payTime;
    }

    public QueryOrderResponseBody setPayTimestamp(Long payTimestamp) {
        this.payTimestamp = payTimestamp;
        return this;
    }
    public Long getPayTimestamp() {
        return this.payTimestamp;
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

    public QueryOrderResponseBody setRefundTime(String refundTime) {
        this.refundTime = refundTime;
        return this;
    }
    public String getRefundTime() {
        return this.refundTime;
    }

    public QueryOrderResponseBody setRefundTimestamp(Long refundTimestamp) {
        this.refundTimestamp = refundTimestamp;
        return this;
    }
    public Long getRefundTimestamp() {
        return this.refundTimestamp;
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

}
