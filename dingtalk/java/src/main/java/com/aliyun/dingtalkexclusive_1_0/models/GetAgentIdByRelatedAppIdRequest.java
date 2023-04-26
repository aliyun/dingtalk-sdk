// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class GetAgentIdByRelatedAppIdRequest extends TeaModel {
    @NameInMap("appId")
    public Long appId;

    @NameInMap("targetCorpId")
    public String targetCorpId;

    public static GetAgentIdByRelatedAppIdRequest build(java.util.Map<String, ?> map) throws Exception {
        GetAgentIdByRelatedAppIdRequest self = new GetAgentIdByRelatedAppIdRequest();
        return TeaModel.build(map, self);
    }

    public GetAgentIdByRelatedAppIdRequest setAppId(Long appId) {
        this.appId = appId;
        return this;
    }
    public Long getAppId() {
        return this.appId;
    }

    public GetAgentIdByRelatedAppIdRequest setTargetCorpId(String targetCorpId) {
        this.targetCorpId = targetCorpId;
        return this;
    }
    public String getTargetCorpId() {
        return this.targetCorpId;
    }

}
