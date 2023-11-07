// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class CardBatchQueryCardsRequest extends TeaModel {
    @NameInMap("cardBizCode")
    public String cardBizCode;

    @NameInMap("cardIds")
    public java.util.List<Long> cardIds;

    @NameInMap("sourceType")
    public String sourceType;

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
