// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontract_1_0.models;

import com.aliyun.tea.*;

public class CreateContractReviewResponseBody extends TeaModel {
    @NameInMap("result")
    public CreateContractReviewResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static CreateContractReviewResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CreateContractReviewResponseBody self = new CreateContractReviewResponseBody();
        return TeaModel.build(map, self);
    }

    public CreateContractReviewResponseBody setResult(CreateContractReviewResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public CreateContractReviewResponseBodyResult getResult() {
        return this.result;
    }

    public CreateContractReviewResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class CreateContractReviewResponseBodyResult extends TeaModel {
        @NameInMap("planFinishTime")
        public Long planFinishTime;

        @NameInMap("reviewType")
        public String reviewType;

        @NameInMap("taskId")
        public String taskId;

        public static CreateContractReviewResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            CreateContractReviewResponseBodyResult self = new CreateContractReviewResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public CreateContractReviewResponseBodyResult setPlanFinishTime(Long planFinishTime) {
            this.planFinishTime = planFinishTime;
            return this;
        }
        public Long getPlanFinishTime() {
            return this.planFinishTime;
        }

        public CreateContractReviewResponseBodyResult setReviewType(String reviewType) {
            this.reviewType = reviewType;
            return this;
        }
        public String getReviewType() {
            return this.reviewType;
        }

        public CreateContractReviewResponseBodyResult setTaskId(String taskId) {
            this.taskId = taskId;
            return this;
        }
        public String getTaskId() {
            return this.taskId;
        }

    }

}
