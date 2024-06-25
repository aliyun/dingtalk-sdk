// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class BatchQueryCustomerSendTaskResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>10</p>
     */
    @NameInMap("maxResults")
    public Long maxResults;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>8888</p>
     */
    @NameInMap("nextToken")
    public String nextToken;

    @NameInMap("records")
    public java.util.List<BatchQueryCustomerSendTaskResponseBodyRecords> records;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>100</p>
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
        /**
         * <strong>example:</strong>
         * <p>张三</p>
         */
        @NameInMap("createName")
        public String createName;

        /**
         * <strong>example:</strong>
         * <p>2023-07-14 10:00:00</p>
         */
        @NameInMap("createTimeStr")
        public String createTimeStr;

        /**
         * <strong>example:</strong>
         * <p>88888</p>
         */
        @NameInMap("createUnionId")
        public String createUnionId;

        /**
         * <strong>example:</strong>
         * <p>88888</p>
         */
        @NameInMap("openBatchTaskId")
        public String openBatchTaskId;

        /**
         * <strong>example:</strong>
         * <p>90</p>
         */
        @NameInMap("readCustomerInc")
        public Long readCustomerInc;

        /**
         * <strong>example:</strong>
         * <p>100</p>
         */
        @NameInMap("readUserInc")
        public Long readUserInc;

        /**
         * <strong>example:</strong>
         * <p>100</p>
         */
        @NameInMap("sendCustomerInc")
        public Long sendCustomerInc;

        /**
         * <strong>example:</strong>
         * <p>UNFINISH 未完成 FINISHED 已发送 CANCELED 已取消 CREATE_TASK_FAILED 创建任务失败  SENDING 发送中</p>
         */
        @NameInMap("sendMessageStatus")
        public String sendMessageStatus;

        /**
         * <strong>example:</strong>
         * <p>2023-07-14 11:00:00</p>
         */
        @NameInMap("sendTaskTimeStr")
        public String sendTaskTimeStr;

        /**
         * <strong>example:</strong>
         * <p>200</p>
         */
        @NameInMap("sendUserInc")
        public Long sendUserInc;

        /**
         * <strong>example:</strong>
         * <p>任务名称</p>
         */
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
