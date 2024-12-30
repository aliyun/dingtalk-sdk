// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontract_1_0.models;

import com.aliyun.tea.*;

public class CreateContractCompareTaskResponseBody extends TeaModel {
    @NameInMap("result")
    public CreateContractCompareTaskResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static CreateContractCompareTaskResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CreateContractCompareTaskResponseBody self = new CreateContractCompareTaskResponseBody();
        return TeaModel.build(map, self);
    }

    public CreateContractCompareTaskResponseBody setResult(CreateContractCompareTaskResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public CreateContractCompareTaskResponseBodyResult getResult() {
        return this.result;
    }

    public CreateContractCompareTaskResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class CreateContractCompareTaskResponseBodyResultData extends TeaModel {
        @NameInMap("compareTaskId")
        public String compareTaskId;

        public static CreateContractCompareTaskResponseBodyResultData build(java.util.Map<String, ?> map) throws Exception {
            CreateContractCompareTaskResponseBodyResultData self = new CreateContractCompareTaskResponseBodyResultData();
            return TeaModel.build(map, self);
        }

        public CreateContractCompareTaskResponseBodyResultData setCompareTaskId(String compareTaskId) {
            this.compareTaskId = compareTaskId;
            return this;
        }
        public String getCompareTaskId() {
            return this.compareTaskId;
        }

    }

    public static class CreateContractCompareTaskResponseBodyResult extends TeaModel {
        @NameInMap("data")
        public CreateContractCompareTaskResponseBodyResultData data;

        @NameInMap("requestId")
        public String requestId;

        public static CreateContractCompareTaskResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            CreateContractCompareTaskResponseBodyResult self = new CreateContractCompareTaskResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public CreateContractCompareTaskResponseBodyResult setData(CreateContractCompareTaskResponseBodyResultData data) {
            this.data = data;
            return this;
        }
        public CreateContractCompareTaskResponseBodyResultData getData() {
            return this.data;
        }

        public CreateContractCompareTaskResponseBodyResult setRequestId(String requestId) {
            this.requestId = requestId;
            return this;
        }
        public String getRequestId() {
            return this.requestId;
        }

    }

}
