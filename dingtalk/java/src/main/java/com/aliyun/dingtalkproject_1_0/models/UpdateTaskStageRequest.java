// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class UpdateTaskStageRequest extends TeaModel {
    @NameInMap("taskStageId")
    public String taskStageId;

    public static UpdateTaskStageRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateTaskStageRequest self = new UpdateTaskStageRequest();
        return TeaModel.build(map, self);
    }

    public UpdateTaskStageRequest setTaskStageId(String taskStageId) {
        this.taskStageId = taskStageId;
        return this;
    }
    public String getTaskStageId() {
        return this.taskStageId;
    }

}
