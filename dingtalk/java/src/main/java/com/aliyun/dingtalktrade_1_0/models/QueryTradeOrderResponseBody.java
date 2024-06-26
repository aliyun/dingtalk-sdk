// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktrade_1_0.models;

import com.aliyun.tea.*;

public class QueryTradeOrderResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("articleCode")
    public String articleCode;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("articleItemCode")
    public String articleItemCode;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("articleItemName")
    public String articleItemName;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("articleName")
    public String articleName;

    @NameInMap("closeTime")
    public Long closeTime;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("createTime")
    public Long createTime;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("fee")
    public Long fee;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("isvCropId")
    public String isvCropId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("orderId")
    public Long orderId;

    @NameInMap("outerOrderId")
    public String outerOrderId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("payFee")
    public Long payFee;

    @NameInMap("payTime")
    public Long payTime;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("quantity")
    public Long quantity;

    @NameInMap("refundTime")
    public Long refundTime;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("status")
    public Integer status;

    public static QueryTradeOrderResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryTradeOrderResponseBody self = new QueryTradeOrderResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryTradeOrderResponseBody setArticleCode(String articleCode) {
        this.articleCode = articleCode;
        return this;
    }
    public String getArticleCode() {
        return this.articleCode;
    }

    public QueryTradeOrderResponseBody setArticleItemCode(String articleItemCode) {
        this.articleItemCode = articleItemCode;
        return this;
    }
    public String getArticleItemCode() {
        return this.articleItemCode;
    }

    public QueryTradeOrderResponseBody setArticleItemName(String articleItemName) {
        this.articleItemName = articleItemName;
        return this;
    }
    public String getArticleItemName() {
        return this.articleItemName;
    }

    public QueryTradeOrderResponseBody setArticleName(String articleName) {
        this.articleName = articleName;
        return this;
    }
    public String getArticleName() {
        return this.articleName;
    }

    public QueryTradeOrderResponseBody setCloseTime(Long closeTime) {
        this.closeTime = closeTime;
        return this;
    }
    public Long getCloseTime() {
        return this.closeTime;
    }

    public QueryTradeOrderResponseBody setCreateTime(Long createTime) {
        this.createTime = createTime;
        return this;
    }
    public Long getCreateTime() {
        return this.createTime;
    }

    public QueryTradeOrderResponseBody setFee(Long fee) {
        this.fee = fee;
        return this;
    }
    public Long getFee() {
        return this.fee;
    }

    public QueryTradeOrderResponseBody setIsvCropId(String isvCropId) {
        this.isvCropId = isvCropId;
        return this;
    }
    public String getIsvCropId() {
        return this.isvCropId;
    }

    public QueryTradeOrderResponseBody setOrderId(Long orderId) {
        this.orderId = orderId;
        return this;
    }
    public Long getOrderId() {
        return this.orderId;
    }

    public QueryTradeOrderResponseBody setOuterOrderId(String outerOrderId) {
        this.outerOrderId = outerOrderId;
        return this;
    }
    public String getOuterOrderId() {
        return this.outerOrderId;
    }

    public QueryTradeOrderResponseBody setPayFee(Long payFee) {
        this.payFee = payFee;
        return this;
    }
    public Long getPayFee() {
        return this.payFee;
    }

    public QueryTradeOrderResponseBody setPayTime(Long payTime) {
        this.payTime = payTime;
        return this;
    }
    public Long getPayTime() {
        return this.payTime;
    }

    public QueryTradeOrderResponseBody setQuantity(Long quantity) {
        this.quantity = quantity;
        return this;
    }
    public Long getQuantity() {
        return this.quantity;
    }

    public QueryTradeOrderResponseBody setRefundTime(Long refundTime) {
        this.refundTime = refundTime;
        return this;
    }
    public Long getRefundTime() {
        return this.refundTime;
    }

    public QueryTradeOrderResponseBody setStatus(Integer status) {
        this.status = status;
        return this;
    }
    public Integer getStatus() {
        return this.status;
    }

}
