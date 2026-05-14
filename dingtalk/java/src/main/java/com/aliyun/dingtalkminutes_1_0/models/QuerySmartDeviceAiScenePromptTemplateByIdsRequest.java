// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkminutes_1_0.models;

import com.aliyun.tea.*;

public class QuerySmartDeviceAiScenePromptTemplateByIdsRequest extends TeaModel {
    @NameInMap("agentInstanceId")
    public String agentInstanceId;

    @NameInMap("agentPromptTemplateIds")
    public java.util.List<String> agentPromptTemplateIds;

    public static QuerySmartDeviceAiScenePromptTemplateByIdsRequest build(java.util.Map<String, ?> map) throws Exception {
        QuerySmartDeviceAiScenePromptTemplateByIdsRequest self = new QuerySmartDeviceAiScenePromptTemplateByIdsRequest();
        return TeaModel.build(map, self);
    }

    public QuerySmartDeviceAiScenePromptTemplateByIdsRequest setAgentInstanceId(String agentInstanceId) {
        this.agentInstanceId = agentInstanceId;
        return this;
    }
    public String getAgentInstanceId() {
        return this.agentInstanceId;
    }

    public QuerySmartDeviceAiScenePromptTemplateByIdsRequest setAgentPromptTemplateIds(java.util.List<String> agentPromptTemplateIds) {
        this.agentPromptTemplateIds = agentPromptTemplateIds;
        return this;
    }
    public java.util.List<String> getAgentPromptTemplateIds() {
        return this.agentPromptTemplateIds;
    }

}
