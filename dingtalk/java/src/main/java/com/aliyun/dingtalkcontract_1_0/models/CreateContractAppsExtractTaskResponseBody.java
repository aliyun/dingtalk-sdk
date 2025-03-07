// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontract_1_0.models;

import com.aliyun.tea.*;

public class CreateContractAppsExtractTaskResponseBody extends TeaModel {
    @NameInMap("result")
    public CreateContractAppsExtractTaskResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static CreateContractAppsExtractTaskResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CreateContractAppsExtractTaskResponseBody self = new CreateContractAppsExtractTaskResponseBody();
        return TeaModel.build(map, self);
    }

    public CreateContractAppsExtractTaskResponseBody setResult(CreateContractAppsExtractTaskResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public CreateContractAppsExtractTaskResponseBodyResult getResult() {
        return this.result;
    }

    public CreateContractAppsExtractTaskResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class CreateContractAppsExtractTaskResponseBodyResultData extends TeaModel {
        @NameInMap("extractTaskId")
        public String extractTaskId;

        public static CreateContractAppsExtractTaskResponseBodyResultData build(java.util.Map<String, ?> map) throws Exception {
            CreateContractAppsExtractTaskResponseBodyResultData self = new CreateContractAppsExtractTaskResponseBodyResultData();
            return TeaModel.build(map, self);
        }

        public CreateContractAppsExtractTaskResponseBodyResultData setExtractTaskId(String extractTaskId) {
            this.extractTaskId = extractTaskId;
            return this;
        }
        public String getExtractTaskId() {
            return this.extractTaskId;
        }

    }

    public static class CreateContractAppsExtractTaskResponseBodyResult extends TeaModel {
        @NameInMap("data")
        public CreateContractAppsExtractTaskResponseBodyResultData data;

        @NameInMap("requestId")
        public String requestId;

        public static CreateContractAppsExtractTaskResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            CreateContractAppsExtractTaskResponseBodyResult self = new CreateContractAppsExtractTaskResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public CreateContractAppsExtractTaskResponseBodyResult setData(CreateContractAppsExtractTaskResponseBodyResultData data) {
            this.data = data;
            return this;
        }
        public CreateContractAppsExtractTaskResponseBodyResultData getData() {
            return this.data;
        }

        public CreateContractAppsExtractTaskResponseBodyResult setRequestId(String requestId) {
            this.requestId = requestId;
            return this;
        }
        public String getRequestId() {
            return this.requestId;
        }

    }

}
