// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class QueryServiceGroupMessageReadStatusResponseBody extends TeaModel {
    @NameInMap("maxResults")
    public Integer maxResults;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("nextToken")
    public String nextToken;

    @NameInMap("records")
    public java.util.List<QueryServiceGroupMessageReadStatusResponseBodyRecords> records;

    @NameInMap("totalCount")
    public Integer totalCount;

    public static QueryServiceGroupMessageReadStatusResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryServiceGroupMessageReadStatusResponseBody self = new QueryServiceGroupMessageReadStatusResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryServiceGroupMessageReadStatusResponseBody setMaxResults(Integer maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Integer getMaxResults() {
        return this.maxResults;
    }

    public QueryServiceGroupMessageReadStatusResponseBody setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public QueryServiceGroupMessageReadStatusResponseBody setRecords(java.util.List<QueryServiceGroupMessageReadStatusResponseBodyRecords> records) {
        this.records = records;
        return this;
    }
    public java.util.List<QueryServiceGroupMessageReadStatusResponseBodyRecords> getRecords() {
        return this.records;
    }

    public QueryServiceGroupMessageReadStatusResponseBody setTotalCount(Integer totalCount) {
        this.totalCount = totalCount;
        return this;
    }
    public Integer getTotalCount() {
        return this.totalCount;
    }

    public static class QueryServiceGroupMessageReadStatusResponseBodyRecords extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>1</p>
         */
        @NameInMap("readStatus")
        public Integer readStatus;

        /**
         * <strong>example:</strong>
         * <p>2021-09-01 00:00:00</p>
         */
        @NameInMap("readTimeStr")
        public String readTimeStr;

        /**
         * <strong>example:</strong>
         * <p>$:LWCP_v1:xxxx==</p>
         */
        @NameInMap("receiverDingTalkId")
        public String receiverDingTalkId;

        /**
         * <strong>example:</strong>
         * <p>张三</p>
         */
        @NameInMap("receiverName")
        public String receiverName;

        /**
         * <strong>example:</strong>
         * <p>Kxiwk2</p>
         */
        @NameInMap("receiverUnionId")
        public String receiverUnionId;

        /**
         * <strong>example:</strong>
         * <p>manager123</p>
         */
        @NameInMap("receiverUserId")
        public String receiverUserId;

        /**
         * <strong>example:</strong>
         * <p>2021-09-01 00:00:00</p>
         */
        @NameInMap("sendTimeStr")
        public String sendTimeStr;

        public static QueryServiceGroupMessageReadStatusResponseBodyRecords build(java.util.Map<String, ?> map) throws Exception {
            QueryServiceGroupMessageReadStatusResponseBodyRecords self = new QueryServiceGroupMessageReadStatusResponseBodyRecords();
            return TeaModel.build(map, self);
        }

        public QueryServiceGroupMessageReadStatusResponseBodyRecords setReadStatus(Integer readStatus) {
            this.readStatus = readStatus;
            return this;
        }
        public Integer getReadStatus() {
            return this.readStatus;
        }

        public QueryServiceGroupMessageReadStatusResponseBodyRecords setReadTimeStr(String readTimeStr) {
            this.readTimeStr = readTimeStr;
            return this;
        }
        public String getReadTimeStr() {
            return this.readTimeStr;
        }

        public QueryServiceGroupMessageReadStatusResponseBodyRecords setReceiverDingTalkId(String receiverDingTalkId) {
            this.receiverDingTalkId = receiverDingTalkId;
            return this;
        }
        public String getReceiverDingTalkId() {
            return this.receiverDingTalkId;
        }

        public QueryServiceGroupMessageReadStatusResponseBodyRecords setReceiverName(String receiverName) {
            this.receiverName = receiverName;
            return this;
        }
        public String getReceiverName() {
            return this.receiverName;
        }

        public QueryServiceGroupMessageReadStatusResponseBodyRecords setReceiverUnionId(String receiverUnionId) {
            this.receiverUnionId = receiverUnionId;
            return this;
        }
        public String getReceiverUnionId() {
            return this.receiverUnionId;
        }

        public QueryServiceGroupMessageReadStatusResponseBodyRecords setReceiverUserId(String receiverUserId) {
            this.receiverUserId = receiverUserId;
            return this;
        }
        public String getReceiverUserId() {
            return this.receiverUserId;
        }

        public QueryServiceGroupMessageReadStatusResponseBodyRecords setSendTimeStr(String sendTimeStr) {
            this.sendTimeStr = sendTimeStr;
            return this;
        }
        public String getSendTimeStr() {
            return this.sendTimeStr;
        }

    }

}
