// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontract_1_0.models;

import com.aliyun.tea.*;

public class CancelContractReviewRequest extends TeaModel {
    @NameInMap("reviewType")
    public String reviewType;

    @NameInMap("taskId")
    public String taskId;

    public static CancelContractReviewRequest build(java.util.Map<String, ?> map) throws Exception {
        CancelContractReviewRequest self = new CancelContractReviewRequest();
        return TeaModel.build(map, self);
    }

    public CancelContractReviewRequest setReviewType(String reviewType) {
        this.reviewType = reviewType;
        return this;
    }
    public String getReviewType() {
        return this.reviewType;
    }

    public CancelContractReviewRequest setTaskId(String taskId) {
        this.taskId = taskId;
        return this;
    }
    public String getTaskId() {
        return this.taskId;
    }

}
