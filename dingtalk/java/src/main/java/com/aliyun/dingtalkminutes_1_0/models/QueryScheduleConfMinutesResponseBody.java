// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkminutes_1_0.models;

import com.aliyun.tea.*;

public class QueryScheduleConfMinutesResponseBody extends TeaModel {
    @NameInMap("minutesDetails")
    public java.util.List<QueryScheduleConfMinutesResponseBodyMinutesDetails> minutesDetails;

    public static QueryScheduleConfMinutesResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryScheduleConfMinutesResponseBody self = new QueryScheduleConfMinutesResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryScheduleConfMinutesResponseBody setMinutesDetails(java.util.List<QueryScheduleConfMinutesResponseBodyMinutesDetails> minutesDetails) {
        this.minutesDetails = minutesDetails;
        return this;
    }
    public java.util.List<QueryScheduleConfMinutesResponseBodyMinutesDetails> getMinutesDetails() {
        return this.minutesDetails;
    }

    public static class QueryScheduleConfMinutesResponseBodyMinutesDetails extends TeaModel {
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

        public static QueryScheduleConfMinutesResponseBodyMinutesDetails build(java.util.Map<String, ?> map) throws Exception {
            QueryScheduleConfMinutesResponseBodyMinutesDetails self = new QueryScheduleConfMinutesResponseBodyMinutesDetails();
            return TeaModel.build(map, self);
        }

        public QueryScheduleConfMinutesResponseBodyMinutesDetails setBizType(Integer bizType) {
            this.bizType = bizType;
            return this;
        }
        public Integer getBizType() {
            return this.bizType;
        }

        public QueryScheduleConfMinutesResponseBodyMinutesDetails setCreatorNick(String creatorNick) {
            this.creatorNick = creatorNick;
            return this;
        }
        public String getCreatorNick() {
            return this.creatorNick;
        }

        public QueryScheduleConfMinutesResponseBodyMinutesDetails setCreatorUnionId(String creatorUnionId) {
            this.creatorUnionId = creatorUnionId;
            return this;
        }
        public String getCreatorUnionId() {
            return this.creatorUnionId;
        }

        public QueryScheduleConfMinutesResponseBodyMinutesDetails setDurationMicros(Long durationMicros) {
            this.durationMicros = durationMicros;
            return this;
        }
        public Long getDurationMicros() {
            return this.durationMicros;
        }

        public QueryScheduleConfMinutesResponseBodyMinutesDetails setIsDeleted(Integer isDeleted) {
            this.isDeleted = isDeleted;
            return this;
        }
        public Integer getIsDeleted() {
            return this.isDeleted;
        }

        public QueryScheduleConfMinutesResponseBodyMinutesDetails setSize(Long size) {
            this.size = size;
            return this;
        }
        public Long getSize() {
            return this.size;
        }

        public QueryScheduleConfMinutesResponseBodyMinutesDetails setStartTime(Long startTime) {
            this.startTime = startTime;
            return this;
        }
        public Long getStartTime() {
            return this.startTime;
        }

        public QueryScheduleConfMinutesResponseBodyMinutesDetails setStatus(Integer status) {
            this.status = status;
            return this;
        }
        public Integer getStatus() {
            return this.status;
        }

        public QueryScheduleConfMinutesResponseBodyMinutesDetails setTaskUuid(String taskUuid) {
            this.taskUuid = taskUuid;
            return this;
        }
        public String getTaskUuid() {
            return this.taskUuid;
        }

        public QueryScheduleConfMinutesResponseBodyMinutesDetails setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

    }

}
