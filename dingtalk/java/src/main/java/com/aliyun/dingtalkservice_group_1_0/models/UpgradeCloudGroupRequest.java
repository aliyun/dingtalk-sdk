// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class UpgradeCloudGroupRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>sdfdfser</p>
     */
    @NameInMap("ccsInstanceId")
    public String ccsInstanceId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>cidrQnTVXH/X+ERaVqGaH+asw==</p>
     */
    @NameInMap("openConversationId")
    public String openConversationId;

    /**
     * <strong>example:</strong>
     * <p>oPnDlfVYYIUia</p>
     */
    @NameInMap("openGroupSetId")
    public String openGroupSetId;

    /**
     * <strong>example:</strong>
     * <p>btkoYsadwyQiE</p>
     */
    @NameInMap("openTeamId")
    public String openTeamId;

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
