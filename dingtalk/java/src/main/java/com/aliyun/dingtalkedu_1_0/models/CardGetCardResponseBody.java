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
        @NameInMap("attr")
        public String attr;

        @NameInMap("cardBizCode")
        public String cardBizCode;

        @NameInMap("cardBizId")
        public String cardBizId;

        @NameInMap("cardContentCount")
        public Integer cardContentCount;

        @NameInMap("cardCycle")
        public Integer cardCycle;

        @NameInMap("cardFrequency")
        public java.util.List<Integer> cardFrequency;

        @NameInMap("cardId")
        public Long cardId;

        @NameInMap("cardStatus")
        public Integer cardStatus;

        @NameInMap("cardUrl")
        public String cardUrl;

        @NameInMap("categoryContentTag")
        public String categoryContentTag;

        @NameInMap("categoryCoverImageUrl")
        public String categoryCoverImageUrl;

        @NameInMap("categoryCreateCardSmallImageUrl")
        public String categoryCreateCardSmallImageUrl;

        @NameInMap("categoryListSmallImageUrl")
        public String categoryListSmallImageUrl;

        @NameInMap("categoryName")
        public String categoryName;

        @NameInMap("classIds")
        public java.util.List<String> classIds;

        @NameInMap("classNames")
        public java.util.List<String> classNames;

        @NameInMap("content")
        public String content;

        @NameInMap("corpId")
        public String corpId;

        @NameInMap("effectTime")
        public Long effectTime;

        @NameInMap("finished")
        public Boolean finished;

        @NameInMap("media")
        public String media;

        @NameInMap("optEndTime")
        public Long optEndTime;

        @NameInMap("optEndUserId")
        public String optEndUserId;

        @NameInMap("optEndUserName")
        public String optEndUserName;

        @NameInMap("remindNotPunchCardHour")
        public Integer remindNotPunchCardHour;

        @NameInMap("remindNotPunchCardMinute")
        public Integer remindNotPunchCardMinute;

        @NameInMap("sendTime")
        public Long sendTime;

        @NameInMap("sourceType")
        public String sourceType;

        @NameInMap("startTime")
        public Long startTime;

        @NameInMap("status")
        public Integer status;

        @NameInMap("systemTime")
        public Long systemTime;

        @NameInMap("teacherId")
        public String teacherId;

        @NameInMap("teacherName")
        public String teacherName;

        @NameInMap("templateCoverImageUrl")
        public String templateCoverImageUrl;

        @NameInMap("title")
        public String title;

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

        public CardGetCardResponseBodyResult setEffectTime(Long effectTime) {
            this.effectTime = effectTime;
            return this;
        }
        public Long getEffectTime() {
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

        public CardGetCardResponseBodyResult setOptEndTime(Long optEndTime) {
            this.optEndTime = optEndTime;
            return this;
        }
        public Long getOptEndTime() {
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

        public CardGetCardResponseBodyResult setSendTime(Long sendTime) {
            this.sendTime = sendTime;
            return this;
        }
        public Long getSendTime() {
            return this.sendTime;
        }

        public CardGetCardResponseBodyResult setSourceType(String sourceType) {
            this.sourceType = sourceType;
            return this;
        }
        public String getSourceType() {
            return this.sourceType;
        }

        public CardGetCardResponseBodyResult setStartTime(Long startTime) {
            this.startTime = startTime;
            return this;
        }
        public Long getStartTime() {
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
