// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkminiapp_1_0.models;

import com.aliyun.tea.*;

public class SetExtendSettingRequest extends TeaModel {
    @NameInMap("miniAppId")
    public String miniAppId;

    @NameInMap("buildH5Bundle")
    public Boolean buildH5Bundle;

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

    public static SetExtendSettingRequest build(java.util.Map<String, ?> map) throws Exception {
        SetExtendSettingRequest self = new SetExtendSettingRequest();
        return TeaModel.build(map, self);
    }

    public SetExtendSettingRequest setMiniAppId(String miniAppId) {
        this.miniAppId = miniAppId;
        return this;
    }
    public String getMiniAppId() {
        return this.miniAppId;
    }

    public SetExtendSettingRequest setBuildH5Bundle(Boolean buildH5Bundle) {
        this.buildH5Bundle = buildH5Bundle;
        return this;
    }
    public Boolean getBuildH5Bundle() {
        return this.buildH5Bundle;
    }

    public SetExtendSettingRequest setDingIsvOrgId(Long dingIsvOrgId) {
        this.dingIsvOrgId = dingIsvOrgId;
        return this;
    }
    public Long getDingIsvOrgId() {
        return this.dingIsvOrgId;
    }

    public SetExtendSettingRequest setDingOrgId(Long dingOrgId) {
        this.dingOrgId = dingOrgId;
        return this;
    }
    public Long getDingOrgId() {
        return this.dingOrgId;
    }

    public SetExtendSettingRequest setDingSuiteKey(String dingSuiteKey) {
        this.dingSuiteKey = dingSuiteKey;
        return this;
    }
    public String getDingSuiteKey() {
        return this.dingSuiteKey;
    }

    public SetExtendSettingRequest setDingCorpId(String dingCorpId) {
        this.dingCorpId = dingCorpId;
        return this;
    }
    public String getDingCorpId() {
        return this.dingCorpId;
    }

    public SetExtendSettingRequest setDingTokenGrantType(Long dingTokenGrantType) {
        this.dingTokenGrantType = dingTokenGrantType;
        return this;
    }
    public Long getDingTokenGrantType() {
        return this.dingTokenGrantType;
    }

    public SetExtendSettingRequest setDingClientId(String dingClientId) {
        this.dingClientId = dingClientId;
        return this;
    }
    public String getDingClientId() {
        return this.dingClientId;
    }

}
