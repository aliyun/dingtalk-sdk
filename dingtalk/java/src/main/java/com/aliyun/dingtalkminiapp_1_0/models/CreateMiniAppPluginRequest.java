// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkminiapp_1_0.models;

import com.aliyun.tea.*;

public class CreateMiniAppPluginRequest extends TeaModel {
    @NameInMap("bizType")
    public Integer bizType;

    @NameInMap("bizId")
    public String bizId;

    @NameInMap("name")
    public String name;

    @NameInMap("icon")
    public String icon;

    @NameInMap("desc")
    public String desc;

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

    public static CreateMiniAppPluginRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateMiniAppPluginRequest self = new CreateMiniAppPluginRequest();
        return TeaModel.build(map, self);
    }

    public CreateMiniAppPluginRequest setBizType(Integer bizType) {
        this.bizType = bizType;
        return this;
    }
    public Integer getBizType() {
        return this.bizType;
    }

    public CreateMiniAppPluginRequest setBizId(String bizId) {
        this.bizId = bizId;
        return this;
    }
    public String getBizId() {
        return this.bizId;
    }

    public CreateMiniAppPluginRequest setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public CreateMiniAppPluginRequest setIcon(String icon) {
        this.icon = icon;
        return this;
    }
    public String getIcon() {
        return this.icon;
    }

    public CreateMiniAppPluginRequest setDesc(String desc) {
        this.desc = desc;
        return this;
    }
    public String getDesc() {
        return this.desc;
    }

    public CreateMiniAppPluginRequest setDingIsvOrgId(Long dingIsvOrgId) {
        this.dingIsvOrgId = dingIsvOrgId;
        return this;
    }
    public Long getDingIsvOrgId() {
        return this.dingIsvOrgId;
    }

    public CreateMiniAppPluginRequest setDingOrgId(Long dingOrgId) {
        this.dingOrgId = dingOrgId;
        return this;
    }
    public Long getDingOrgId() {
        return this.dingOrgId;
    }

    public CreateMiniAppPluginRequest setDingSuiteKey(String dingSuiteKey) {
        this.dingSuiteKey = dingSuiteKey;
        return this;
    }
    public String getDingSuiteKey() {
        return this.dingSuiteKey;
    }

    public CreateMiniAppPluginRequest setDingCorpId(String dingCorpId) {
        this.dingCorpId = dingCorpId;
        return this;
    }
    public String getDingCorpId() {
        return this.dingCorpId;
    }

    public CreateMiniAppPluginRequest setDingTokenGrantType(Long dingTokenGrantType) {
        this.dingTokenGrantType = dingTokenGrantType;
        return this;
    }
    public Long getDingTokenGrantType() {
        return this.dingTokenGrantType;
    }

    public CreateMiniAppPluginRequest setDingClientId(String dingClientId) {
        this.dingClientId = dingClientId;
        return this;
    }
    public String getDingClientId() {
        return this.dingClientId;
    }

}
