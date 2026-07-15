// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class CardUpdateCardRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>industry_centry</p>
     */
    @NameInMap("cardBizCode")
    public String cardBizCode;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("cardId")
    public Long cardId;

    @NameInMap("data")
    public CardUpdateCardRequestData data;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("identifier")
    public String identifier;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("shouldSendUpdateMsg")
    public Boolean shouldSendUpdateMsg;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>QUPEIYIN</p>
     */
    @NameInMap("sourceType")
    public String sourceType;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("userId")
    public String userId;

    public static CardUpdateCardRequest build(java.util.Map<String, ?> map) throws Exception {
        CardUpdateCardRequest self = new CardUpdateCardRequest();
        return TeaModel.build(map, self);
    }

    public CardUpdateCardRequest setCardBizCode(String cardBizCode) {
        this.cardBizCode = cardBizCode;
        return this;
    }
    public String getCardBizCode() {
        return this.cardBizCode;
    }

    public CardUpdateCardRequest setCardId(Long cardId) {
        this.cardId = cardId;
        return this;
    }
    public Long getCardId() {
        return this.cardId;
    }

    public CardUpdateCardRequest setData(CardUpdateCardRequestData data) {
        this.data = data;
        return this;
    }
    public CardUpdateCardRequestData getData() {
        return this.data;
    }

    public CardUpdateCardRequest setIdentifier(String identifier) {
        this.identifier = identifier;
        return this;
    }
    public String getIdentifier() {
        return this.identifier;
    }

    public CardUpdateCardRequest setShouldSendUpdateMsg(Boolean shouldSendUpdateMsg) {
        this.shouldSendUpdateMsg = shouldSendUpdateMsg;
        return this;
    }
    public Boolean getShouldSendUpdateMsg() {
        return this.shouldSendUpdateMsg;
    }

    public CardUpdateCardRequest setSourceType(String sourceType) {
        this.sourceType = sourceType;
        return this;
    }
    public String getSourceType() {
        return this.sourceType;
    }

    public CardUpdateCardRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

    public static class CardUpdateCardRequestData extends TeaModel {
        @NameInMap("content")
        public String content;

        @NameInMap("title")
        public String title;

        public static CardUpdateCardRequestData build(java.util.Map<String, ?> map) throws Exception {
            CardUpdateCardRequestData self = new CardUpdateCardRequestData();
            return TeaModel.build(map, self);
        }

        public CardUpdateCardRequestData setContent(String content) {
            this.content = content;
            return this;
        }
        public String getContent() {
            return this.content;
        }

        public CardUpdateCardRequestData setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

    }

}
