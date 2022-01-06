// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkimpaas_1_0.models;

import com.aliyun.tea.*;

public class QueryBatchSendResultResponseBody extends TeaModel {
    // status
    @NameInMap("status")
    public Integer status;

    @NameInMap("results")
    public java.util.List<QueryBatchSendResultResponseBodyResults> results;

    public static QueryBatchSendResultResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryBatchSendResultResponseBody self = new QueryBatchSendResultResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryBatchSendResultResponseBody setStatus(Integer status) {
        this.status = status;
        return this;
    }
    public Integer getStatus() {
        return this.status;
    }

    public QueryBatchSendResultResponseBody setResults(java.util.List<QueryBatchSendResultResponseBodyResults> results) {
        this.results = results;
        return this;
    }
    public java.util.List<QueryBatchSendResultResponseBodyResults> getResults() {
        return this.results;
    }

    public static class QueryBatchSendResultResponseBodyResults extends TeaModel {
        @NameInMap("conversationId")
        public String conversationId;

        @NameInMap("appUid")
        public String appUid;

        @NameInMap("msgId")
        public String msgId;

        @NameInMap("errorCode")
        public String errorCode;

        @NameInMap("errorMessage")
        public String errorMessage;

        public static QueryBatchSendResultResponseBodyResults build(java.util.Map<String, ?> map) throws Exception {
            QueryBatchSendResultResponseBodyResults self = new QueryBatchSendResultResponseBodyResults();
            return TeaModel.build(map, self);
        }

        public QueryBatchSendResultResponseBodyResults setConversationId(String conversationId) {
            this.conversationId = conversationId;
            return this;
        }
        public String getConversationId() {
            return this.conversationId;
        }

        public QueryBatchSendResultResponseBodyResults setAppUid(String appUid) {
            this.appUid = appUid;
            return this;
        }
        public String getAppUid() {
            return this.appUid;
        }

        public QueryBatchSendResultResponseBodyResults setMsgId(String msgId) {
            this.msgId = msgId;
            return this;
        }
        public String getMsgId() {
            return this.msgId;
        }

        public QueryBatchSendResultResponseBodyResults setErrorCode(String errorCode) {
            this.errorCode = errorCode;
            return this;
        }
        public String getErrorCode() {
            return this.errorCode;
        }

        public QueryBatchSendResultResponseBodyResults setErrorMessage(String errorMessage) {
            this.errorMessage = errorMessage;
            return this;
        }
        public String getErrorMessage() {
            return this.errorMessage;
        }

    }

}
