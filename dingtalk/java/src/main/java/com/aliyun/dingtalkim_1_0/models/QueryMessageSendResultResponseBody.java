// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class QueryMessageSendResultResponseBody extends TeaModel {
    @NameInMap("result")
    public QueryMessageSendResultResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static QueryMessageSendResultResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryMessageSendResultResponseBody self = new QueryMessageSendResultResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryMessageSendResultResponseBody setResult(QueryMessageSendResultResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public QueryMessageSendResultResponseBodyResult getResult() {
        return this.result;
    }

    public QueryMessageSendResultResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class QueryMessageSendResultResponseBodyResult extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>msghcuh234</p>
         */
        @NameInMap("openMessageId")
        public String openMessageId;

        /**
         * <strong>example:</strong>
         * <p>1</p>
         */
        @NameInMap("sendStatus")
        public Integer sendStatus;

        public static QueryMessageSendResultResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            QueryMessageSendResultResponseBodyResult self = new QueryMessageSendResultResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public QueryMessageSendResultResponseBodyResult setOpenMessageId(String openMessageId) {
            this.openMessageId = openMessageId;
            return this;
        }
        public String getOpenMessageId() {
            return this.openMessageId;
        }

        public QueryMessageSendResultResponseBodyResult setSendStatus(Integer sendStatus) {
            this.sendStatus = sendStatus;
            return this;
        }
        public Integer getSendStatus() {
            return this.sendStatus;
        }

    }

}
