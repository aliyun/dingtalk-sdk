// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class CardEndCardRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>industry_center</p>
     */
    @NameInMap("cardBizCode")
    public String cardBizCode;

    /**
     * <strong>example:</strong>
     * <p>856237470</p>
     */
    @NameInMap("cardBizId")
    public String cardBizId;

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

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>manager7741</p>
     */
    @NameInMap("userId")
    public String userId;

    public static CardEndCardRequest build(java.util.Map<String, ?> map) throws Exception {
        CardEndCardRequest self = new CardEndCardRequest();
        return TeaModel.build(map, self);
    }

    public CardEndCardRequest setCardBizCode(String cardBizCode) {
        this.cardBizCode = cardBizCode;
        return this;
    }
    public String getCardBizCode() {
        return this.cardBizCode;
    }

    public CardEndCardRequest setCardBizId(String cardBizId) {
        this.cardBizId = cardBizId;
        return this;
    }
    public String getCardBizId() {
        return this.cardBizId;
    }

    public CardEndCardRequest setCardId(Long cardId) {
        this.cardId = cardId;
        return this;
    }
    public Long getCardId() {
        return this.cardId;
    }

    public CardEndCardRequest setSourceType(String sourceType) {
        this.sourceType = sourceType;
        return this;
    }
    public String getSourceType() {
        return this.sourceType;
    }

    public CardEndCardRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
