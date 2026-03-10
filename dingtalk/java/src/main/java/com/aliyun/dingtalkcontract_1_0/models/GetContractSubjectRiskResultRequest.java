// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontract_1_0.models;

import com.aliyun.tea.*;

public class GetContractSubjectRiskResultRequest extends TeaModel {
    @NameInMap("reviewType")
    public String reviewType;

    @NameInMap("taskId")
    public String taskId;

    public static GetContractSubjectRiskResultRequest build(java.util.Map<String, ?> map) throws Exception {
        GetContractSubjectRiskResultRequest self = new GetContractSubjectRiskResultRequest();
        return TeaModel.build(map, self);
    }

    public GetContractSubjectRiskResultRequest setReviewType(String reviewType) {
        this.reviewType = reviewType;
        return this;
    }
    public String getReviewType() {
        return this.reviewType;
    }

    public GetContractSubjectRiskResultRequest setTaskId(String taskId) {
        this.taskId = taskId;
        return this;
    }
    public String getTaskId() {
        return this.taskId;
    }

}
