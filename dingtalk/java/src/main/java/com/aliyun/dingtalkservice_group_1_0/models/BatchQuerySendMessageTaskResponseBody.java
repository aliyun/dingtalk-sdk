// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class BatchQuerySendMessageTaskResponseBody extends TeaModel {
    @NameInMap("maxResults")
    public Long maxResults;

    /**
     * <p>Id of the request</p>
     */
    @NameInMap("nextToken")
    public String nextToken;

    @NameInMap("records")
    public java.util.List<BatchQuerySendMessageTaskResponseBodyRecords> records;

    @NameInMap("totalCount")
    public Float totalCount;

    public static BatchQuerySendMessageTaskResponseBody build(java.util.Map<String, ?> map) throws Exception {
        BatchQuerySendMessageTaskResponseBody self = new BatchQuerySendMessageTaskResponseBody();
        return TeaModel.build(map, self);
    }

    public BatchQuerySendMessageTaskResponseBody setMaxResults(Long maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Long getMaxResults() {
        return this.maxResults;
    }

    public BatchQuerySendMessageTaskResponseBody setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public BatchQuerySendMessageTaskResponseBody setRecords(java.util.List<BatchQuerySendMessageTaskResponseBodyRecords> records) {
        this.records = records;
        return this;
    }
    public java.util.List<BatchQuerySendMessageTaskResponseBodyRecords> getRecords() {
        return this.records;
    }

    public BatchQuerySendMessageTaskResponseBody setTotalCount(Float totalCount) {
        this.totalCount = totalCount;
        return this;
    }
    public Float getTotalCount() {
        return this.totalCount;
    }

    public static class BatchQuerySendMessageTaskResponseBodyRecords extends TeaModel {
        @NameInMap("createName")
        public String createName;

        @NameInMap("createTimeStr")
        public String createTimeStr;

        @NameInMap("createUnionId")
        public String createUnionId;

        @NameInMap("openBatchTaskId")
        public String openBatchTaskId;

        @NameInMap("readGroupInc")
        public Long readGroupInc;

        @NameInMap("sendGroupInc")
        public Long sendGroupInc;

        @NameInMap("sendMessageStatus")
        public String sendMessageStatus;

        @NameInMap("sendTaskTimeStr")
        public String sendTaskTimeStr;

        @NameInMap("taskName")
        public String taskName;

        public static BatchQuerySendMessageTaskResponseBodyRecords build(java.util.Map<String, ?> map) throws Exception {
            BatchQuerySendMessageTaskResponseBodyRecords self = new BatchQuerySendMessageTaskResponseBodyRecords();
            return TeaModel.build(map, self);
        }

        public BatchQuerySendMessageTaskResponseBodyRecords setCreateName(String createName) {
            this.createName = createName;
            return this;
        }
        public String getCreateName() {
            return this.createName;
        }

        public BatchQuerySendMessageTaskResponseBodyRecords setCreateTimeStr(String createTimeStr) {
            this.createTimeStr = createTimeStr;
            return this;
        }
        public String getCreateTimeStr() {
            return this.createTimeStr;
        }

        public BatchQuerySendMessageTaskResponseBodyRecords setCreateUnionId(String createUnionId) {
            this.createUnionId = createUnionId;
            return this;
        }
        public String getCreateUnionId() {
            return this.createUnionId;
        }

        public BatchQuerySendMessageTaskResponseBodyRecords setOpenBatchTaskId(String openBatchTaskId) {
            this.openBatchTaskId = openBatchTaskId;
            return this;
        }
        public String getOpenBatchTaskId() {
            return this.openBatchTaskId;
        }

        public BatchQuerySendMessageTaskResponseBodyRecords setReadGroupInc(Long readGroupInc) {
            this.readGroupInc = readGroupInc;
            return this;
        }
        public Long getReadGroupInc() {
            return this.readGroupInc;
        }

        public BatchQuerySendMessageTaskResponseBodyRecords setSendGroupInc(Long sendGroupInc) {
            this.sendGroupInc = sendGroupInc;
            return this;
        }
        public Long getSendGroupInc() {
            return this.sendGroupInc;
        }

        public BatchQuerySendMessageTaskResponseBodyRecords setSendMessageStatus(String sendMessageStatus) {
            this.sendMessageStatus = sendMessageStatus;
            return this;
        }
        public String getSendMessageStatus() {
            return this.sendMessageStatus;
        }

        public BatchQuerySendMessageTaskResponseBodyRecords setSendTaskTimeStr(String sendTaskTimeStr) {
            this.sendTaskTimeStr = sendTaskTimeStr;
            return this;
        }
        public String getSendTaskTimeStr() {
            return this.sendTaskTimeStr;
        }

        public BatchQuerySendMessageTaskResponseBodyRecords setTaskName(String taskName) {
            this.taskName = taskName;
            return this;
        }
        public String getTaskName() {
            return this.taskName;
        }

    }

}
