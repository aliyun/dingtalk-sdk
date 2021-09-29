// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class UpgradeCloudGroupRequest extends TeaModel {
    // 钉钉群id
    @NameInMap("openConversationId")
    public String openConversationId;

    // 升级的目标模板id
    @NameInMap("templateId")
    public String templateId;

    // 升级的目标群组id
    @NameInMap("openGroupSetId")
    public String openGroupSetId;

    // 云客服租户id
    @NameInMap("ccsInstanceId")
    public String ccsInstanceId;

    @NameInMap("dingOrgId")
    public Long dingOrgId;

    @NameInMap("dingSuiteKey")
    public String dingSuiteKey;

    @NameInMap("dingTokenGrantType")
    public Long dingTokenGrantType;

    @NameInMap("dingIsvOrgId")
    public Long dingIsvOrgId;

    // 升级的目标团队id
    @NameInMap("openTeamId")
    public String openTeamId;

    public static UpgradeCloudGroupRequest build(java.util.Map<String, ?> map) throws Exception {
        UpgradeCloudGroupRequest self = new UpgradeCloudGroupRequest();
        return TeaModel.build(map, self);
    }

    public UpgradeCloudGroupRequest setOpenConversationId(String openConversationId) {
        this.openConversationId = openConversationId;
        return this;
    }
    public String getOpenConversationId() {
        return this.openConversationId;
    }

    public UpgradeCloudGroupRequest setTemplateId(String templateId) {
        this.templateId = templateId;
        return this;
    }
    public String getTemplateId() {
        return this.templateId;
    }

    public UpgradeCloudGroupRequest setOpenGroupSetId(String openGroupSetId) {
        this.openGroupSetId = openGroupSetId;
        return this;
    }
    public String getOpenGroupSetId() {
        return this.openGroupSetId;
    }

    public UpgradeCloudGroupRequest setCcsInstanceId(String ccsInstanceId) {
        this.ccsInstanceId = ccsInstanceId;
        return this;
    }
    public String getCcsInstanceId() {
        return this.ccsInstanceId;
    }

    public UpgradeCloudGroupRequest setDingOrgId(Long dingOrgId) {
        this.dingOrgId = dingOrgId;
        return this;
    }
    public Long getDingOrgId() {
        return this.dingOrgId;
    }

    public UpgradeCloudGroupRequest setDingSuiteKey(String dingSuiteKey) {
        this.dingSuiteKey = dingSuiteKey;
        return this;
    }
    public String getDingSuiteKey() {
        return this.dingSuiteKey;
    }

    public UpgradeCloudGroupRequest setDingTokenGrantType(Long dingTokenGrantType) {
        this.dingTokenGrantType = dingTokenGrantType;
        return this;
    }
    public Long getDingTokenGrantType() {
        return this.dingTokenGrantType;
    }

    public UpgradeCloudGroupRequest setDingIsvOrgId(Long dingIsvOrgId) {
        this.dingIsvOrgId = dingIsvOrgId;
        return this;
    }
    public Long getDingIsvOrgId() {
        return this.dingIsvOrgId;
    }

    public UpgradeCloudGroupRequest setOpenTeamId(String openTeamId) {
        this.openTeamId = openTeamId;
        return this;
    }
    public String getOpenTeamId() {
        return this.openTeamId;
    }

}
