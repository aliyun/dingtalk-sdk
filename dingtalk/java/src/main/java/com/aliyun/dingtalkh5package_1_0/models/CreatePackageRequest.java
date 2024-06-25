// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkh5package_1_0.models;

import com.aliyun.tea.*;

public class CreatePackageRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>1234</p>
     */
    @NameInMap("agentId")
    public Long agentId;

    /**
     * <strong>example:</strong>
     * <p>1234</p>
     */
    @NameInMap("appId")
    public Long appId;

    /**
     * <strong>example:</strong>
     * <p><a href="https://example.com/myapp/index.html">https://example.com/myapp/index.html</a></p>
     */
    @NameInMap("homeUrl")
    public String homeUrl;

    /**
     * <strong>example:</strong>
     * <p>aaaaaa/bbbbbb</p>
     */
    @NameInMap("ossObjectKey")
    public String ossObjectKey;

    public static CreatePackageRequest build(java.util.Map<String, ?> map) throws Exception {
        CreatePackageRequest self = new CreatePackageRequest();
        return TeaModel.build(map, self);
    }

    public CreatePackageRequest setAgentId(Long agentId) {
        this.agentId = agentId;
        return this;
    }
    public Long getAgentId() {
        return this.agentId;
    }

    public CreatePackageRequest setAppId(Long appId) {
        this.appId = appId;
        return this;
    }
    public Long getAppId() {
        return this.appId;
    }

    public CreatePackageRequest setHomeUrl(String homeUrl) {
        this.homeUrl = homeUrl;
        return this;
    }
    public String getHomeUrl() {
        return this.homeUrl;
    }

    public CreatePackageRequest setOssObjectKey(String ossObjectKey) {
        this.ossObjectKey = ossObjectKey;
        return this;
    }
    public String getOssObjectKey() {
        return this.ossObjectKey;
    }

}
