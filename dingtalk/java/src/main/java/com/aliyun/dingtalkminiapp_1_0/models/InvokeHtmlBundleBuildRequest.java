// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkminiapp_1_0.models;

import com.aliyun.tea.*;

public class InvokeHtmlBundleBuildRequest extends TeaModel {
    @NameInMap("miniAppId")
    public String miniAppId;

    @NameInMap("bundleId")
    public String bundleId;

    @NameInMap("version")
    public String version;

    @NameInMap("dingIsvOrgId")
    public Long dingIsvOrgId;

    @NameInMap("dingOrgId")
    public Long dingOrgId;

    @NameInMap("dingSuiteKey")
    public String dingSuiteKey;

    @NameInMap("dingCorpId")
    public String dingCorpId;

    @NameInMap("dingTokenGrantType")
    public Long dingTokenGrantType;

    @NameInMap("dingClientId")
    public String dingClientId;

    public static InvokeHtmlBundleBuildRequest build(java.util.Map<String, ?> map) throws Exception {
        InvokeHtmlBundleBuildRequest self = new InvokeHtmlBundleBuildRequest();
        return TeaModel.build(map, self);
    }

    public InvokeHtmlBundleBuildRequest setMiniAppId(String miniAppId) {
        this.miniAppId = miniAppId;
        return this;
    }
    public String getMiniAppId() {
        return this.miniAppId;
    }

    public InvokeHtmlBundleBuildRequest setBundleId(String bundleId) {
        this.bundleId = bundleId;
        return this;
    }
    public String getBundleId() {
        return this.bundleId;
    }

    public InvokeHtmlBundleBuildRequest setVersion(String version) {
        this.version = version;
        return this;
    }
    public String getVersion() {
        return this.version;
    }

    public InvokeHtmlBundleBuildRequest setDingIsvOrgId(Long dingIsvOrgId) {
        this.dingIsvOrgId = dingIsvOrgId;
        return this;
    }
    public Long getDingIsvOrgId() {
        return this.dingIsvOrgId;
    }

    public InvokeHtmlBundleBuildRequest setDingOrgId(Long dingOrgId) {
        this.dingOrgId = dingOrgId;
        return this;
    }
    public Long getDingOrgId() {
        return this.dingOrgId;
    }

    public InvokeHtmlBundleBuildRequest setDingSuiteKey(String dingSuiteKey) {
        this.dingSuiteKey = dingSuiteKey;
        return this;
    }
    public String getDingSuiteKey() {
        return this.dingSuiteKey;
    }

    public InvokeHtmlBundleBuildRequest setDingCorpId(String dingCorpId) {
        this.dingCorpId = dingCorpId;
        return this;
    }
    public String getDingCorpId() {
        return this.dingCorpId;
    }

    public InvokeHtmlBundleBuildRequest setDingTokenGrantType(Long dingTokenGrantType) {
        this.dingTokenGrantType = dingTokenGrantType;
        return this;
    }
    public Long getDingTokenGrantType() {
        return this.dingTokenGrantType;
    }

    public InvokeHtmlBundleBuildRequest setDingClientId(String dingClientId) {
        this.dingClientId = dingClientId;
        return this;
    }
    public String getDingClientId() {
        return this.dingClientId;
    }

}
