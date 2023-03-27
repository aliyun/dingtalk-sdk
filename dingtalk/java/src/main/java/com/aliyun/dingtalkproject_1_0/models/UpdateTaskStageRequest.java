// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class UpdateTaskStageRequest extends TeaModel {
    /**
     * <p>任务列表Id。</p>
     */
    @NameInMap("stageId")
    public String stageId;

    public static UpdateTaskStageRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateTaskStageRequest self = new UpdateTaskStageRequest();
        return TeaModel.build(map, self);
    }

    public UpdateTaskStageRequest setStageId(String stageId) {
        this.stageId = stageId;
        return this;
    }
    public String getStageId() {
        return this.stageId;
    }

}
