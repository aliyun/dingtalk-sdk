// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmicro_app_1_0.models;

import com.aliyun.tea.*;

public class CreateApaasAppResponseBody extends TeaModel {
    /**
     * <p>钉钉侧应用id</p>
     */
    @NameInMap("agentId")
    public Long agentId;

    /**
     * <p>ISV侧应用id</p>
     */
    @NameInMap("bizAppId")
    public String bizAppId;

    public static CreateApaasAppResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CreateApaasAppResponseBody self = new CreateApaasAppResponseBody();
        return TeaModel.build(map, self);
    }

    public CreateApaasAppResponseBody setAgentId(Long agentId) {
        this.agentId = agentId;
        return this;
    }
    public Long getAgentId() {
        return this.agentId;
    }

    public CreateApaasAppResponseBody setBizAppId(String bizAppId) {
        this.bizAppId = bizAppId;
        return this;
    }
    public String getBizAppId() {
        return this.bizAppId;
    }

}
