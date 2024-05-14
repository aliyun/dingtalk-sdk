// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkapp_market_1_0.models;

import com.aliyun.tea.*;

public class QueryMarketOrderResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("bizOrderId")
    public Long bizOrderId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("corpId")
    public String corpId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("createTimestamp")
    public Long createTimestamp;

    @NameInMap("endTimestamp")
    public Long endTimestamp;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("goodsCode")
    public String goodsCode;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("goodsName")
    public String goodsName;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("inAppOrder")
    public Boolean inAppOrder;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("itemCode")
    public String itemCode;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("itemName")
    public String itemName;

    @NameInMap("paidTimestamp")
    public Long paidTimestamp;

    @NameInMap("quantity")
    public Long quantity;

    @NameInMap("startTimestamp")
    public Long startTimestamp;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("status")
    public Long status;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("totalActualPayFee")
    public Long totalActualPayFee;

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

    public QueryMarketOrderResponseBody setCreateTimestamp(Long createTimestamp) {
        this.createTimestamp = createTimestamp;
        return this;
    }
    public Long getCreateTimestamp() {
        return this.createTimestamp;
    }

    public QueryMarketOrderResponseBody setEndTimestamp(Long endTimestamp) {
        this.endTimestamp = endTimestamp;
        return this;
    }
    public Long getEndTimestamp() {
        return this.endTimestamp;
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

    public QueryMarketOrderResponseBody setInAppOrder(Boolean inAppOrder) {
        this.inAppOrder = inAppOrder;
        return this;
    }
    public Boolean getInAppOrder() {
        return this.inAppOrder;
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

    public QueryMarketOrderResponseBody setPaidTimestamp(Long paidTimestamp) {
        this.paidTimestamp = paidTimestamp;
        return this;
    }
    public Long getPaidTimestamp() {
        return this.paidTimestamp;
    }

    public QueryMarketOrderResponseBody setQuantity(Long quantity) {
        this.quantity = quantity;
        return this;
    }
    public Long getQuantity() {
        return this.quantity;
    }

    public QueryMarketOrderResponseBody setStartTimestamp(Long startTimestamp) {
        this.startTimestamp = startTimestamp;
        return this;
    }
    public Long getStartTimestamp() {
        return this.startTimestamp;
    }

    public QueryMarketOrderResponseBody setStatus(Long status) {
        this.status = status;
        return this;
    }
    public Long getStatus() {
        return this.status;
    }

    public QueryMarketOrderResponseBody setTotalActualPayFee(Long totalActualPayFee) {
        this.totalActualPayFee = totalActualPayFee;
        return this;
    }
    public Long getTotalActualPayFee() {
        return this.totalActualPayFee;
    }

}
