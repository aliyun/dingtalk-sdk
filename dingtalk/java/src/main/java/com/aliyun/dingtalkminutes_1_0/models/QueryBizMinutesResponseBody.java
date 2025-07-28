// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkminutes_1_0.models;

import com.aliyun.tea.*;

public class QueryBizMinutesResponseBody extends TeaModel {
    @NameInMap("minutesDetails")
    public java.util.List<QueryBizMinutesResponseBodyMinutesDetails> minutesDetails;

    public static QueryBizMinutesResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryBizMinutesResponseBody self = new QueryBizMinutesResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryBizMinutesResponseBody setMinutesDetails(java.util.List<QueryBizMinutesResponseBodyMinutesDetails> minutesDetails) {
        this.minutesDetails = minutesDetails;
        return this;
    }
    public java.util.List<QueryBizMinutesResponseBodyMinutesDetails> getMinutesDetails() {
        return this.minutesDetails;
    }

    public static class QueryBizMinutesResponseBodyMinutesDetails extends TeaModel {
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

        public static QueryBizMinutesResponseBodyMinutesDetails build(java.util.Map<String, ?> map) throws Exception {
            QueryBizMinutesResponseBodyMinutesDetails self = new QueryBizMinutesResponseBodyMinutesDetails();
            return TeaModel.build(map, self);
        }

        public QueryBizMinutesResponseBodyMinutesDetails setBizType(Integer bizType) {
            this.bizType = bizType;
            return this;
        }
        public Integer getBizType() {
            return this.bizType;
        }

        public QueryBizMinutesResponseBodyMinutesDetails setCreatorNick(String creatorNick) {
            this.creatorNick = creatorNick;
            return this;
        }
        public String getCreatorNick() {
            return this.creatorNick;
        }

        public QueryBizMinutesResponseBodyMinutesDetails setCreatorUnionId(String creatorUnionId) {
            this.creatorUnionId = creatorUnionId;
            return this;
        }
        public String getCreatorUnionId() {
            return this.creatorUnionId;
        }

        public QueryBizMinutesResponseBodyMinutesDetails setDurationMicros(Long durationMicros) {
            this.durationMicros = durationMicros;
            return this;
        }
        public Long getDurationMicros() {
            return this.durationMicros;
        }

        public QueryBizMinutesResponseBodyMinutesDetails setIsDeleted(Integer isDeleted) {
            this.isDeleted = isDeleted;
            return this;
        }
        public Integer getIsDeleted() {
            return this.isDeleted;
        }

        public QueryBizMinutesResponseBodyMinutesDetails setSize(Long size) {
            this.size = size;
            return this;
        }
        public Long getSize() {
            return this.size;
        }

        public QueryBizMinutesResponseBodyMinutesDetails setStartTime(Long startTime) {
            this.startTime = startTime;
            return this;
        }
        public Long getStartTime() {
            return this.startTime;
        }

        public QueryBizMinutesResponseBodyMinutesDetails setStatus(Integer status) {
            this.status = status;
            return this;
        }
        public Integer getStatus() {
            return this.status;
        }

        public QueryBizMinutesResponseBodyMinutesDetails setTaskUuid(String taskUuid) {
            this.taskUuid = taskUuid;
            return this;
        }
        public String getTaskUuid() {
            return this.taskUuid;
        }

        public QueryBizMinutesResponseBodyMinutesDetails setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

    }

}
