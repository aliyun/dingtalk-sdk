// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkapp_market_1_0.models;

import com.aliyun.tea.*;

public class QueryMarketOrderResponseBody extends TeaModel {
    // 订单ID
    @NameInMap("bizOrderId")
    public Long bizOrderId;

    // 组织ID
    @NameInMap("corpId")
    public String corpId;

    // 规格编码
    @NameInMap("itemCode")
    public String itemCode;

    // 规格名称
    @NameInMap("itemName")
    public String itemName;

    // 商品Code
    @NameInMap("goodsCode")
    public String goodsCode;

    // 商品名称
    @NameInMap("goodsName")
    public String goodsName;

    // 订单实付金额(单位分)
    @NameInMap("totalActualPayFee")
    public Long totalActualPayFee;

    // 订单状态(0:订单关闭； 3：订单支付；4：订单创建)
    @NameInMap("status")
    public Long status;

    // 购买数量
    @NameInMap("quantity")
    public Long quantity;

    // 支付时间戳
    @NameInMap("paidTimestamp")
    public Long paidTimestamp;

    // 创建时间戳
    @NameInMap("createTimestamp")
    public Long createTimestamp;

    // 开始生效时间
    @NameInMap("startTimestamp")
    public Long startTimestamp;

    // 生效结束时间
    @NameInMap("endTimestamp")
    public Long endTimestamp;

    // 是否内购订单
    @NameInMap("inAppOrder")
    public Boolean inAppOrder;

    public static QueryMarketOrderResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryMarketOrderResponseBody self = new QueryMarketOrderResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryMarketOrderResponseBody setBizOrderId(Long bizOrderId) {
        this.bizOrderId = bizOrderId;
        return this;
    }
    public Long getBizOrderId() {
        return this.bizOrderId;
    }

    public QueryMarketOrderResponseBody setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public QueryMarketOrderResponseBody setItemCode(String itemCode) {
        this.itemCode = itemCode;
        return this;
    }
    public String getItemCode() {
        return this.itemCode;
    }

    public QueryMarketOrderResponseBody setItemName(String itemName) {
        this.itemName = itemName;
        return this;
    }
    public String getItemName() {
        return this.itemName;
    }

    public QueryMarketOrderResponseBody setGoodsCode(String goodsCode) {
        this.goodsCode = goodsCode;
        return this;
    }
    public String getGoodsCode() {
        return this.goodsCode;
    }

    public QueryMarketOrderResponseBody setGoodsName(String goodsName) {
        this.goodsName = goodsName;
        return this;
    }
    public String getGoodsName() {
        return this.goodsName;
    }

    public QueryMarketOrderResponseBody setTotalActualPayFee(Long totalActualPayFee) {
        this.totalActualPayFee = totalActualPayFee;
        return this;
    }
    public Long getTotalActualPayFee() {
        return this.totalActualPayFee;
    }

    public QueryMarketOrderResponseBody setStatus(Long status) {
        this.status = status;
        return this;
    }
    public Long getStatus() {
        return this.status;
    }

    public QueryMarketOrderResponseBody setQuantity(Long quantity) {
        this.quantity = quantity;
        return this;
    }
    public Long getQuantity() {
        return this.quantity;
    }

    public QueryMarketOrderResponseBody setPaidTimestamp(Long paidTimestamp) {
        this.paidTimestamp = paidTimestamp;
        return this;
    }
    public Long getPaidTimestamp() {
        return this.paidTimestamp;
    }

    public QueryMarketOrderResponseBody setCreateTimestamp(Long createTimestamp) {
        this.createTimestamp = createTimestamp;
        return this;
    }
    public Long getCreateTimestamp() {
        return this.createTimestamp;
    }

    public QueryMarketOrderResponseBody setStartTimestamp(Long startTimestamp) {
        this.startTimestamp = startTimestamp;
        return this;
    }
    public Long getStartTimestamp() {
        return this.startTimestamp;
    }

    public QueryMarketOrderResponseBody setEndTimestamp(Long endTimestamp) {
        this.endTimestamp = endTimestamp;
        return this;
    }
    public Long getEndTimestamp() {
        return this.endTimestamp;
    }

    public QueryMarketOrderResponseBody setInAppOrder(Boolean inAppOrder) {
        this.inAppOrder = inAppOrder;
        return this;
    }
    public Boolean getInAppOrder() {
        return this.inAppOrder;
    }

}
