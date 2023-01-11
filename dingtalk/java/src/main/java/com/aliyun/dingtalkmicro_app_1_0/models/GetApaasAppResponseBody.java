// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmicro_app_1_0.models;

import com.aliyun.tea.*;

public class GetApaasAppResponseBody extends TeaModel {
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

    /**
     * <p>发布状态</p>
     */
    @NameInMap("publishStatus")
    public String publishStatus;

    public static GetApaasAppResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetApaasAppResponseBody self = new GetApaasAppResponseBody();
        return TeaModel.build(map, self);
    }

    public GetApaasAppResponseBody setAgentId(Long agentId) {
        this.agentId = agentId;
        return this;
    }
    public Long getAgentId() {
        return this.agentId;
    }

    public GetApaasAppResponseBody setBizAppId(String bizAppId) {
        this.bizAppId = bizAppId;
        return this;
    }
    public String getBizAppId() {
        return this.bizAppId;
    }

    public GetApaasAppResponseBody setPublishStatus(String publishStatus) {
        this.publishStatus = publishStatus;
        return this;
    }
    public String getPublishStatus() {
        return this.publishStatus;
    }

}
