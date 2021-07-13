// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkminiapp_1_0.models;

import com.aliyun.tea.*;

public class CreateVersionAcrossBundleRequest extends TeaModel {
    @NameInMap("dingTokenGrantType")
    public Long dingTokenGrantType;

    // sourceVersion
    @NameInMap("sourceVersion")
    public String sourceVersion;

    // sourceBundleId
    @NameInMap("sourceBundleId")
    public String sourceBundleId;

    @NameInMap("dingOrgId")
    public Long dingOrgId;

    @NameInMap("dingCorpId")
    public String dingCorpId;

    // bundleId
    @NameInMap("bundleId")
    public String bundleId;

    // version
    @NameInMap("version")
    public String version;

    @NameInMap("dingClientId")
    public String dingClientId;

    @NameInMap("dingIsvOrgId")
    public Long dingIsvOrgId;

    @NameInMap("dingSuiteKey")
    public String dingSuiteKey;

    @NameInMap("miniAppId")
    public String miniAppId;

    public static CreateVersionAcrossBundleRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateVersionAcrossBundleRequest self = new CreateVersionAcrossBundleRequest();
        return TeaModel.build(map, self);
    }

    public CreateVersionAcrossBundleRequest setDingTokenGrantType(Long dingTokenGrantType) {
        this.dingTokenGrantType = dingTokenGrantType;
        return this;
    }
    public Long getDingTokenGrantType() {
        return this.dingTokenGrantType;
    }

    public CreateVersionAcrossBundleRequest setSourceVersion(String sourceVersion) {
        this.sourceVersion = sourceVersion;
        return this;
    }
    public String getSourceVersion() {
        return this.sourceVersion;
    }

    public CreateVersionAcrossBundleRequest setSourceBundleId(String sourceBundleId) {
        this.sourceBundleId = sourceBundleId;
        return this;
    }
    public String getSourceBundleId() {
        return this.sourceBundleId;
    }

    public CreateVersionAcrossBundleRequest setDingOrgId(Long dingOrgId) {
        this.dingOrgId = dingOrgId;
        return this;
    }
    public Long getDingOrgId() {
        return this.dingOrgId;
    }

    public CreateVersionAcrossBundleRequest setDingCorpId(String dingCorpId) {
        this.dingCorpId = dingCorpId;
        return this;
    }
    public String getDingCorpId() {
        return this.dingCorpId;
    }

    public CreateVersionAcrossBundleRequest setBundleId(String bundleId) {
        this.bundleId = bundleId;
        return this;
    }
    public String getBundleId() {
        return this.bundleId;
    }

    public CreateVersionAcrossBundleRequest setVersion(String version) {
        this.version = version;
        return this;
    }
    public String getVersion() {
        return this.version;
    }

    public CreateVersionAcrossBundleRequest setDingClientId(String dingClientId) {
        this.dingClientId = dingClientId;
        return this;
    }
    public String getDingClientId() {
        return this.dingClientId;
    }

    public CreateVersionAcrossBundleRequest setDingIsvOrgId(Long dingIsvOrgId) {
        this.dingIsvOrgId = dingIsvOrgId;
        return this;
    }
    public Long getDingIsvOrgId() {
        return this.dingIsvOrgId;
    }

    public CreateVersionAcrossBundleRequest setDingSuiteKey(String dingSuiteKey) {
        this.dingSuiteKey = dingSuiteKey;
        return this;
    }
    public String getDingSuiteKey() {
        return this.dingSuiteKey;
    }

    public CreateVersionAcrossBundleRequest setMiniAppId(String miniAppId) {
        this.miniAppId = miniAppId;
        return this;
    }
    public String getMiniAppId() {
        return this.miniAppId;
    }

}
