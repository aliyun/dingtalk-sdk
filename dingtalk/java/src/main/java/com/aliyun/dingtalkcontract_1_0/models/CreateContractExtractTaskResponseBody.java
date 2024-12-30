// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontract_1_0.models;

import com.aliyun.tea.*;

public class CreateContractExtractTaskResponseBody extends TeaModel {
    @NameInMap("result")
    public CreateContractExtractTaskResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static CreateContractExtractTaskResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CreateContractExtractTaskResponseBody self = new CreateContractExtractTaskResponseBody();
        return TeaModel.build(map, self);
    }

    public CreateContractExtractTaskResponseBody setResult(CreateContractExtractTaskResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public CreateContractExtractTaskResponseBodyResult getResult() {
        return this.result;
    }

    public CreateContractExtractTaskResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class CreateContractExtractTaskResponseBodyResultData extends TeaModel {
        @NameInMap("extractTaskId")
        public String extractTaskId;

        public static CreateContractExtractTaskResponseBodyResultData build(java.util.Map<String, ?> map) throws Exception {
            CreateContractExtractTaskResponseBodyResultData self = new CreateContractExtractTaskResponseBodyResultData();
            return TeaModel.build(map, self);
        }

        public CreateContractExtractTaskResponseBodyResultData setExtractTaskId(String extractTaskId) {
            this.extractTaskId = extractTaskId;
            return this;
        }
        public String getExtractTaskId() {
            return this.extractTaskId;
        }

    }

    public static class CreateContractExtractTaskResponseBodyResult extends TeaModel {
        @NameInMap("data")
        public CreateContractExtractTaskResponseBodyResultData data;

        @NameInMap("requestId")
        public String requestId;

        public static CreateContractExtractTaskResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            CreateContractExtractTaskResponseBodyResult self = new CreateContractExtractTaskResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public CreateContractExtractTaskResponseBodyResult setData(CreateContractExtractTaskResponseBodyResultData data) {
            this.data = data;
            return this;
        }
        public CreateContractExtractTaskResponseBodyResultData getData() {
            return this.data;
        }

        public CreateContractExtractTaskResponseBodyResult setRequestId(String requestId) {
            this.requestId = requestId;
            return this;
        }
        public String getRequestId() {
            return this.requestId;
        }

    }

}
