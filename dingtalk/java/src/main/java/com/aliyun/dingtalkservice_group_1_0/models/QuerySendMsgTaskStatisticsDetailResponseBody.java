// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class QuerySendMsgTaskStatisticsDetailResponseBody extends TeaModel {
    @NameInMap("maxResults")
    public Long maxResults;

    @NameInMap("nextToken")
    public String nextToken;

    @NameInMap("records")
    public java.util.List<QuerySendMsgTaskStatisticsDetailResponseBodyRecords> records;

    /**
     * <p>Id of the request</p>
     */
    @NameInMap("totalCount")
    public Long totalCount;

    public static QuerySendMsgTaskStatisticsDetailResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QuerySendMsgTaskStatisticsDetailResponseBody self = new QuerySendMsgTaskStatisticsDetailResponseBody();
        return TeaModel.build(map, self);
    }

    public QuerySendMsgTaskStatisticsDetailResponseBody setMaxResults(Long maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Long getMaxResults() {
        return this.maxResults;
    }

    public QuerySendMsgTaskStatisticsDetailResponseBody setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public QuerySendMsgTaskStatisticsDetailResponseBody setRecords(java.util.List<QuerySendMsgTaskStatisticsDetailResponseBodyRecords> records) {
        this.records = records;
        return this;
    }
    public java.util.List<QuerySendMsgTaskStatisticsDetailResponseBodyRecords> getRecords() {
        return this.records;
    }

    public QuerySendMsgTaskStatisticsDetailResponseBody setTotalCount(Long totalCount) {
        this.totalCount = totalCount;
        return this;
    }
    public Long getTotalCount() {
        return this.totalCount;
    }

    public static class QuerySendMsgTaskStatisticsDetailResponseBodyRecords extends TeaModel {
        @NameInMap("openBatchTaskId")
        public String openBatchTaskId;

        @NameInMap("openConversationId")
        public String openConversationId;

        @NameInMap("readStatus")
        public Long readStatus;

        @NameInMap("readTimeStr")
        public String readTimeStr;

        @NameInMap("receiverName")
        public String receiverName;

        @NameInMap("receiverUnionId")
        public String receiverUnionId;

        public static QuerySendMsgTaskStatisticsDetailResponseBodyRecords build(java.util.Map<String, ?> map) throws Exception {
            QuerySendMsgTaskStatisticsDetailResponseBodyRecords self = new QuerySendMsgTaskStatisticsDetailResponseBodyRecords();
            return TeaModel.build(map, self);
        }

        public QuerySendMsgTaskStatisticsDetailResponseBodyRecords setOpenBatchTaskId(String openBatchTaskId) {
            this.openBatchTaskId = openBatchTaskId;
            return this;
        }
        public String getOpenBatchTaskId() {
            return this.openBatchTaskId;
        }

        public QuerySendMsgTaskStatisticsDetailResponseBodyRecords setOpenConversationId(String openConversationId) {
            this.openConversationId = openConversationId;
            return this;
        }
        public String getOpenConversationId() {
            return this.openConversationId;
        }

        public QuerySendMsgTaskStatisticsDetailResponseBodyRecords setReadStatus(Long readStatus) {
            this.readStatus = readStatus;
            return this;
        }
        public Long getReadStatus() {
            return this.readStatus;
        }

        public QuerySendMsgTaskStatisticsDetailResponseBodyRecords setReadTimeStr(String readTimeStr) {
            this.readTimeStr = readTimeStr;
            return this;
        }
        public String getReadTimeStr() {
            return this.readTimeStr;
        }

        public QuerySendMsgTaskStatisticsDetailResponseBodyRecords setReceiverName(String receiverName) {
            this.receiverName = receiverName;
            return this;
        }
        public String getReceiverName() {
            return this.receiverName;
        }

        public QuerySendMsgTaskStatisticsDetailResponseBodyRecords setReceiverUnionId(String receiverUnionId) {
            this.receiverUnionId = receiverUnionId;
            return this;
        }
        public String getReceiverUnionId() {
            return this.receiverUnionId;
        }

    }

}
