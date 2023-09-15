// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class SendIsvCardMessageResponseBody extends TeaModel {
    @NameInMap("errorCode")
    public String errorCode;

    @NameInMap("errorMsg")
    public String errorMsg;

    @NameInMap("hrmInteractiveCardSendResult")
    public SendIsvCardMessageResponseBodyHrmInteractiveCardSendResult hrmInteractiveCardSendResult;

    @NameInMap("requestId")
    public String requestId;

    @NameInMap("success")
    public Boolean success;

    public static SendIsvCardMessageResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SendIsvCardMessageResponseBody self = new SendIsvCardMessageResponseBody();
        return TeaModel.build(map, self);
    }

    public SendIsvCardMessageResponseBody setErrorCode(String errorCode) {
        this.errorCode = errorCode;
        return this;
    }
    public String getErrorCode() {
        return this.errorCode;
    }

    public SendIsvCardMessageResponseBody setErrorMsg(String errorMsg) {
        this.errorMsg = errorMsg;
        return this;
    }
    public String getErrorMsg() {
        return this.errorMsg;
    }

    public SendIsvCardMessageResponseBody setHrmInteractiveCardSendResult(SendIsvCardMessageResponseBodyHrmInteractiveCardSendResult hrmInteractiveCardSendResult) {
        this.hrmInteractiveCardSendResult = hrmInteractiveCardSendResult;
        return this;
    }
    public SendIsvCardMessageResponseBodyHrmInteractiveCardSendResult getHrmInteractiveCardSendResult() {
        return this.hrmInteractiveCardSendResult;
    }

    public SendIsvCardMessageResponseBody setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public SendIsvCardMessageResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class SendIsvCardMessageResponseBodyHrmInteractiveCardSendResult extends TeaModel {
        @NameInMap("bizId")
        public String bizId;

        @NameInMap("errorCode")
        public String errorCode;

        @NameInMap("errorMsg")
        public String errorMsg;

        public static SendIsvCardMessageResponseBodyHrmInteractiveCardSendResult build(java.util.Map<String, ?> map) throws Exception {
            SendIsvCardMessageResponseBodyHrmInteractiveCardSendResult self = new SendIsvCardMessageResponseBodyHrmInteractiveCardSendResult();
            return TeaModel.build(map, self);
        }

        public SendIsvCardMessageResponseBodyHrmInteractiveCardSendResult setBizId(String bizId) {
            this.bizId = bizId;
            return this;
        }
        public String getBizId() {
            return this.bizId;
        }

        public SendIsvCardMessageResponseBodyHrmInteractiveCardSendResult setErrorCode(String errorCode) {
            this.errorCode = errorCode;
            return this;
        }
        public String getErrorCode() {
            return this.errorCode;
        }

        public SendIsvCardMessageResponseBodyHrmInteractiveCardSendResult setErrorMsg(String errorMsg) {
            this.errorMsg = errorMsg;
            return this;
        }
        public String getErrorMsg() {
            return this.errorMsg;
        }

    }

}
