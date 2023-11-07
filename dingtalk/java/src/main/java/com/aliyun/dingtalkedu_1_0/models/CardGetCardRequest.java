// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class CardGetCardRequest extends TeaModel {
    @NameInMap("cardId")
    public Long cardId;

    @NameInMap("sourceType")
    public String sourceType;

    public static CardGetCardRequest build(java.util.Map<String, ?> map) throws Exception {
        CardGetCardRequest self = new CardGetCardRequest();
        return TeaModel.build(map, self);
    }

    public CardGetCardRequest setCardId(Long cardId) {
        this.cardId = cardId;
        return this;
    }
    public Long getCardId() {
        return this.cardId;
    }

    public CardGetCardRequest setSourceType(String sourceType) {
        this.sourceType = sourceType;
        return this;
    }
    public String getSourceType() {
        return this.sourceType;
    }

}
