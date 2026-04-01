// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkminutes_1_0.models;

import com.aliyun.tea.*;

public class AdminSearchMinutesResponseBody extends TeaModel {
    @NameInMap("hasMore")
    public Boolean hasMore;

    @NameInMap("minutesList")
    public java.util.List<AdminSearchMinutesResponseBodyMinutesList> minutesList;

    @NameInMap("nextToken")
    public String nextToken;

    public static AdminSearchMinutesResponseBody build(java.util.Map<String, ?> map) throws Exception {
        AdminSearchMinutesResponseBody self = new AdminSearchMinutesResponseBody();
        return TeaModel.build(map, self);
    }

    public AdminSearchMinutesResponseBody setHasMore(Boolean hasMore) {
        this.hasMore = hasMore;
        return this;
    }
    public Boolean getHasMore() {
        return this.hasMore;
    }

    public AdminSearchMinutesResponseBody setMinutesList(java.util.List<AdminSearchMinutesResponseBodyMinutesList> minutesList) {
        this.minutesList = minutesList;
        return this;
    }
    public java.util.List<AdminSearchMinutesResponseBodyMinutesList> getMinutesList() {
        return this.minutesList;
    }

    public AdminSearchMinutesResponseBody setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public static class AdminSearchMinutesResponseBodyMinutesList extends TeaModel {
        @NameInMap("bizType")
        public Integer bizType;

        @NameInMap("creatorNick")
        public String creatorNick;

        @NameInMap("creatorUnionId")
        public String creatorUnionId;

        @NameInMap("duration")
        public Long duration;

        @NameInMap("fullTextSummary")
        public String fullTextSummary;

        @NameInMap("originalText")
        public String originalText;

        @NameInMap("startTime")
        public Long startTime;

        @NameInMap("status")
        public Integer status;

        @NameInMap("taskUuid")
        public String taskUuid;

        @NameInMap("title")
        public String title;

        public static AdminSearchMinutesResponseBodyMinutesList build(java.util.Map<String, ?> map) throws Exception {
            AdminSearchMinutesResponseBodyMinutesList self = new AdminSearchMinutesResponseBodyMinutesList();
            return TeaModel.build(map, self);
        }

        public AdminSearchMinutesResponseBodyMinutesList setBizType(Integer bizType) {
            this.bizType = bizType;
            return this;
        }
        public Integer getBizType() {
            return this.bizType;
        }

        public AdminSearchMinutesResponseBodyMinutesList setCreatorNick(String creatorNick) {
            this.creatorNick = creatorNick;
            return this;
        }
        public String getCreatorNick() {
            return this.creatorNick;
        }

        public AdminSearchMinutesResponseBodyMinutesList setCreatorUnionId(String creatorUnionId) {
            this.creatorUnionId = creatorUnionId;
            return this;
        }
        public String getCreatorUnionId() {
            return this.creatorUnionId;
        }

        public AdminSearchMinutesResponseBodyMinutesList setDuration(Long duration) {
            this.duration = duration;
            return this;
        }
        public Long getDuration() {
            return this.duration;
        }

        public AdminSearchMinutesResponseBodyMinutesList setFullTextSummary(String fullTextSummary) {
            this.fullTextSummary = fullTextSummary;
            return this;
        }
        public String getFullTextSummary() {
            return this.fullTextSummary;
        }

        public AdminSearchMinutesResponseBodyMinutesList setOriginalText(String originalText) {
            this.originalText = originalText;
            return this;
        }
        public String getOriginalText() {
            return this.originalText;
        }

        public AdminSearchMinutesResponseBodyMinutesList setStartTime(Long startTime) {
            this.startTime = startTime;
            return this;
        }
        public Long getStartTime() {
            return this.startTime;
        }

        public AdminSearchMinutesResponseBodyMinutesList setStatus(Integer status) {
            this.status = status;
            return this;
        }
        public Integer getStatus() {
            return this.status;
        }

        public AdminSearchMinutesResponseBodyMinutesList setTaskUuid(String taskUuid) {
            this.taskUuid = taskUuid;
            return this;
        }
        public String getTaskUuid() {
            return this.taskUuid;
        }

        public AdminSearchMinutesResponseBodyMinutesList setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

    }

}
