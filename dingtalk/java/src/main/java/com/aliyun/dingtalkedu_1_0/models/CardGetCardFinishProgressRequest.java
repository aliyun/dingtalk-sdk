// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class CardGetCardFinishProgressRequest extends TeaModel {
    @NameInMap("cardBizCode")
    public String cardBizCode;

    @NameInMap("cardBizId")
    public String cardBizId;

    @NameInMap("cardId")
    public Long cardId;

    @NameInMap("sourceType")
    public String sourceType;

    @NameInMap("studentId")
    public String studentId;

    @NameInMap("userId")
    public String userId;

    public static CardGetCardFinishProgressRequest build(java.util.Map<String, ?> map) throws Exception {
        CardGetCardFinishProgressRequest self = new CardGetCardFinishProgressRequest();
        return TeaModel.build(map, self);
    }

    public CardGetCardFinishProgressRequest setCardBizCode(String cardBizCode) {
        this.cardBizCode = cardBizCode;
        return this;
    }
    public String getCardBizCode() {
        return this.cardBizCode;
    }

    public CardGetCardFinishProgressRequest setCardBizId(String cardBizId) {
        this.cardBizId = cardBizId;
        return this;
    }
    public String getCardBizId() {
        return this.cardBizId;
    }

    public CardGetCardFinishProgressRequest setCardId(Long cardId) {
        this.cardId = cardId;
        return this;
    }
    public Long getCardId() {
        return this.cardId;
    }

    public CardGetCardFinishProgressRequest setSourceType(String sourceType) {
        this.sourceType = sourceType;
        return this;
    }
    public String getSourceType() {
        return this.sourceType;
    }

    public CardGetCardFinishProgressRequest setStudentId(String studentId) {
        this.studentId = studentId;
        return this;
    }
    public String getStudentId() {
        return this.studentId;
    }

    public CardGetCardFinishProgressRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
