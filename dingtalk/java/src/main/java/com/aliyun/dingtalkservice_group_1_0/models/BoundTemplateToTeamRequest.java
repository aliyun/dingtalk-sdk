// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class BoundTemplateToTeamRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("openTeamId")
    public String openTeamId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("robotConfig")
    public String robotConfig;

    @NameInMap("templateDesc")
    public String templateDesc;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("templateId")
    public String templateId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("templateName")
    public String templateName;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("templateType")
    public String templateType;

    public static BoundTemplateToTeamRequest build(java.util.Map<String, ?> map) throws Exception {
        BoundTemplateToTeamRequest self = new BoundTemplateToTeamRequest();
        return TeaModel.build(map, self);
    }

    public BoundTemplateToTeamRequest setOpenTeamId(String openTeamId) {
        this.openTeamId = openTeamId;
        return this;
    }
    public String getOpenTeamId() {
        return this.openTeamId;
    }

    public BoundTemplateToTeamRequest setRobotConfig(String robotConfig) {
        this.robotConfig = robotConfig;
        return this;
    }
    public String getRobotConfig() {
        return this.robotConfig;
    }

    public BoundTemplateToTeamRequest setTemplateDesc(String templateDesc) {
        this.templateDesc = templateDesc;
        return this;
    }
    public String getTemplateDesc() {
        return this.templateDesc;
    }

    public BoundTemplateToTeamRequest setTemplateId(String templateId) {
        this.templateId = templateId;
        return this;
    }
    public String getTemplateId() {
        return this.templateId;
    }

    public BoundTemplateToTeamRequest setTemplateName(String templateName) {
        this.templateName = templateName;
        return this;
    }
    public String getTemplateName() {
        return this.templateName;
    }

    public BoundTemplateToTeamRequest setTemplateType(String templateType) {
        this.templateType = templateType;
        return this;
    }
    public String getTemplateType() {
        return this.templateType;
    }

}
