// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontract_1_0.models;

import com.aliyun.tea.*;

public class CreateContractReviewTaskResponseBody extends TeaModel {
    @NameInMap("result")
    public CreateContractReviewTaskResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static CreateContractReviewTaskResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CreateContractReviewTaskResponseBody self = new CreateContractReviewTaskResponseBody();
        return TeaModel.build(map, self);
    }

    public CreateContractReviewTaskResponseBody setResult(CreateContractReviewTaskResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public CreateContractReviewTaskResponseBodyResult getResult() {
        return this.result;
    }

    public CreateContractReviewTaskResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class CreateContractReviewTaskResponseBodyResultData extends TeaModel {
        @NameInMap("reviewTaskId")
        public String reviewTaskId;

        public static CreateContractReviewTaskResponseBodyResultData build(java.util.Map<String, ?> map) throws Exception {
            CreateContractReviewTaskResponseBodyResultData self = new CreateContractReviewTaskResponseBodyResultData();
            return TeaModel.build(map, self);
        }

        public CreateContractReviewTaskResponseBodyResultData setReviewTaskId(String reviewTaskId) {
            this.reviewTaskId = reviewTaskId;
            return this;
        }
        public String getReviewTaskId() {
            return this.reviewTaskId;
        }

    }

    public static class CreateContractReviewTaskResponseBodyResult extends TeaModel {
        @NameInMap("data")
        public CreateContractReviewTaskResponseBodyResultData data;

        @NameInMap("requestId")
        public String requestId;

        public static CreateContractReviewTaskResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            CreateContractReviewTaskResponseBodyResult self = new CreateContractReviewTaskResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public CreateContractReviewTaskResponseBodyResult setData(CreateContractReviewTaskResponseBodyResultData data) {
            this.data = data;
            return this;
        }
        public CreateContractReviewTaskResponseBodyResultData getData() {
            return this.data;
        }

        public CreateContractReviewTaskResponseBodyResult setRequestId(String requestId) {
            this.requestId = requestId;
            return this;
        }
        public String getRequestId() {
            return this.requestId;
        }

    }

}
