// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class GetAgentIdByRelatedAppIdResponseBody extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>3300000</p>
     */
    @NameInMap("agentId")
    public Long agentId;

    public static GetAgentIdByRelatedAppIdResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetAgentIdByRelatedAppIdResponseBody self = new GetAgentIdByRelatedAppIdResponseBody();
        return TeaModel.build(map, self);
    }

    public GetAgentIdByRelatedAppIdResponseBody setAgentId(Long agentId) {
        this.agentId = agentId;
        return this;
    }
    public Long getAgentId() {
        return this.agentId;
    }

}
