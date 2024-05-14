// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class BatchQueryCustomerSendTaskResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("maxResults")
    public Long maxResults;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("nextToken")
    public String nextToken;

    @NameInMap("records")
    public java.util.List<BatchQueryCustomerSendTaskResponseBodyRecords> records;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("totalCount")
    public Long totalCount;

    public static BatchQueryCustomerSendTaskResponseBody build(java.util.Map<String, ?> map) throws Exception {
        BatchQueryCustomerSendTaskResponseBody self = new BatchQueryCustomerSendTaskResponseBody();
        return TeaModel.build(map, self);
    }

    public BatchQueryCustomerSendTaskResponseBody setMaxResults(Long maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Long getMaxResults() {
        return this.maxResults;
    }

    public BatchQueryCustomerSendTaskResponseBody setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public BatchQueryCustomerSendTaskResponseBody setRecords(java.util.List<BatchQueryCustomerSendTaskResponseBodyRecords> records) {
        this.records = records;
        return this;
    }
    public java.util.List<BatchQueryCustomerSendTaskResponseBodyRecords> getRecords() {
        return this.records;
    }

    public BatchQueryCustomerSendTaskResponseBody setTotalCount(Long totalCount) {
        this.totalCount = totalCount;
        return this;
    }
    public Long getTotalCount() {
        return this.totalCount;
    }

    public static class BatchQueryCustomerSendTaskResponseBodyRecords extends TeaModel {
        @NameInMap("createName")
        public String createName;

        @NameInMap("createTimeStr")
        public String createTimeStr;

        @NameInMap("createUnionId")
        public String createUnionId;

        @NameInMap("openBatchTaskId")
        public String openBatchTaskId;

        @NameInMap("readCustomerInc")
        public Long readCustomerInc;

        @NameInMap("readUserInc")
        public Long readUserInc;

        @NameInMap("sendCustomerInc")
        public Long sendCustomerInc;

        @NameInMap("sendMessageStatus")
        public String sendMessageStatus;

        @NameInMap("sendTaskTimeStr")
        public String sendTaskTimeStr;

        @NameInMap("sendUserInc")
        public Long sendUserInc;

        @NameInMap("taskName")
        public String taskName;

        public static BatchQueryCustomerSendTaskResponseBodyRecords build(java.util.Map<String, ?> map) throws Exception {
            BatchQueryCustomerSendTaskResponseBodyRecords self = new BatchQueryCustomerSendTaskResponseBodyRecords();
            return TeaModel.build(map, self);
        }

        public BatchQueryCustomerSendTaskResponseBodyRecords setCreateName(String createName) {
            this.createName = createName;
            return this;
        }
        public String getCreateName() {
            return this.createName;
        }

        public BatchQueryCustomerSendTaskResponseBodyRecords setCreateTimeStr(String createTimeStr) {
            this.createTimeStr = createTimeStr;
            return this;
        }
        public String getCreateTimeStr() {
            return this.createTimeStr;
        }

        public BatchQueryCustomerSendTaskResponseBodyRecords setCreateUnionId(String createUnionId) {
            this.createUnionId = createUnionId;
            return this;
        }
        public String getCreateUnionId() {
            return this.createUnionId;
        }

        public BatchQueryCustomerSendTaskResponseBodyRecords setOpenBatchTaskId(String openBatchTaskId) {
            this.openBatchTaskId = openBatchTaskId;
            return this;
        }
        public String getOpenBatchTaskId() {
            return this.openBatchTaskId;
        }

        public BatchQueryCustomerSendTaskResponseBodyRecords setReadCustomerInc(Long readCustomerInc) {
            this.readCustomerInc = readCustomerInc;
            return this;
        }
        public Long getReadCustomerInc() {
            return this.readCustomerInc;
        }

        public BatchQueryCustomerSendTaskResponseBodyRecords setReadUserInc(Long readUserInc) {
            this.readUserInc = readUserInc;
            return this;
        }
        public Long getReadUserInc() {
            return this.readUserInc;
        }

        public BatchQueryCustomerSendTaskResponseBodyRecords setSendCustomerInc(Long sendCustomerInc) {
            this.sendCustomerInc = sendCustomerInc;
            return this;
        }
        public Long getSendCustomerInc() {
            return this.sendCustomerInc;
        }

        public BatchQueryCustomerSendTaskResponseBodyRecords setSendMessageStatus(String sendMessageStatus) {
            this.sendMessageStatus = sendMessageStatus;
            return this;
        }
        public String getSendMessageStatus() {
            return this.sendMessageStatus;
        }

        public BatchQueryCustomerSendTaskResponseBodyRecords setSendTaskTimeStr(String sendTaskTimeStr) {
            this.sendTaskTimeStr = sendTaskTimeStr;
            return this;
        }
        public String getSendTaskTimeStr() {
            return this.sendTaskTimeStr;
        }

        public BatchQueryCustomerSendTaskResponseBodyRecords setSendUserInc(Long sendUserInc) {
            this.sendUserInc = sendUserInc;
            return this;
        }
        public Long getSendUserInc() {
            return this.sendUserInc;
        }

        public BatchQueryCustomerSendTaskResponseBodyRecords setTaskName(String taskName) {
            this.taskName = taskName;
            return this;
        }
        public String getTaskName() {
            return this.taskName;
        }

    }

}
