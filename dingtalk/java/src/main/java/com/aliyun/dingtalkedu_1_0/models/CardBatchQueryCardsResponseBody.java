// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class CardBatchQueryCardsResponseBody extends TeaModel {
    @NameInMap("result")
    public CardBatchQueryCardsResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static CardBatchQueryCardsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CardBatchQueryCardsResponseBody self = new CardBatchQueryCardsResponseBody();
        return TeaModel.build(map, self);
    }

    public CardBatchQueryCardsResponseBody setResult(CardBatchQueryCardsResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public CardBatchQueryCardsResponseBodyResult getResult() {
        return this.result;
    }

    public CardBatchQueryCardsResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class CardBatchQueryCardsResponseBodyResultCards extends TeaModel {
        @NameInMap("cardBizCode")
        public String cardBizCode;

        @NameInMap("cardId")
        public Long cardId;

        @NameInMap("cardStatus")
        public Integer cardStatus;

        @NameInMap("content")
        public String content;

        @NameInMap("corpId")
        public String corpId;

        @NameInMap("effectTime")
        public Long effectTime;

        @NameInMap("finished")
        public Boolean finished;

        @NameInMap("gmtCreate")
        public Long gmtCreate;

        @NameInMap("optEndTime")
        public Long optEndTime;

        @NameInMap("optEndUserId")
        public String optEndUserId;

        @NameInMap("optEndUserName")
        public String optEndUserName;

        @NameInMap("sendTime")
        public Long sendTime;

        @NameInMap("startTime")
        public Long startTime;

        @NameInMap("status")
        public Integer status;

        @NameInMap("teacherId")
        public String teacherId;

        @NameInMap("teacherName")
        public String teacherName;

        @NameInMap("title")
        public String title;

        @NameInMap("type")
        public Integer type;

        public static CardBatchQueryCardsResponseBodyResultCards build(java.util.Map<String, ?> map) throws Exception {
            CardBatchQueryCardsResponseBodyResultCards self = new CardBatchQueryCardsResponseBodyResultCards();
            return TeaModel.build(map, self);
        }

        public CardBatchQueryCardsResponseBodyResultCards setCardBizCode(String cardBizCode) {
            this.cardBizCode = cardBizCode;
            return this;
        }
        public String getCardBizCode() {
            return this.cardBizCode;
        }

        public CardBatchQueryCardsResponseBodyResultCards setCardId(Long cardId) {
            this.cardId = cardId;
            return this;
        }
        public Long getCardId() {
            return this.cardId;
        }

        public CardBatchQueryCardsResponseBodyResultCards setCardStatus(Integer cardStatus) {
            this.cardStatus = cardStatus;
            return this;
        }
        public Integer getCardStatus() {
            return this.cardStatus;
        }

        public CardBatchQueryCardsResponseBodyResultCards setContent(String content) {
            this.content = content;
            return this;
        }
        public String getContent() {
            return this.content;
        }

        public CardBatchQueryCardsResponseBodyResultCards setCorpId(String corpId) {
            this.corpId = corpId;
            return this;
        }
        public String getCorpId() {
            return this.corpId;
        }

        public CardBatchQueryCardsResponseBodyResultCards setEffectTime(Long effectTime) {
            this.effectTime = effectTime;
            return this;
        }
        public Long getEffectTime() {
            return this.effectTime;
        }

        public CardBatchQueryCardsResponseBodyResultCards setFinished(Boolean finished) {
            this.finished = finished;
            return this;
        }
        public Boolean getFinished() {
            return this.finished;
        }

        public CardBatchQueryCardsResponseBodyResultCards setGmtCreate(Long gmtCreate) {
            this.gmtCreate = gmtCreate;
            return this;
        }
        public Long getGmtCreate() {
            return this.gmtCreate;
        }

        public CardBatchQueryCardsResponseBodyResultCards setOptEndTime(Long optEndTime) {
            this.optEndTime = optEndTime;
            return this;
        }
        public Long getOptEndTime() {
            return this.optEndTime;
        }

        public CardBatchQueryCardsResponseBodyResultCards setOptEndUserId(String optEndUserId) {
            this.optEndUserId = optEndUserId;
            return this;
        }
        public String getOptEndUserId() {
            return this.optEndUserId;
        }

        public CardBatchQueryCardsResponseBodyResultCards setOptEndUserName(String optEndUserName) {
            this.optEndUserName = optEndUserName;
            return this;
        }
        public String getOptEndUserName() {
            return this.optEndUserName;
        }

        public CardBatchQueryCardsResponseBodyResultCards setSendTime(Long sendTime) {
            this.sendTime = sendTime;
            return this;
        }
        public Long getSendTime() {
            return this.sendTime;
        }

        public CardBatchQueryCardsResponseBodyResultCards setStartTime(Long startTime) {
            this.startTime = startTime;
            return this;
        }
        public Long getStartTime() {
            return this.startTime;
        }

        public CardBatchQueryCardsResponseBodyResultCards setStatus(Integer status) {
            this.status = status;
            return this;
        }
        public Integer getStatus() {
            return this.status;
        }

        public CardBatchQueryCardsResponseBodyResultCards setTeacherId(String teacherId) {
            this.teacherId = teacherId;
            return this;
        }
        public String getTeacherId() {
            return this.teacherId;
        }

        public CardBatchQueryCardsResponseBodyResultCards setTeacherName(String teacherName) {
            this.teacherName = teacherName;
            return this;
        }
        public String getTeacherName() {
            return this.teacherName;
        }

        public CardBatchQueryCardsResponseBodyResultCards setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

        public CardBatchQueryCardsResponseBodyResultCards setType(Integer type) {
            this.type = type;
            return this;
        }
        public Integer getType() {
            return this.type;
        }

    }

    public static class CardBatchQueryCardsResponseBodyResult extends TeaModel {
        @NameInMap("cards")
        public java.util.List<CardBatchQueryCardsResponseBodyResultCards> cards;

        public static CardBatchQueryCardsResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            CardBatchQueryCardsResponseBodyResult self = new CardBatchQueryCardsResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public CardBatchQueryCardsResponseBodyResult setCards(java.util.List<CardBatchQueryCardsResponseBodyResultCards> cards) {
            this.cards = cards;
            return this;
        }
        public java.util.List<CardBatchQueryCardsResponseBodyResultCards> getCards() {
            return this.cards;
        }

    }

}
