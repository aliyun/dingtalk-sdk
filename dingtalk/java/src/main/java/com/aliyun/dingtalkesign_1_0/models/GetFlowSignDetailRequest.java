// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkesign_1_0.models;

import com.aliyun.tea.*;

public class GetFlowSignDetailRequest extends TeaModel {
    @NameInMap("appId")
    public Long appId;

    @NameInMap("taskId")
    public String taskId;

    public static GetFlowSignDetailRequest build(java.util.Map<String, ?> map) throws Exception {
        GetFlowSignDetailRequest self = new GetFlowSignDetailRequest();
        return TeaModel.build(map, self);
    }

    public GetFlowSignDetailRequest setAppId(Long appId) {
        this.appId = appId;
        return this;
    }
    public Long getAppId() {
        return this.appId;
    }

    public GetFlowSignDetailRequest setTaskId(String taskId) {
        this.taskId = taskId;
        return this;
    }
    public String getTaskId() {
        return this.taskId;
    }

}
