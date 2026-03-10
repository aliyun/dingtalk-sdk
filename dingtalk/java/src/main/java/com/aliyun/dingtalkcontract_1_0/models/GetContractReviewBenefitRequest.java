// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontract_1_0.models;

import com.aliyun.tea.*;

public class GetContractReviewBenefitRequest extends TeaModel {
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

    public static GetContractReviewBenefitRequest build(java.util.Map<String, ?> map) throws Exception {
        GetContractReviewBenefitRequest self = new GetContractReviewBenefitRequest();
        return TeaModel.build(map, self);
    }

    public GetContractReviewBenefitRequest setReviewType(String reviewType) {
        this.reviewType = reviewType;
        return this;
    }
    public String getReviewType() {
        return this.reviewType;
    }

    public GetContractReviewBenefitRequest setTaskId(String taskId) {
        this.taskId = taskId;
        return this;
    }
    public String getTaskId() {
        return this.taskId;
    }

}
