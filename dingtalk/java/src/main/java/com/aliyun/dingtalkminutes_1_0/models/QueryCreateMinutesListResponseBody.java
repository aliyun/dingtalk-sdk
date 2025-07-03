// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkminutes_1_0.models;

import com.aliyun.tea.*;

public class QueryCreateMinutesListResponseBody extends TeaModel {
    @NameInMap("hasNext")
    public Boolean hasNext;

    @NameInMap("minutesDetails")
    public java.util.List<QueryCreateMinutesListResponseBodyMinutesDetails> minutesDetails;

    @NameInMap("nextToken")
    public String nextToken;

    public static QueryCreateMinutesListResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryCreateMinutesListResponseBody self = new QueryCreateMinutesListResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryCreateMinutesListResponseBody setHasNext(Boolean hasNext) {
        this.hasNext = hasNext;
        return this;
    }
    public Boolean getHasNext() {
        return this.hasNext;
    }

    public QueryCreateMinutesListResponseBody setMinutesDetails(java.util.List<QueryCreateMinutesListResponseBodyMinutesDetails> minutesDetails) {
        this.minutesDetails = minutesDetails;
        return this;
    }
    public java.util.List<QueryCreateMinutesListResponseBodyMinutesDetails> getMinutesDetails() {
        return this.minutesDetails;
    }

    public QueryCreateMinutesListResponseBody setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public static class QueryCreateMinutesListResponseBodyMinutesDetails extends TeaModel {
        @NameInMap("bizType")
        public Integer bizType;

        @NameInMap("creatorNick")
        public String creatorNick;

        @NameInMap("creatorUnionId")
        public String creatorUnionId;

        @NameInMap("durationMicros")
        public Long durationMicros;

        @NameInMap("isDeleted")
        public Integer isDeleted;

        @NameInMap("size")
        public Long size;

        @NameInMap("startTime")
        public Long startTime;

        @NameInMap("status")
        public Integer status;

        @NameInMap("taskUuid")
        public String taskUuid;

        @NameInMap("title")
        public String title;

        public static QueryCreateMinutesListResponseBodyMinutesDetails build(java.util.Map<String, ?> map) throws Exception {
            QueryCreateMinutesListResponseBodyMinutesDetails self = new QueryCreateMinutesListResponseBodyMinutesDetails();
            return TeaModel.build(map, self);
        }

        public QueryCreateMinutesListResponseBodyMinutesDetails setBizType(Integer bizType) {
            this.bizType = bizType;
            return this;
        }
        public Integer getBizType() {
            return this.bizType;
        }

        public QueryCreateMinutesListResponseBodyMinutesDetails setCreatorNick(String creatorNick) {
            this.creatorNick = creatorNick;
            return this;
        }
        public String getCreatorNick() {
            return this.creatorNick;
        }

        public QueryCreateMinutesListResponseBodyMinutesDetails setCreatorUnionId(String creatorUnionId) {
            this.creatorUnionId = creatorUnionId;
            return this;
        }
        public String getCreatorUnionId() {
            return this.creatorUnionId;
        }

        public QueryCreateMinutesListResponseBodyMinutesDetails setDurationMicros(Long durationMicros) {
            this.durationMicros = durationMicros;
            return this;
        }
        public Long getDurationMicros() {
            return this.durationMicros;
        }

        public QueryCreateMinutesListResponseBodyMinutesDetails setIsDeleted(Integer isDeleted) {
            this.isDeleted = isDeleted;
            return this;
        }
        public Integer getIsDeleted() {
            return this.isDeleted;
        }

        public QueryCreateMinutesListResponseBodyMinutesDetails setSize(Long size) {
            this.size = size;
            return this;
        }
        public Long getSize() {
            return this.size;
        }

        public QueryCreateMinutesListResponseBodyMinutesDetails setStartTime(Long startTime) {
            this.startTime = startTime;
            return this;
        }
        public Long getStartTime() {
            return this.startTime;
        }

        public QueryCreateMinutesListResponseBodyMinutesDetails setStatus(Integer status) {
            this.status = status;
            return this;
        }
        public Integer getStatus() {
            return this.status;
        }

        public QueryCreateMinutesListResponseBodyMinutesDetails setTaskUuid(String taskUuid) {
            this.taskUuid = taskUuid;
            return this;
        }
        public String getTaskUuid() {
            return this.taskUuid;
        }

        public QueryCreateMinutesListResponseBodyMinutesDetails setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

    }

}
