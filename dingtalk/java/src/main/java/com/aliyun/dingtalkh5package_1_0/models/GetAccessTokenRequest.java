// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkh5package_1_0.models;

import com.aliyun.tea.*;

public class GetAccessTokenRequest extends TeaModel {
    /**
     * <p>企业内部微应用agentId。</p>
     */
    @NameInMap("agentId")
    public Long agentId;

    /**
     * <p>第三方企业应用appId。</p>
     */
    @NameInMap("appId")
    public Long appId;

    public static GetAccessTokenRequest build(java.util.Map<String, ?> map) throws Exception {
        GetAccessTokenRequest self = new GetAccessTokenRequest();
        return TeaModel.build(map, self);
    }

    public GetAccessTokenRequest setAgentId(Long agentId) {
        this.agentId = agentId;
        return this;
    }
    public Long getAgentId() {
        return this.agentId;
    }

    public GetAccessTokenRequest setAppId(Long appId) {
        this.appId = appId;
        return this;
    }
    public Long getAppId() {
        return this.appId;
    }

}
