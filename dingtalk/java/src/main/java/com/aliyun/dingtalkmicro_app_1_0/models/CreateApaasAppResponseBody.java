// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmicro_app_1_0.models;

import com.aliyun.tea.*;

public class CreateApaasAppResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>1</p>
     */
    @NameInMap("agentId")
    public Long agentId;

    /**
     * <p>This parameter is required.</p>
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
