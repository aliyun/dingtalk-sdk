// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkminutes_1_0.models;

import com.aliyun.tea.*;

public class BatchGetMinutesDetailsResponseBody extends TeaModel {
    @NameInMap("minutesDetails")
    public java.util.List<BatchGetMinutesDetailsResponseBodyMinutesDetails> minutesDetails;

    public static BatchGetMinutesDetailsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        BatchGetMinutesDetailsResponseBody self = new BatchGetMinutesDetailsResponseBody();
        return TeaModel.build(map, self);
    }

    public BatchGetMinutesDetailsResponseBody setMinutesDetails(java.util.List<BatchGetMinutesDetailsResponseBodyMinutesDetails> minutesDetails) {
        this.minutesDetails = minutesDetails;
        return this;
    }
    public java.util.List<BatchGetMinutesDetailsResponseBodyMinutesDetails> getMinutesDetails() {
        return this.minutesDetails;
    }

    public static class BatchGetMinutesDetailsResponseBodyMinutesDetails extends TeaModel {
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

        public static BatchGetMinutesDetailsResponseBodyMinutesDetails build(java.util.Map<String, ?> map) throws Exception {
            BatchGetMinutesDetailsResponseBodyMinutesDetails self = new BatchGetMinutesDetailsResponseBodyMinutesDetails();
            return TeaModel.build(map, self);
        }

        public BatchGetMinutesDetailsResponseBodyMinutesDetails setBizType(Integer bizType) {
            this.bizType = bizType;
            return this;
        }
        public Integer getBizType() {
            return this.bizType;
        }

        public BatchGetMinutesDetailsResponseBodyMinutesDetails setCreatorNick(String creatorNick) {
            this.creatorNick = creatorNick;
            return this;
        }
        public String getCreatorNick() {
            return this.creatorNick;
        }

        public BatchGetMinutesDetailsResponseBodyMinutesDetails setCreatorUnionId(String creatorUnionId) {
            this.creatorUnionId = creatorUnionId;
            return this;
        }
        public String getCreatorUnionId() {
            return this.creatorUnionId;
        }

        public BatchGetMinutesDetailsResponseBodyMinutesDetails setDurationMicros(Long durationMicros) {
            this.durationMicros = durationMicros;
            return this;
        }
        public Long getDurationMicros() {
            return this.durationMicros;
        }

        public BatchGetMinutesDetailsResponseBodyMinutesDetails setIsDeleted(Integer isDeleted) {
            this.isDeleted = isDeleted;
            return this;
        }
        public Integer getIsDeleted() {
            return this.isDeleted;
        }

        public BatchGetMinutesDetailsResponseBodyMinutesDetails setSize(Long size) {
            this.size = size;
            return this;
        }
        public Long getSize() {
            return this.size;
        }

        public BatchGetMinutesDetailsResponseBodyMinutesDetails setStartTime(Long startTime) {
            this.startTime = startTime;
            return this;
        }
        public Long getStartTime() {
            return this.startTime;
        }

        public BatchGetMinutesDetailsResponseBodyMinutesDetails setStatus(Integer status) {
            this.status = status;
            return this;
        }
        public Integer getStatus() {
            return this.status;
        }

        public BatchGetMinutesDetailsResponseBodyMinutesDetails setTaskUuid(String taskUuid) {
            this.taskUuid = taskUuid;
            return this;
        }
        public String getTaskUuid() {
            return this.taskUuid;
        }

        public BatchGetMinutesDetailsResponseBodyMinutesDetails setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

    }

}
