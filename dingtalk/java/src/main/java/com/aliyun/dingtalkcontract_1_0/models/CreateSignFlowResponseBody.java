// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontract_1_0.models;

import com.aliyun.tea.*;

public class CreateSignFlowResponseBody extends TeaModel {
    @NameInMap("result")
    public CreateSignFlowResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static CreateSignFlowResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CreateSignFlowResponseBody self = new CreateSignFlowResponseBody();
        return TeaModel.build(map, self);
    }

    public CreateSignFlowResponseBody setResult(CreateSignFlowResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public CreateSignFlowResponseBodyResult getResult() {
        return this.result;
    }

    public CreateSignFlowResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class CreateSignFlowResponseBodyResultData extends TeaModel {
        @NameInMap("autoStartErrorMsg")
        public String autoStartErrorMsg;

        @NameInMap("bizFlowId")
        public String bizFlowId;

        @NameInMap("initiateUrl")
        public String initiateUrl;

        @NameInMap("signFlowId")
        public String signFlowId;

        @NameInMap("signFlowStatus")
        public String signFlowStatus;

        public static CreateSignFlowResponseBodyResultData build(java.util.Map<String, ?> map) throws Exception {
            CreateSignFlowResponseBodyResultData self = new CreateSignFlowResponseBodyResultData();
            return TeaModel.build(map, self);
        }

        public CreateSignFlowResponseBodyResultData setAutoStartErrorMsg(String autoStartErrorMsg) {
            this.autoStartErrorMsg = autoStartErrorMsg;
            return this;
        }
        public String getAutoStartErrorMsg() {
            return this.autoStartErrorMsg;
        }

        public CreateSignFlowResponseBodyResultData setBizFlowId(String bizFlowId) {
            this.bizFlowId = bizFlowId;
            return this;
        }
        public String getBizFlowId() {
            return this.bizFlowId;
        }

        public CreateSignFlowResponseBodyResultData setInitiateUrl(String initiateUrl) {
            this.initiateUrl = initiateUrl;
            return this;
        }
        public String getInitiateUrl() {
            return this.initiateUrl;
        }

        public CreateSignFlowResponseBodyResultData setSignFlowId(String signFlowId) {
            this.signFlowId = signFlowId;
            return this;
        }
        public String getSignFlowId() {
            return this.signFlowId;
        }

        public CreateSignFlowResponseBodyResultData setSignFlowStatus(String signFlowStatus) {
            this.signFlowStatus = signFlowStatus;
            return this;
        }
        public String getSignFlowStatus() {
            return this.signFlowStatus;
        }

    }

    public static class CreateSignFlowResponseBodyResult extends TeaModel {
        @NameInMap("data")
        public CreateSignFlowResponseBodyResultData data;

        @NameInMap("requestId")
        public String requestId;

        public static CreateSignFlowResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            CreateSignFlowResponseBodyResult self = new CreateSignFlowResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public CreateSignFlowResponseBodyResult setData(CreateSignFlowResponseBodyResultData data) {
            this.data = data;
            return this;
        }
        public CreateSignFlowResponseBodyResultData getData() {
            return this.data;
        }

        public CreateSignFlowResponseBodyResult setRequestId(String requestId) {
            this.requestId = requestId;
            return this;
        }
        public String getRequestId() {
            return this.requestId;
        }

    }

}
