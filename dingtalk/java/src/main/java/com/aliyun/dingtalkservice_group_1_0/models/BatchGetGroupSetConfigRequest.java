// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class BatchGetGroupSetConfigRequest extends TeaModel {
    @NameInMap("dingIsvOrgId")
    public Long dingIsvOrgId;

    @NameInMap("dingOrgId")
    public Long dingOrgId;

    @NameInMap("dingSuiteKey")
    public String dingSuiteKey;

    @NameInMap("dingTokenGrantType")
    public Long dingTokenGrantType;

    // 开放团队id
    @NameInMap("openTeamId")
    public String openTeamId;

    // 开放群组id
    @NameInMap("openGroupSetId")
    public String openGroupSetId;

    // 配置项key列表
    @NameInMap("configKeys")
    public java.util.List<String> configKeys;

    public static BatchGetGroupSetConfigRequest build(java.util.Map<String, ?> map) throws Exception {
        BatchGetGroupSetConfigRequest self = new BatchGetGroupSetConfigRequest();
        return TeaModel.build(map, self);
    }

    public BatchGetGroupSetConfigRequest setDingIsvOrgId(Long dingIsvOrgId) {
        this.dingIsvOrgId = dingIsvOrgId;
        return this;
    }
    public Long getDingIsvOrgId() {
        return this.dingIsvOrgId;
    }

    public BatchGetGroupSetConfigRequest setDingOrgId(Long dingOrgId) {
        this.dingOrgId = dingOrgId;
        return this;
    }
    public Long getDingOrgId() {
        return this.dingOrgId;
    }

    public BatchGetGroupSetConfigRequest setDingSuiteKey(String dingSuiteKey) {
        this.dingSuiteKey = dingSuiteKey;
        return this;
    }
    public String getDingSuiteKey() {
        return this.dingSuiteKey;
    }

    public BatchGetGroupSetConfigRequest setDingTokenGrantType(Long dingTokenGrantType) {
        this.dingTokenGrantType = dingTokenGrantType;
        return this;
    }
    public Long getDingTokenGrantType() {
        return this.dingTokenGrantType;
    }

    public BatchGetGroupSetConfigRequest setOpenTeamId(String openTeamId) {
        this.openTeamId = openTeamId;
        return this;
    }
    public String getOpenTeamId() {
        return this.openTeamId;
    }

    public BatchGetGroupSetConfigRequest setOpenGroupSetId(String openGroupSetId) {
        this.openGroupSetId = openGroupSetId;
        return this;
    }
    public String getOpenGroupSetId() {
        return this.openGroupSetId;
    }

    public BatchGetGroupSetConfigRequest setConfigKeys(java.util.List<String> configKeys) {
        this.configKeys = configKeys;
        return this;
    }
    public java.util.List<String> getConfigKeys() {
        return this.configKeys;
    }

}
