// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class CardBatchQueryCardsRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>industry_center</p>
     */
    @NameInMap("cardBizCode")
    public String cardBizCode;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("cardIds")
    public java.util.List<Long> cardIds;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>YUFANAI</p>
     */
    @NameInMap("sourceType")
    public String sourceType;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>1678445875001</p>
     */
    @NameInMap("userId")
    public String userId;

    public static CardBatchQueryCardsRequest build(java.util.Map<String, ?> map) throws Exception {
        CardBatchQueryCardsRequest self = new CardBatchQueryCardsRequest();
        return TeaModel.build(map, self);
    }

    public CardBatchQueryCardsRequest setCardBizCode(String cardBizCode) {
        this.cardBizCode = cardBizCode;
        return this;
    }
    public String getCardBizCode() {
        return this.cardBizCode;
    }

    public CardBatchQueryCardsRequest setCardIds(java.util.List<Long> cardIds) {
        this.cardIds = cardIds;
        return this;
    }
    public java.util.List<Long> getCardIds() {
        return this.cardIds;
    }

    public CardBatchQueryCardsRequest setSourceType(String sourceType) {
        this.sourceType = sourceType;
        return this;
    }
    public String getSourceType() {
        return this.sourceType;
    }

    public CardBatchQueryCardsRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
