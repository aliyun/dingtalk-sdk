// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class GetConditionFormComponentRequest extends TeaModel {
    // 应用ID (三方应用为AppID)，可在开发者管理后台后台的应用详情页面获取。
    @NameInMap("agentId")
    public Long agentId;

    // 审批模板ID。
    // 
    // processCode需要OA管理后台，在编辑审批表单的URL中获取。
    @NameInMap("processCode")
    public String processCode;

    public static GetConditionFormComponentRequest build(java.util.Map<String, ?> map) throws Exception {
        GetConditionFormComponentRequest self = new GetConditionFormComponentRequest();
        return TeaModel.build(map, self);
    }

    public GetConditionFormComponentRequest setAgentId(Long agentId) {
        this.agentId = agentId;
        return this;
    }
    public Long getAgentId() {
        return this.agentId;
    }

    public GetConditionFormComponentRequest setProcessCode(String processCode) {
        this.processCode = processCode;
        return this;
    }
    public String getProcessCode() {
        return this.processCode;
    }

}
