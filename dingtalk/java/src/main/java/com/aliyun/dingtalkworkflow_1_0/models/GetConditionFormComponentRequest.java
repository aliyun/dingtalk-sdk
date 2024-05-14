// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class GetConditionFormComponentRequest extends TeaModel {
    @NameInMap("agentId")
    public Long agentId;

    /**
     * <p>This parameter is required.</p>
     */
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
