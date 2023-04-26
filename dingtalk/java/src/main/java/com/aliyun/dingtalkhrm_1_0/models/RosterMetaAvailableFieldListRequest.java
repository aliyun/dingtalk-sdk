// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class RosterMetaAvailableFieldListRequest extends TeaModel {
    @NameInMap("appAgentId")
    public Long appAgentId;

    public static RosterMetaAvailableFieldListRequest build(java.util.Map<String, ?> map) throws Exception {
        RosterMetaAvailableFieldListRequest self = new RosterMetaAvailableFieldListRequest();
        return TeaModel.build(map, self);
    }

    public RosterMetaAvailableFieldListRequest setAppAgentId(Long appAgentId) {
        this.appAgentId = appAgentId;
        return this;
    }
    public Long getAppAgentId() {
        return this.appAgentId;
    }

}
