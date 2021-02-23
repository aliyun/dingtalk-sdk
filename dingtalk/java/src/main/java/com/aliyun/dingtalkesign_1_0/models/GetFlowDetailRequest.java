// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkesign_1_0.models;

import com.aliyun.tea.*;

public class GetFlowDetailRequest extends TeaModel {
    @NameInMap("taskId")
    public String taskId;

    public static GetFlowDetailRequest build(java.util.Map<String, ?> map) throws Exception {
        GetFlowDetailRequest self = new GetFlowDetailRequest();
        return TeaModel.build(map, self);
    }

    public GetFlowDetailRequest setTaskId(String taskId) {
        this.taskId = taskId;
        return this;
    }
    public String getTaskId() {
        return this.taskId;
    }

}
