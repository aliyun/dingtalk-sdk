// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class UpgradeNormalGroupRequest extends TeaModel {
    // 群id
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

    public static UpgradeNormalGroupRequest build(java.util.Map<String, ?> map) throws Exception {
        UpgradeNormalGroupRequest self = new UpgradeNormalGroupRequest();
        return TeaModel.build(map, self);
    }

    public UpgradeNormalGroupRequest setOpenConversationId(String openConversationId) {
        this.openConversationId = openConversationId;
        return this;
    }
    public String getOpenConversationId() {
        return this.openConversationId;
    }

    public UpgradeNormalGroupRequest setOpenGroupSetId(String openGroupSetId) {
        this.openGroupSetId = openGroupSetId;
        return this;
    }
    public String getOpenGroupSetId() {
        return this.openGroupSetId;
    }

    public UpgradeNormalGroupRequest setOpenTeamId(String openTeamId) {
        this.openTeamId = openTeamId;
        return this;
    }
    public String getOpenTeamId() {
        return this.openTeamId;
    }

    public UpgradeNormalGroupRequest setTemplateId(String templateId) {
        this.templateId = templateId;
        return this;
    }
    public String getTemplateId() {
        return this.templateId;
    }

}
