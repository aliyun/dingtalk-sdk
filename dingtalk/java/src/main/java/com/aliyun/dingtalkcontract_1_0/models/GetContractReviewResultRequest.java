// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontract_1_0.models;

import com.aliyun.tea.*;

public class GetContractReviewResultRequest extends TeaModel {
    @NameInMap("body")
    public GetContractReviewResultRequestBody body;

    public static GetContractReviewResultRequest build(java.util.Map<String, ?> map) throws Exception {
        GetContractReviewResultRequest self = new GetContractReviewResultRequest();
        return TeaModel.build(map, self);
    }

    public GetContractReviewResultRequest setBody(GetContractReviewResultRequestBody body) {
        this.body = body;
        return this;
    }
    public GetContractReviewResultRequestBody getBody() {
        return this.body;
    }

    public static class GetContractReviewResultRequestBody extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("reviewType")
        public String reviewType;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("taskId")
        public String taskId;

        public static GetContractReviewResultRequestBody build(java.util.Map<String, ?> map) throws Exception {
            GetContractReviewResultRequestBody self = new GetContractReviewResultRequestBody();
            return TeaModel.build(map, self);
        }

        public GetContractReviewResultRequestBody setReviewType(String reviewType) {
            this.reviewType = reviewType;
            return this;
        }
        public String getReviewType() {
            return this.reviewType;
        }

        public GetContractReviewResultRequestBody setTaskId(String taskId) {
            this.taskId = taskId;
            return this;
        }
        public String getTaskId() {
            return this.taskId;
        }

    }

}
