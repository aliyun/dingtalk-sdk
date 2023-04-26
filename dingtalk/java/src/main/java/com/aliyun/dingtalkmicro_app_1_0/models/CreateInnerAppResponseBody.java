// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmicro_app_1_0.models;

import com.aliyun.tea.*;

public class CreateInnerAppResponseBody extends TeaModel {
    @NameInMap("agentId")
    public Long agentId;

    @NameInMap("appKey")
    public String appKey;

    @NameInMap("appSecret")
    public String appSecret;

    public static CreateInnerAppResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CreateInnerAppResponseBody self = new CreateInnerAppResponseBody();
        return TeaModel.build(map, self);
    }

    public CreateInnerAppResponseBody setAgentId(Long agentId) {
        this.agentId = agentId;
        return this;
    }
    public Long getAgentId() {
        return this.agentId;
    }

    public CreateInnerAppResponseBody setAppKey(String appKey) {
        this.appKey = appKey;
        return this;
    }
    public String getAppKey() {
        return this.appKey;
    }

    public CreateInnerAppResponseBody setAppSecret(String appSecret) {
        this.appSecret = appSecret;
        return this;
    }
    public String getAppSecret() {
        return this.appSecret;
    }

}
