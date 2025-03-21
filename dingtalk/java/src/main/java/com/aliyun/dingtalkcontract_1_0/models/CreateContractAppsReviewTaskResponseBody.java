// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontract_1_0.models;

import com.aliyun.tea.*;

public class CreateContractAppsReviewTaskResponseBody extends TeaModel {
    @NameInMap("result")
    public CreateContractAppsReviewTaskResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static CreateContractAppsReviewTaskResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CreateContractAppsReviewTaskResponseBody self = new CreateContractAppsReviewTaskResponseBody();
        return TeaModel.build(map, self);
    }

    public CreateContractAppsReviewTaskResponseBody setResult(CreateContractAppsReviewTaskResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public CreateContractAppsReviewTaskResponseBodyResult getResult() {
        return this.result;
    }

    public CreateContractAppsReviewTaskResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class CreateContractAppsReviewTaskResponseBodyResultData extends TeaModel {
        @NameInMap("reviewTaskId")
        public String reviewTaskId;

        public static CreateContractAppsReviewTaskResponseBodyResultData build(java.util.Map<String, ?> map) throws Exception {
            CreateContractAppsReviewTaskResponseBodyResultData self = new CreateContractAppsReviewTaskResponseBodyResultData();
            return TeaModel.build(map, self);
        }

        public CreateContractAppsReviewTaskResponseBodyResultData setReviewTaskId(String reviewTaskId) {
            this.reviewTaskId = reviewTaskId;
            return this;
        }
        public String getReviewTaskId() {
            return this.reviewTaskId;
        }

    }

    public static class CreateContractAppsReviewTaskResponseBodyResult extends TeaModel {
        @NameInMap("data")
        public CreateContractAppsReviewTaskResponseBodyResultData data;

        @NameInMap("requestId")
        public String requestId;

        public static CreateContractAppsReviewTaskResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            CreateContractAppsReviewTaskResponseBodyResult self = new CreateContractAppsReviewTaskResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public CreateContractAppsReviewTaskResponseBodyResult setData(CreateContractAppsReviewTaskResponseBodyResultData data) {
            this.data = data;
            return this;
        }
        public CreateContractAppsReviewTaskResponseBodyResultData getData() {
            return this.data;
        }

        public CreateContractAppsReviewTaskResponseBodyResult setRequestId(String requestId) {
            this.requestId = requestId;
            return this;
        }
        public String getRequestId() {
            return this.requestId;
        }

    }

}
