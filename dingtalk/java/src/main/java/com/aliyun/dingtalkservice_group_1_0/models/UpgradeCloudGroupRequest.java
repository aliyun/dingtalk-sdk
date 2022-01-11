// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class UpgradeCloudGroupRequest extends TeaModel {
    // 云客服租户id
    @NameInMap("ccsInstanceId")
    public String ccsInstanceId;

    // 钉钉群id
    @NameInMap("openConversationId")
    public String openConversationId;

    // 升级的目标群组id
    @NameInMap("openGroupSetId")
    public String openGroupSetId;

    // 升级的目标团队id
    @NameInMap("openTeamId")
    public String openTeamId;

    // 升级的目标模板id
    @NameInMap("templateId")
    public String templateId;

    public static UpgradeCloudGroupRequest build(java.util.Map<String, ?> map) throws Exception {
        UpgradeCloudGroupRequest self = new UpgradeCloudGroupRequest();
        return TeaModel.build(map, self);
    }

    public UpgradeCloudGroupRequest setCcsInstanceId(String ccsInstanceId) {
        this.ccsInstanceId = ccsInstanceId;
        return this;
    }
    public String getCcsInstanceId() {
        return this.ccsInstanceId;
    }

    public UpgradeCloudGroupRequest setOpenConversationId(String openConversationId) {
        this.openConversationId = openConversationId;
        return this;
    }
    public String getOpenConversationId() {
        return this.openConversationId;
    }

    public UpgradeCloudGroupRequest setOpenGroupSetId(String openGroupSetId) {
        this.openGroupSetId = openGroupSetId;
        return this;
    }
    public String getOpenGroupSetId() {
        return this.openGroupSetId;
    }

    public UpgradeCloudGroupRequest setOpenTeamId(String openTeamId) {
        this.openTeamId = openTeamId;
        return this;
    }
    public String getOpenTeamId() {
        return this.openTeamId;
    }

    public UpgradeCloudGroupRequest setTemplateId(String templateId) {
        this.templateId = templateId;
        return this;
    }
    public String getTemplateId() {
        return this.templateId;
    }

}
