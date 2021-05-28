// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktrade_1_0.models;

import com.aliyun.tea.*;

public class QueryTradeOrderResponseBody extends TeaModel {
    // ISV的组织ID
    @NameInMap("isvCropId")
    public String isvCropId;

    // 商品名称
    @NameInMap("articleName")
    public String articleName;

    // 商品编码
    @NameInMap("articleCode")
    public String articleCode;

    // 规格名称
    @NameInMap("articleItemName")
    public String articleItemName;

    // 规格编码
    @NameInMap("articleItemCode")
    public String articleItemCode;

    // 商品数量
    @NameInMap("quantity")
    public Long quantity;

    // 外部订单号
    @NameInMap("outerOrderId")
    public String outerOrderId;

    // 内部订单号
    @NameInMap("orderId")
    public Long orderId;

    // 原价（单位：分）
    @NameInMap("fee")
    public Long fee;

    // 实际支付的价格（单位：分）
    @NameInMap("payFee")
    public Long payFee;

    // 订单创建时间（单位：ms）
    @NameInMap("createTime")
    public Long createTime;

    // 订单退款时间（单位：ms）
    @NameInMap("refundTime")
    public Long refundTime;

    // 订单关闭时间（单位：ms）
    @NameInMap("closeTime")
    public Long closeTime;

    // 订单支付时间（单位：ms）
    @NameInMap("payTime")
    public Long payTime;

    // 订单状态：-1表示已关闭、0表示未支付、1表示已支付、2表示已退款
    @NameInMap("status")
    public Integer status;

    public static QueryTradeOrderResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryTradeOrderResponseBody self = new QueryTradeOrderResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryTradeOrderResponseBody setIsvCropId(String isvCropId) {
        this.isvCropId = isvCropId;
        return this;
    }
    public String getIsvCropId() {
        return this.isvCropId;
    }

    public QueryTradeOrderResponseBody setArticleName(String articleName) {
        this.articleName = articleName;
        return this;
    }
    public String getArticleName() {
        return this.articleName;
    }

    public QueryTradeOrderResponseBody setArticleCode(String articleCode) {
        this.articleCode = articleCode;
        return this;
    }
    public String getArticleCode() {
        return this.articleCode;
    }

    public QueryTradeOrderResponseBody setArticleItemName(String articleItemName) {
        this.articleItemName = articleItemName;
        return this;
    }
    public String getArticleItemName() {
        return this.articleItemName;
    }

    public QueryTradeOrderResponseBody setArticleItemCode(String articleItemCode) {
        this.articleItemCode = articleItemCode;
        return this;
    }
    public String getArticleItemCode() {
        return this.articleItemCode;
    }

    public QueryTradeOrderResponseBody setQuantity(Long quantity) {
        this.quantity = quantity;
        return this;
    }
    public Long getQuantity() {
        return this.quantity;
    }

    public QueryTradeOrderResponseBody setOuterOrderId(String outerOrderId) {
        this.outerOrderId = outerOrderId;
        return this;
    }
    public String getOuterOrderId() {
        return this.outerOrderId;
    }

    public QueryTradeOrderResponseBody setOrderId(Long orderId) {
        this.orderId = orderId;
        return this;
    }
    public Long getOrderId() {
        return this.orderId;
    }

    public QueryTradeOrderResponseBody setFee(Long fee) {
        this.fee = fee;
        return this;
    }
    public Long getFee() {
        return this.fee;
    }

    public QueryTradeOrderResponseBody setPayFee(Long payFee) {
        this.payFee = payFee;
        return this;
    }
    public Long getPayFee() {
        return this.payFee;
    }

    public QueryTradeOrderResponseBody setCreateTime(Long createTime) {
        this.createTime = createTime;
        return this;
    }
    public Long getCreateTime() {
        return this.createTime;
    }

    public QueryTradeOrderResponseBody setRefundTime(Long refundTime) {
        this.refundTime = refundTime;
        return this;
    }
    public Long getRefundTime() {
        return this.refundTime;
    }

    public QueryTradeOrderResponseBody setCloseTime(Long closeTime) {
        this.closeTime = closeTime;
        return this;
    }
    public Long getCloseTime() {
        return this.closeTime;
    }

    public QueryTradeOrderResponseBody setPayTime(Long payTime) {
        this.payTime = payTime;
        return this;
    }
    public Long getPayTime() {
        return this.payTime;
    }

    public QueryTradeOrderResponseBody setStatus(Integer status) {
        this.status = status;
        return this;
    }
    public Integer getStatus() {
        return this.status;
    }

}
