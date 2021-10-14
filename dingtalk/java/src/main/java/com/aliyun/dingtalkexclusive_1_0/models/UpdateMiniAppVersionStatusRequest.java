// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class UpdateMiniAppVersionStatusRequest extends TeaModel {
    // 版本类型
    @NameInMap("versionType")
    public Integer versionType;

    // 版本
    @NameInMap("version")
    public String version;

    // 小程序id
    @NameInMap("miniAppId")
    public String miniAppId;

    @NameInMap("dingClientId")
    public String dingClientId;

    @NameInMap("dingTokenGrantType")
    public Long dingTokenGrantType;

    @NameInMap("dingOrgId")
    public Long dingOrgId;

    @NameInMap("dingIsvOrgId")
    public Long dingIsvOrgId;

    @NameInMap("dingSuiteKey")
    public String dingSuiteKey;

    @NameInMap("dingCorpId")
    public String dingCorpId;

    public static UpdateMiniAppVersionStatusRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateMiniAppVersionStatusRequest self = new UpdateMiniAppVersionStatusRequest();
        return TeaModel.build(map, self);
    }

    public UpdateMiniAppVersionStatusRequest setVersionType(Integer versionType) {
        this.versionType = versionType;
        return this;
    }
    public Integer getVersionType() {
        return this.versionType;
    }

    public UpdateMiniAppVersionStatusRequest setVersion(String version) {
        this.version = version;
        return this;
    }
    public String getVersion() {
        return this.version;
    }

    public UpdateMiniAppVersionStatusRequest setMiniAppId(String miniAppId) {
        this.miniAppId = miniAppId;
        return this;
    }
    public String getMiniAppId() {
        return this.miniAppId;
    }

    public UpdateMiniAppVersionStatusRequest setDingClientId(String dingClientId) {
        this.dingClientId = dingClientId;
        return this;
    }
    public String getDingClientId() {
        return this.dingClientId;
    }

    public UpdateMiniAppVersionStatusRequest setDingTokenGrantType(Long dingTokenGrantType) {
        this.dingTokenGrantType = dingTokenGrantType;
        return this;
    }
    public Long getDingTokenGrantType() {
        return this.dingTokenGrantType;
    }

    public UpdateMiniAppVersionStatusRequest setDingOrgId(Long dingOrgId) {
        this.dingOrgId = dingOrgId;
        return this;
    }
    public Long getDingOrgId() {
        return this.dingOrgId;
    }

    public UpdateMiniAppVersionStatusRequest setDingIsvOrgId(Long dingIsvOrgId) {
        this.dingIsvOrgId = dingIsvOrgId;
        return this;
    }
    public Long getDingIsvOrgId() {
        return this.dingIsvOrgId;
    }

    public UpdateMiniAppVersionStatusRequest setDingSuiteKey(String dingSuiteKey) {
        this.dingSuiteKey = dingSuiteKey;
        return this;
    }
    public String getDingSuiteKey() {
        return this.dingSuiteKey;
    }

    public UpdateMiniAppVersionStatusRequest setDingCorpId(String dingCorpId) {
        this.dingCorpId = dingCorpId;
        return this;
    }
    public String getDingCorpId() {
        return this.dingCorpId;
    }

}
