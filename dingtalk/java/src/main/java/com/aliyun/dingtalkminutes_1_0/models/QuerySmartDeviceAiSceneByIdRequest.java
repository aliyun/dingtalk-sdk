// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkminutes_1_0.models;

import com.aliyun.tea.*;

public class QuerySmartDeviceAiSceneByIdRequest extends TeaModel {
    @NameInMap("agentInstanceId")
    public String agentInstanceId;

    public static QuerySmartDeviceAiSceneByIdRequest build(java.util.Map<String, ?> map) throws Exception {
        QuerySmartDeviceAiSceneByIdRequest self = new QuerySmartDeviceAiSceneByIdRequest();
        return TeaModel.build(map, self);
    }

    public QuerySmartDeviceAiSceneByIdRequest setAgentInstanceId(String agentInstanceId) {
        this.agentInstanceId = agentInstanceId;
        return this;
    }
    public String getAgentInstanceId() {
        return this.agentInstanceId;
    }

}
