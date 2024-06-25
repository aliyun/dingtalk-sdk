// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class CardGetCardResponseBody extends TeaModel {
    @NameInMap("result")
    public CardGetCardResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static CardGetCardResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CardGetCardResponseBody self = new CardGetCardResponseBody();
        return TeaModel.build(map, self);
    }

    public CardGetCardResponseBody setResult(CardGetCardResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public CardGetCardResponseBodyResult getResult() {
        return this.result;
    }

    public CardGetCardResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class CardGetCardResponseBodyResult extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p><a href="http://www.dingtalk.com">www.dingtalk.com</a></p>
         */
        @NameInMap("attr")
        public String attr;

        /**
         * <strong>example:</strong>
         * <p>industry_center</p>
         */
        @NameInMap("cardBizCode")
        public String cardBizCode;

        /**
         * <strong>example:</strong>
         * <p>23424234</p>
         */
        @NameInMap("cardBizId")
        public String cardBizId;

        /**
         * <strong>example:</strong>
         * <p>1</p>
         */
        @NameInMap("cardContentCount")
        public Integer cardContentCount;

        /**
         * <strong>example:</strong>
         * <p>2</p>
         */
        @NameInMap("cardCycle")
        public Integer cardCycle;

        @NameInMap("cardFrequency")
        public java.util.List<Integer> cardFrequency;

        /**
         * <strong>example:</strong>
         * <p>234234234324</p>
         */
        @NameInMap("cardId")
        public Long cardId;

        /**
         * <strong>example:</strong>
         * <p>1</p>
         */
        @NameInMap("cardStatus")
        public Integer cardStatus;

        /**
         * <strong>example:</strong>
         * <p><a href="http://www.dingtalk.com">www.dingtalk.com</a></p>
         */
        @NameInMap("cardUrl")
        public String cardUrl;

        /**
         * <strong>example:</strong>
         * <p>音乐</p>
         */
        @NameInMap("categoryContentTag")
        public String categoryContentTag;

        /**
         * <strong>example:</strong>
         * <p><a href="http://www.dingtalk.com">www.dingtalk.com</a></p>
         */
        @NameInMap("categoryCoverImageUrl")
        public String categoryCoverImageUrl;

        /**
         * <strong>example:</strong>
         * <p><a href="http://www.dingtalk.com">www.dingtalk.com</a></p>
         */
        @NameInMap("categoryCreateCardSmallImageUrl")
        public String categoryCreateCardSmallImageUrl;

        /**
         * <strong>example:</strong>
         * <p><a href="http://www.dingtalk.com">www.dingtalk.com</a></p>
         */
        @NameInMap("categoryListSmallImageUrl")
        public String categoryListSmallImageUrl;

        /**
         * <strong>example:</strong>
         * <p>美术</p>
         */
        @NameInMap("categoryName")
        public String categoryName;

        @NameInMap("classIds")
        public java.util.List<String> classIds;

        @NameInMap("classNames")
        public java.util.List<String> classNames;

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
         * <p>2023-11-15</p>
         */
        @NameInMap("effectTime")
        public String effectTime;

        @NameInMap("finished")
        public Boolean finished;

        /**
         * <strong>example:</strong>
         * <p><a href="http://www.dingtalk.com">www.dingtalk.com</a></p>
         */
        @NameInMap("media")
        public String media;

        /**
         * <strong>example:</strong>
         * <p>2023-11-15</p>
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
         * <p>20</p>
         */
        @NameInMap("remindNotPunchCardHour")
        public Integer remindNotPunchCardHour;

        /**
         * <strong>example:</strong>
         * <p>10</p>
         */
        @NameInMap("remindNotPunchCardMinute")
        public Integer remindNotPunchCardMinute;

        /**
         * <strong>example:</strong>
         * <p>2023-11-15</p>
         */
        @NameInMap("sendTime")
        public String sendTime;

        /**
         * <strong>example:</strong>
         * <p>YUFANAI</p>
         */
        @NameInMap("sourceType")
        public String sourceType;

        /**
         * <strong>example:</strong>
         * <p>2023-11-15</p>
         */
        @NameInMap("startTime")
        public String startTime;

        /**
         * <strong>example:</strong>
         * <p>1</p>
         */
        @NameInMap("status")
        public Integer status;

        /**
         * <strong>example:</strong>
         * <p>424234324324</p>
         */
        @NameInMap("systemTime")
        public Long systemTime;

        /**
         * <strong>example:</strong>
         * <p>234234234</p>
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
         * <p><a href="http://www.dingtalk.com">www.dingtalk.com</a></p>
         */
        @NameInMap("templateCoverImageUrl")
        public String templateCoverImageUrl;

        /**
         * <strong>example:</strong>
         * <p>每日复习</p>
         */
        @NameInMap("title")
        public String title;

        /**
         * <strong>example:</strong>
         * <p>3</p>
         */
        @NameInMap("type")
        public Integer type;

        public static CardGetCardResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            CardGetCardResponseBodyResult self = new CardGetCardResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public CardGetCardResponseBodyResult setAttr(String attr) {
            this.attr = attr;
            return this;
        }
        public String getAttr() {
            return this.attr;
        }

        public CardGetCardResponseBodyResult setCardBizCode(String cardBizCode) {
            this.cardBizCode = cardBizCode;
            return this;
        }
        public String getCardBizCode() {
            return this.cardBizCode;
        }

        public CardGetCardResponseBodyResult setCardBizId(String cardBizId) {
            this.cardBizId = cardBizId;
            return this;
        }
        public String getCardBizId() {
            return this.cardBizId;
        }

        public CardGetCardResponseBodyResult setCardContentCount(Integer cardContentCount) {
            this.cardContentCount = cardContentCount;
            return this;
        }
        public Integer getCardContentCount() {
            return this.cardContentCount;
        }

        public CardGetCardResponseBodyResult setCardCycle(Integer cardCycle) {
            this.cardCycle = cardCycle;
            return this;
        }
        public Integer getCardCycle() {
            return this.cardCycle;
        }

        public CardGetCardResponseBodyResult setCardFrequency(java.util.List<Integer> cardFrequency) {
            this.cardFrequency = cardFrequency;
            return this;
        }
        public java.util.List<Integer> getCardFrequency() {
            return this.cardFrequency;
        }

        public CardGetCardResponseBodyResult setCardId(Long cardId) {
            this.cardId = cardId;
            return this;
        }
        public Long getCardId() {
            return this.cardId;
        }

        public CardGetCardResponseBodyResult setCardStatus(Integer cardStatus) {
            this.cardStatus = cardStatus;
            return this;
        }
        public Integer getCardStatus() {
            return this.cardStatus;
        }

        public CardGetCardResponseBodyResult setCardUrl(String cardUrl) {
            this.cardUrl = cardUrl;
            return this;
        }
        public String getCardUrl() {
            return this.cardUrl;
        }

        public CardGetCardResponseBodyResult setCategoryContentTag(String categoryContentTag) {
            this.categoryContentTag = categoryContentTag;
            return this;
        }
        public String getCategoryContentTag() {
            return this.categoryContentTag;
        }

        public CardGetCardResponseBodyResult setCategoryCoverImageUrl(String categoryCoverImageUrl) {
            this.categoryCoverImageUrl = categoryCoverImageUrl;
            return this;
        }
        public String getCategoryCoverImageUrl() {
            return this.categoryCoverImageUrl;
        }

        public CardGetCardResponseBodyResult setCategoryCreateCardSmallImageUrl(String categoryCreateCardSmallImageUrl) {
            this.categoryCreateCardSmallImageUrl = categoryCreateCardSmallImageUrl;
            return this;
        }
        public String getCategoryCreateCardSmallImageUrl() {
            return this.categoryCreateCardSmallImageUrl;
        }

        public CardGetCardResponseBodyResult setCategoryListSmallImageUrl(String categoryListSmallImageUrl) {
            this.categoryListSmallImageUrl = categoryListSmallImageUrl;
            return this;
        }
        public String getCategoryListSmallImageUrl() {
            return this.categoryListSmallImageUrl;
        }

        public CardGetCardResponseBodyResult setCategoryName(String categoryName) {
            this.categoryName = categoryName;
            return this;
        }
        public String getCategoryName() {
            return this.categoryName;
        }

        public CardGetCardResponseBodyResult setClassIds(java.util.List<String> classIds) {
            this.classIds = classIds;
            return this;
        }
        public java.util.List<String> getClassIds() {
            return this.classIds;
        }

        public CardGetCardResponseBodyResult setClassNames(java.util.List<String> classNames) {
            this.classNames = classNames;
            return this;
        }
        public java.util.List<String> getClassNames() {
            return this.classNames;
        }

        public CardGetCardResponseBodyResult setContent(String content) {
            this.content = content;
            return this;
        }
        public String getContent() {
            return this.content;
        }

        public CardGetCardResponseBodyResult setCorpId(String corpId) {
            this.corpId = corpId;
            return this;
        }
        public String getCorpId() {
            return this.corpId;
        }

        public CardGetCardResponseBodyResult setEffectTime(String effectTime) {
            this.effectTime = effectTime;
            return this;
        }
        public String getEffectTime() {
            return this.effectTime;
        }

        public CardGetCardResponseBodyResult setFinished(Boolean finished) {
            this.finished = finished;
            return this;
        }
        public Boolean getFinished() {
            return this.finished;
        }

        public CardGetCardResponseBodyResult setMedia(String media) {
            this.media = media;
            return this;
        }
        public String getMedia() {
            return this.media;
        }

        public CardGetCardResponseBodyResult setOptEndTime(String optEndTime) {
            this.optEndTime = optEndTime;
            return this;
        }
        public String getOptEndTime() {
            return this.optEndTime;
        }

        public CardGetCardResponseBodyResult setOptEndUserId(String optEndUserId) {
            this.optEndUserId = optEndUserId;
            return this;
        }
        public String getOptEndUserId() {
            return this.optEndUserId;
        }

        public CardGetCardResponseBodyResult setOptEndUserName(String optEndUserName) {
            this.optEndUserName = optEndUserName;
            return this;
        }
        public String getOptEndUserName() {
            return this.optEndUserName;
        }

        public CardGetCardResponseBodyResult setRemindNotPunchCardHour(Integer remindNotPunchCardHour) {
            this.remindNotPunchCardHour = remindNotPunchCardHour;
            return this;
        }
        public Integer getRemindNotPunchCardHour() {
            return this.remindNotPunchCardHour;
        }

        public CardGetCardResponseBodyResult setRemindNotPunchCardMinute(Integer remindNotPunchCardMinute) {
            this.remindNotPunchCardMinute = remindNotPunchCardMinute;
            return this;
        }
        public Integer getRemindNotPunchCardMinute() {
            return this.remindNotPunchCardMinute;
        }

        public CardGetCardResponseBodyResult setSendTime(String sendTime) {
            this.sendTime = sendTime;
            return this;
        }
        public String getSendTime() {
            return this.sendTime;
        }

        public CardGetCardResponseBodyResult setSourceType(String sourceType) {
            this.sourceType = sourceType;
            return this;
        }
        public String getSourceType() {
            return this.sourceType;
        }

        public CardGetCardResponseBodyResult setStartTime(String startTime) {
            this.startTime = startTime;
            return this;
        }
        public String getStartTime() {
            return this.startTime;
        }

        public CardGetCardResponseBodyResult setStatus(Integer status) {
            this.status = status;
            return this;
        }
        public Integer getStatus() {
            return this.status;
        }

        public CardGetCardResponseBodyResult setSystemTime(Long systemTime) {
            this.systemTime = systemTime;
            return this;
        }
        public Long getSystemTime() {
            return this.systemTime;
        }

        public CardGetCardResponseBodyResult setTeacherId(String teacherId) {
            this.teacherId = teacherId;
            return this;
        }
        public String getTeacherId() {
            return this.teacherId;
        }

        public CardGetCardResponseBodyResult setTeacherName(String teacherName) {
            this.teacherName = teacherName;
            return this;
        }
        public String getTeacherName() {
            return this.teacherName;
        }

        public CardGetCardResponseBodyResult setTemplateCoverImageUrl(String templateCoverImageUrl) {
            this.templateCoverImageUrl = templateCoverImageUrl;
            return this;
        }
        public String getTemplateCoverImageUrl() {
            return this.templateCoverImageUrl;
        }

        public CardGetCardResponseBodyResult setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

        public CardGetCardResponseBodyResult setType(Integer type) {
            this.type = type;
            return this;
        }
        public Integer getType() {
            return this.type;
        }

    }

}
