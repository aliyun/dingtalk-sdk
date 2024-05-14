// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkimpaas_1_0.models;

import com.aliyun.tea.*;

public class QueryBatchSendResultResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("results")
    public java.util.List<QueryBatchSendResultResponseBodyResults> results;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("status")
    public Integer status;

    public static QueryBatchSendResultResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryBatchSendResultResponseBody self = new QueryBatchSendResultResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryBatchSendResultResponseBody setResults(java.util.List<QueryBatchSendResultResponseBodyResults> results) {
        this.results = results;
        return this;
    }
    public java.util.List<QueryBatchSendResultResponseBodyResults> getResults() {
        return this.results;
    }

    public QueryBatchSendResultResponseBody setStatus(Integer status) {
        this.status = status;
        return this;
    }
    public Integer getStatus() {
        return this.status;
    }

    public static class QueryBatchSendResultResponseBodyResults extends TeaModel {
        @NameInMap("appUid")
        public String appUid;

        @NameInMap("conversationId")
        public String conversationId;

        @NameInMap("errorCode")
        public String errorCode;

        @NameInMap("errorMessage")
        public String errorMessage;

        @NameInMap("msgId")
        public String msgId;

        public static QueryBatchSendResultResponseBodyResults build(java.util.Map<String, ?> map) throws Exception {
            QueryBatchSendResultResponseBodyResults self = new QueryBatchSendResultResponseBodyResults();
            return TeaModel.build(map, self);
        }

        public QueryBatchSendResultResponseBodyResults setAppUid(String appUid) {
            this.appUid = appUid;
            return this;
        }
        public String getAppUid() {
            return this.appUid;
        }

        public QueryBatchSendResultResponseBodyResults setConversationId(String conversationId) {
            this.conversationId = conversationId;
            return this;
        }
        public String getConversationId() {
            return this.conversationId;
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

        public QueryBatchSendResultResponseBodyResults setMsgId(String msgId) {
            this.msgId = msgId;
            return this;
        }
        public String getMsgId() {
            return this.msgId;
        }

    }

}
