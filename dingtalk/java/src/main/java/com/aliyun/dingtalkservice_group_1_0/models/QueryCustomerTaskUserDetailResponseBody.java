// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class QueryCustomerTaskUserDetailResponseBody extends TeaModel {
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
    public java.util.List<QueryCustomerTaskUserDetailResponseBodyRecords> records;

    @NameInMap("totalCount")
    public Long totalCount;

    public static QueryCustomerTaskUserDetailResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryCustomerTaskUserDetailResponseBody self = new QueryCustomerTaskUserDetailResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryCustomerTaskUserDetailResponseBody setMaxResults(Long maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Long getMaxResults() {
        return this.maxResults;
    }

    public QueryCustomerTaskUserDetailResponseBody setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public QueryCustomerTaskUserDetailResponseBody setRecords(java.util.List<QueryCustomerTaskUserDetailResponseBodyRecords> records) {
        this.records = records;
        return this;
    }
    public java.util.List<QueryCustomerTaskUserDetailResponseBodyRecords> getRecords() {
        return this.records;
    }

    public QueryCustomerTaskUserDetailResponseBody setTotalCount(Long totalCount) {
        this.totalCount = totalCount;
        return this;
    }
    public Long getTotalCount() {
        return this.totalCount;
    }

    public static class QueryCustomerTaskUserDetailResponseBodyRecordsEventTrackResponses extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>2023-07-14 00:00:00</p>
         */
        @NameInMap("clickTime")
        public String clickTime;

        /**
         * <strong>example:</strong>
         * <p>88888</p>
         */
        @NameInMap("eventTrackId")
        public String eventTrackId;

        /**
         * <strong>example:</strong>
         * <p>true</p>
         */
        @NameInMap("onClick")
        public Boolean onClick;

        /**
         * <strong>example:</strong>
         * <p>标题名称</p>
         */
        @NameInMap("title")
        public String title;

        public static QueryCustomerTaskUserDetailResponseBodyRecordsEventTrackResponses build(java.util.Map<String, ?> map) throws Exception {
            QueryCustomerTaskUserDetailResponseBodyRecordsEventTrackResponses self = new QueryCustomerTaskUserDetailResponseBodyRecordsEventTrackResponses();
            return TeaModel.build(map, self);
        }

        public QueryCustomerTaskUserDetailResponseBodyRecordsEventTrackResponses setClickTime(String clickTime) {
            this.clickTime = clickTime;
            return this;
        }
        public String getClickTime() {
            return this.clickTime;
        }

        public QueryCustomerTaskUserDetailResponseBodyRecordsEventTrackResponses setEventTrackId(String eventTrackId) {
            this.eventTrackId = eventTrackId;
            return this;
        }
        public String getEventTrackId() {
            return this.eventTrackId;
        }

        public QueryCustomerTaskUserDetailResponseBodyRecordsEventTrackResponses setOnClick(Boolean onClick) {
            this.onClick = onClick;
            return this;
        }
        public Boolean getOnClick() {
            return this.onClick;
        }

        public QueryCustomerTaskUserDetailResponseBodyRecordsEventTrackResponses setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

    }

    public static class QueryCustomerTaskUserDetailResponseBodyRecords extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>客户名称</p>
         */
        @NameInMap("customerNames")
        public String customerNames;

        /**
         * <strong>example:</strong>
         * <p>11111</p>
         */
        @NameInMap("errorCode")
        public String errorCode;

        /**
         * <strong>example:</strong>
         * <p>错误信息</p>
         */
        @NameInMap("errorDetail")
        public String errorDetail;

        @NameInMap("eventTrackResponses")
        public java.util.List<QueryCustomerTaskUserDetailResponseBodyRecordsEventTrackResponses> eventTrackResponses;

        /**
         * <strong>example:</strong>
         * <p>8888</p>
         */
        @NameInMap("openBatchTaskId")
        public String openBatchTaskId;

        /**
         * <strong>example:</strong>
         * <p>1</p>
         */
        @NameInMap("readStatus")
        public Long readStatus;

        /**
         * <strong>example:</strong>
         * <p>2023-07-14 00:00:00</p>
         */
        @NameInMap("readTime")
        public String readTime;

        /**
         * <strong>example:</strong>
         * <p>接收人姓名</p>
         */
        @NameInMap("receiverName")
        public String receiverName;

        /**
         * <strong>example:</strong>
         * <p>接收人ID</p>
         */
        @NameInMap("receiverUnionId")
        public String receiverUnionId;

        /**
         * <strong>example:</strong>
         * <p>2023-07-14 00:00:00</p>
         */
        @NameInMap("sendTime")
        public String sendTime;

        /**
         * <strong>example:</strong>
         * <p>UNSEND未发；SEND_SUCCESS成功；SEND_FAILED失败；EXCEED_LIMIT被限流</p>
         */
        @NameInMap("status")
        public String status;

        public static QueryCustomerTaskUserDetailResponseBodyRecords build(java.util.Map<String, ?> map) throws Exception {
            QueryCustomerTaskUserDetailResponseBodyRecords self = new QueryCustomerTaskUserDetailResponseBodyRecords();
            return TeaModel.build(map, self);
        }

        public QueryCustomerTaskUserDetailResponseBodyRecords setCustomerNames(String customerNames) {
            this.customerNames = customerNames;
            return this;
        }
        public String getCustomerNames() {
            return this.customerNames;
        }

        public QueryCustomerTaskUserDetailResponseBodyRecords setErrorCode(String errorCode) {
            this.errorCode = errorCode;
            return this;
        }
        public String getErrorCode() {
            return this.errorCode;
        }

        public QueryCustomerTaskUserDetailResponseBodyRecords setErrorDetail(String errorDetail) {
            this.errorDetail = errorDetail;
            return this;
        }
        public String getErrorDetail() {
            return this.errorDetail;
        }

        public QueryCustomerTaskUserDetailResponseBodyRecords setEventTrackResponses(java.util.List<QueryCustomerTaskUserDetailResponseBodyRecordsEventTrackResponses> eventTrackResponses) {
            this.eventTrackResponses = eventTrackResponses;
            return this;
        }
        public java.util.List<QueryCustomerTaskUserDetailResponseBodyRecordsEventTrackResponses> getEventTrackResponses() {
            return this.eventTrackResponses;
        }

        public QueryCustomerTaskUserDetailResponseBodyRecords setOpenBatchTaskId(String openBatchTaskId) {
            this.openBatchTaskId = openBatchTaskId;
            return this;
        }
        public String getOpenBatchTaskId() {
            return this.openBatchTaskId;
        }

        public QueryCustomerTaskUserDetailResponseBodyRecords setReadStatus(Long readStatus) {
            this.readStatus = readStatus;
            return this;
        }
        public Long getReadStatus() {
            return this.readStatus;
        }

        public QueryCustomerTaskUserDetailResponseBodyRecords setReadTime(String readTime) {
            this.readTime = readTime;
            return this;
        }
        public String getReadTime() {
            return this.readTime;
        }

        public QueryCustomerTaskUserDetailResponseBodyRecords setReceiverName(String receiverName) {
            this.receiverName = receiverName;
            return this;
        }
        public String getReceiverName() {
            return this.receiverName;
        }

        public QueryCustomerTaskUserDetailResponseBodyRecords setReceiverUnionId(String receiverUnionId) {
            this.receiverUnionId = receiverUnionId;
            return this;
        }
        public String getReceiverUnionId() {
            return this.receiverUnionId;
        }

        public QueryCustomerTaskUserDetailResponseBodyRecords setSendTime(String sendTime) {
            this.sendTime = sendTime;
            return this;
        }
        public String getSendTime() {
            return this.sendTime;
        }

        public QueryCustomerTaskUserDetailResponseBodyRecords setStatus(String status) {
            this.status = status;
            return this;
        }
        public String getStatus() {
            return this.status;
        }

    }

}
