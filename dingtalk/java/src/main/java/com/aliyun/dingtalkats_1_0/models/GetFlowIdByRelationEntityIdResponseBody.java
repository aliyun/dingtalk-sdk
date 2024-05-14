// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkats_1_0.models;

import com.aliyun.tea.*;

public class GetFlowIdByRelationEntityIdResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("flowId")
    public String flowId;

    public static GetFlowIdByRelationEntityIdResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetFlowIdByRelationEntityIdResponseBody self = new GetFlowIdByRelationEntityIdResponseBody();
        return TeaModel.build(map, self);
    }

    public GetFlowIdByRelationEntityIdResponseBody setFlowId(String flowId) {
        this.flowId = flowId;
        return this;
    }
    public String getFlowId() {
        return this.flowId;
    }

}
