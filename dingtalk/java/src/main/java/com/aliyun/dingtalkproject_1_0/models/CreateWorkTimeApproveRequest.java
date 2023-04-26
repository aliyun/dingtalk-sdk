// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class CreateWorkTimeApproveRequest extends TeaModel {
    @NameInMap("workTimeIds")
    public java.util.List<String> workTimeIds;

    public static CreateWorkTimeApproveRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateWorkTimeApproveRequest self = new CreateWorkTimeApproveRequest();
        return TeaModel.build(map, self);
    }

    public CreateWorkTimeApproveRequest setWorkTimeIds(java.util.List<String> workTimeIds) {
        this.workTimeIds = workTimeIds;
        return this;
    }
    public java.util.List<String> getWorkTimeIds() {
        return this.workTimeIds;
    }

}
