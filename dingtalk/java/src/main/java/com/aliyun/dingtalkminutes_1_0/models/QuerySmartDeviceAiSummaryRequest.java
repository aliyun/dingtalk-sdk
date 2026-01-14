// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkminutes_1_0.models;

import com.aliyun.tea.*;

public class QuerySmartDeviceAiSummaryRequest extends TeaModel {
    @NameInMap("agentId")
    public String agentId;

    @NameInMap("openFileId")
    public String openFileId;

    public static QuerySmartDeviceAiSummaryRequest build(java.util.Map<String, ?> map) throws Exception {
        QuerySmartDeviceAiSummaryRequest self = new QuerySmartDeviceAiSummaryRequest();
        return TeaModel.build(map, self);
    }

    public QuerySmartDeviceAiSummaryRequest setAgentId(String agentId) {
        this.agentId = agentId;
        return this;
    }
    public String getAgentId() {
        return this.agentId;
    }

    public QuerySmartDeviceAiSummaryRequest setOpenFileId(String openFileId) {
        this.openFileId = openFileId;
        return this;
    }
    public String getOpenFileId() {
        return this.openFileId;
    }

}
