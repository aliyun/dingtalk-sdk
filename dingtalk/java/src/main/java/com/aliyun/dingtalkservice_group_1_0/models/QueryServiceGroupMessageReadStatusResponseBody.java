// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class QueryServiceGroupMessageReadStatusResponseBody extends TeaModel {
    /**
     * <p>本次请求所返回的最大记录条数。</p>
     */
    @NameInMap("maxResults")
    public Integer maxResults;

    /**
     * <p>表示当前调用返回读取到的位置，空代表数据已经读取完毕</p>
     */
    @NameInMap("nextToken")
    public String nextToken;

    /**
     * <p>已读未读信息列表</p>
     */
    @NameInMap("records")
    public java.util.List<QueryServiceGroupMessageReadStatusResponseBodyRecords> records;

    /**
     * <p>本次请求条件下的数据总量，此参数为可选参数，默认可不返回。本次请求条件下的数据总量，此参数为可选参数，默认可不返回</p>
     */
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
         * <p>状态：已读1/未读0</p>
         */
        @NameInMap("readStatus")
        public Integer readStatus;

        /**
         * <p>已读时间</p>
         */
        @NameInMap("readTimeStr")
        public String readTimeStr;

        /**
         * <p>接收者dingtalkId</p>
         */
        @NameInMap("receiverDingTalkId")
        public String receiverDingTalkId;

        /**
         * <p>接收者昵称</p>
         */
        @NameInMap("receiverName")
        public String receiverName;

        /**
         * <p>已读人员为非企业员工则有值</p>
         */
        @NameInMap("receiverUnionId")
        public String receiverUnionId;

        /**
         * <p>已读人员为企业员工则有值</p>
         */
        @NameInMap("receiverUserId")
        public String receiverUserId;

        /**
         * <p>发送时间</p>
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
