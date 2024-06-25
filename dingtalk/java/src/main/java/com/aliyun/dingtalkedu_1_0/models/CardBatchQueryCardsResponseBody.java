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
        /**
         * <strong>example:</strong>
         * <p>industry_center</p>
         */
        @NameInMap("cardBizCode")
        public String cardBizCode;

        /**
         * <strong>example:</strong>
         * <p>234234234</p>
         */
        @NameInMap("cardId")
        public Long cardId;

        /**
         * <strong>example:</strong>
         * <p>2</p>
         */
        @NameInMap("cardStatus")
        public Integer cardStatus;

        /**
         * <strong>example:</strong>
         * <p>打卡任务</p>
         */
        @NameInMap("content")
        public String content;

        /**
         * <strong>example:</strong>
         * <p>dingdf19b4ee0d73233735c2f4657eb6378f</p>
         */
        @NameInMap("corpId")
        public String corpId;

        /**
         * <strong>example:</strong>
         * <p>2023-11-16</p>
         */
        @NameInMap("effectTime")
        public String effectTime;

        @NameInMap("finished")
        public Boolean finished;

        /**
         * <strong>example:</strong>
         * <p>2023-11-19</p>
         */
        @NameInMap("gmtCreate")
        public String gmtCreate;

        /**
         * <strong>example:</strong>
         * <p>2023-11-16</p>
         */
        @NameInMap("optEndTime")
        public String optEndTime;

        /**
         * <strong>example:</strong>
         * <p>234234234</p>
         */
        @NameInMap("optEndUserId")
        public String optEndUserId;

        /**
         * <strong>example:</strong>
         * <p>张三</p>
         */
        @NameInMap("optEndUserName")
        public String optEndUserName;

        /**
         * <strong>example:</strong>
         * <p>2023-11-16</p>
         */
        @NameInMap("sendTime")
        public String sendTime;

        /**
         * <strong>example:</strong>
         * <p>2023-11-16</p>
         */
        @NameInMap("startTime")
        public String startTime;

        /**
         * <strong>example:</strong>
         * <p>2</p>
         */
        @NameInMap("status")
        public Integer status;

        /**
         * <strong>example:</strong>
         * <p>23234234</p>
         */
        @NameInMap("teacherId")
        public String teacherId;

        /**
         * <strong>example:</strong>
         * <p>张三</p>
         */
        @NameInMap("teacherName")
        public String teacherName;

        /**
         * <strong>example:</strong>
         * <p>每日锻炼</p>
         */
        @NameInMap("title")
        public String title;

        /**
         * <strong>example:</strong>
         * <p>1</p>
         */
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

        public CardBatchQueryCardsResponseBodyResultCards setEffectTime(String effectTime) {
            this.effectTime = effectTime;
            return this;
        }
        public String getEffectTime() {
            return this.effectTime;
        }

        public CardBatchQueryCardsResponseBodyResultCards setFinished(Boolean finished) {
            this.finished = finished;
            return this;
        }
        public Boolean getFinished() {
            return this.finished;
        }

        public CardBatchQueryCardsResponseBodyResultCards setGmtCreate(String gmtCreate) {
            this.gmtCreate = gmtCreate;
            return this;
        }
        public String getGmtCreate() {
            return this.gmtCreate;
        }

        public CardBatchQueryCardsResponseBodyResultCards setOptEndTime(String optEndTime) {
            this.optEndTime = optEndTime;
            return this;
        }
        public String getOptEndTime() {
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

        public CardBatchQueryCardsResponseBodyResultCards setSendTime(String sendTime) {
            this.sendTime = sendTime;
            return this;
        }
        public String getSendTime() {
            return this.sendTime;
        }

        public CardBatchQueryCardsResponseBodyResultCards setStartTime(String startTime) {
            this.startTime = startTime;
            return this;
        }
        public String getStartTime() {
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
