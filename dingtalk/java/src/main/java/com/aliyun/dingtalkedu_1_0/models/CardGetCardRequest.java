// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class CardGetCardRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>80264668258</p>
     */
    @NameInMap("cardId")
    public Long cardId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>YUFANAI</p>
     */
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
