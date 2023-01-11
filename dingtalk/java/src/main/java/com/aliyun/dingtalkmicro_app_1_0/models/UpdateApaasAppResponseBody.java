// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmicro_app_1_0.models;

import com.aliyun.tea.*;

public class UpdateApaasAppResponseBody extends TeaModel {
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

    public static UpdateApaasAppResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdateApaasAppResponseBody self = new UpdateApaasAppResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdateApaasAppResponseBody setAgentId(Long agentId) {
        this.agentId = agentId;
        return this;
    }
    public Long getAgentId() {
        return this.agentId;
    }

    public UpdateApaasAppResponseBody setBizAppId(String bizAppId) {
        this.bizAppId = bizAppId;
        return this;
    }
    public String getBizAppId() {
        return this.bizAppId;
    }

}
