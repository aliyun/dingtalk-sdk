// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class QueryServiceGroupMessageReadStatusResponseBody extends TeaModel {
    // 本次请求条件下的数据总量，此参数为可选参数，默认可不返回。本次请求条件下的数据总量，此参数为可选参数，默认可不返回
    @NameInMap("totalCount")
    public Integer totalCount;

    // 表示当前调用返回读取到的位置，空代表数据已经读取完毕
    @NameInMap("nextToken")
    public String nextToken;

    // 本次请求所返回的最大记录条数。
    @NameInMap("maxResults")
    public Integer maxResults;

    // 已读未读信息列表
    @NameInMap("records")
    public java.util.List<QueryServiceGroupMessageReadStatusResponseBodyRecords> records;

    public static QueryServiceGroupMessageReadStatusResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryServiceGroupMessageReadStatusResponseBody self = new QueryServiceGroupMessageReadStatusResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryServiceGroupMessageReadStatusResponseBody setTotalCount(Integer totalCount) {
        this.totalCount = totalCount;
        return this;
    }
    public Integer getTotalCount() {
        return this.totalCount;
    }

    public QueryServiceGroupMessageReadStatusResponseBody setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public QueryServiceGroupMessageReadStatusResponseBody setMaxResults(Integer maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Integer getMaxResults() {
        return this.maxResults;
    }

    public QueryServiceGroupMessageReadStatusResponseBody setRecords(java.util.List<QueryServiceGroupMessageReadStatusResponseBodyRecords> records) {
        this.records = records;
        return this;
    }
    public java.util.List<QueryServiceGroupMessageReadStatusResponseBodyRecords> getRecords() {
        return this.records;
    }

    public static class QueryServiceGroupMessageReadStatusResponseBodyRecords extends TeaModel {
        // 已读人员为企业员工则有值
        @NameInMap("receiverUserId")
        public String receiverUserId;

        // 已读人员为非企业员工则有值
        @NameInMap("receiverUnionId")
        public String receiverUnionId;

        // 状态：已读1/未读0
        @NameInMap("readStatus")
        public Integer readStatus;

        // 接收者昵称
        @NameInMap("receiverName")
        public String receiverName;

        // 接收者dingtalkId
        @NameInMap("receiverDingTalkId")
        public String receiverDingTalkId;

        // 发送时间
        @NameInMap("sendTimeStr")
        public String sendTimeStr;

        // 已读时间
        @NameInMap("readTimeStr")
        public String readTimeStr;

        public static QueryServiceGroupMessageReadStatusResponseBodyRecords build(java.util.Map<String, ?> map) throws Exception {
            QueryServiceGroupMessageReadStatusResponseBodyRecords self = new QueryServiceGroupMessageReadStatusResponseBodyRecords();
            return TeaModel.build(map, self);
        }

        public QueryServiceGroupMessageReadStatusResponseBodyRecords setReceiverUserId(String receiverUserId) {
            this.receiverUserId = receiverUserId;
            return this;
        }
        public String getReceiverUserId() {
            return this.receiverUserId;
        }

        public QueryServiceGroupMessageReadStatusResponseBodyRecords setReceiverUnionId(String receiverUnionId) {
            this.receiverUnionId = receiverUnionId;
            return this;
        }
        public String getReceiverUnionId() {
            return this.receiverUnionId;
        }

        public QueryServiceGroupMessageReadStatusResponseBodyRecords setReadStatus(Integer readStatus) {
            this.readStatus = readStatus;
            return this;
        }
        public Integer getReadStatus() {
            return this.readStatus;
        }

        public QueryServiceGroupMessageReadStatusResponseBodyRecords setReceiverName(String receiverName) {
            this.receiverName = receiverName;
            return this;
        }
        public String getReceiverName() {
            return this.receiverName;
        }

        public QueryServiceGroupMessageReadStatusResponseBodyRecords setReceiverDingTalkId(String receiverDingTalkId) {
            this.receiverDingTalkId = receiverDingTalkId;
            return this;
        }
        public String getReceiverDingTalkId() {
            return this.receiverDingTalkId;
        }

        public QueryServiceGroupMessageReadStatusResponseBodyRecords setSendTimeStr(String sendTimeStr) {
            this.sendTimeStr = sendTimeStr;
            return this;
        }
        public String getSendTimeStr() {
            return this.sendTimeStr;
        }

        public QueryServiceGroupMessageReadStatusResponseBodyRecords setReadTimeStr(String readTimeStr) {
            this.readTimeStr = readTimeStr;
            return this;
        }
        public String getReadTimeStr() {
            return this.readTimeStr;
        }

    }

}
