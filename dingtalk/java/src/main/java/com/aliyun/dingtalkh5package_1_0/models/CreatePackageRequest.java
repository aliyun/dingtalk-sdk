// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkh5package_1_0.models;

import com.aliyun.tea.*;

public class CreatePackageRequest extends TeaModel {
    // 企业内部微应用agentId
    @NameInMap("agentId")
    public Long agentId;

    // 第三方企业应用appId
    @NameInMap("appId")
    public Long appId;

    // 离线包入口页面地址。没有设置时，默认值是应用设置中的应用首页地址。
    @NameInMap("homeUrl")
    public String homeUrl;

    // 通过获取上传凭据接口返回的name值
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
