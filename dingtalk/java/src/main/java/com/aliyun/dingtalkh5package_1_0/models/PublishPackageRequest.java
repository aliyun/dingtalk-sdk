// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkh5package_1_0.models;

import com.aliyun.tea.*;

public class PublishPackageRequest extends TeaModel {
    @NameInMap("agentId")
    public Long agentId;

    @NameInMap("appId")
    public Long appId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("version")
    public String version;

    public static PublishPackageRequest build(java.util.Map<String, ?> map) throws Exception {
        PublishPackageRequest self = new PublishPackageRequest();
        return TeaModel.build(map, self);
    }

    public PublishPackageRequest setAgentId(Long agentId) {
        this.agentId = agentId;
        return this;
    }
    public Long getAgentId() {
        return this.agentId;
    }

    public PublishPackageRequest setAppId(Long appId) {
        this.appId = appId;
        return this;
    }
    public Long getAppId() {
        return this.appId;
    }

    public PublishPackageRequest setVersion(String version) {
        this.version = version;
        return this;
    }
    public String getVersion() {
        return this.version;
    }

}
