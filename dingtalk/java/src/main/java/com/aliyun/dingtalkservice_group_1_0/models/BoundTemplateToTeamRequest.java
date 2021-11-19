// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class BoundTemplateToTeamRequest extends TeaModel {
    @NameInMap("dingOrgId")
    public Long dingOrgId;

    @NameInMap("dingSuiteKey")
    public String dingSuiteKey;

    @NameInMap("dingTokenGrantType")
    public Long dingTokenGrantType;

    @NameInMap("dingIsvOrgId")
    public Long dingIsvOrgId;

    // 目标团队id
    @NameInMap("openTeamId")
    public String openTeamId;

    // 模板id
    @NameInMap("templateId")
    public String templateId;

    // 模板名字
    @NameInMap("templateName")
    public String templateName;

    // 模板类型
    @NameInMap("templateType")
    public String templateType;

    // 模板描述信息
    @NameInMap("templateDesc")
    public String templateDesc;

    // 模板中的机器人配置信息
    @NameInMap("robotConfig")
    public String robotConfig;

    public static BoundTemplateToTeamRequest build(java.util.Map<String, ?> map) throws Exception {
        BoundTemplateToTeamRequest self = new BoundTemplateToTeamRequest();
        return TeaModel.build(map, self);
    }

    public BoundTemplateToTeamRequest setDingOrgId(Long dingOrgId) {
        this.dingOrgId = dingOrgId;
        return this;
    }
    public Long getDingOrgId() {
        return this.dingOrgId;
    }

    public BoundTemplateToTeamRequest setDingSuiteKey(String dingSuiteKey) {
        this.dingSuiteKey = dingSuiteKey;
        return this;
    }
    public String getDingSuiteKey() {
        return this.dingSuiteKey;
    }

    public BoundTemplateToTeamRequest setDingTokenGrantType(Long dingTokenGrantType) {
        this.dingTokenGrantType = dingTokenGrantType;
        return this;
    }
    public Long getDingTokenGrantType() {
        return this.dingTokenGrantType;
    }

    public BoundTemplateToTeamRequest setDingIsvOrgId(Long dingIsvOrgId) {
        this.dingIsvOrgId = dingIsvOrgId;
        return this;
    }
    public Long getDingIsvOrgId() {
        return this.dingIsvOrgId;
    }

    public BoundTemplateToTeamRequest setOpenTeamId(String openTeamId) {
        this.openTeamId = openTeamId;
        return this;
    }
    public String getOpenTeamId() {
        return this.openTeamId;
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

    public BoundTemplateToTeamRequest setTemplateDesc(String templateDesc) {
        this.templateDesc = templateDesc;
        return this;
    }
    public String getTemplateDesc() {
        return this.templateDesc;
    }

    public BoundTemplateToTeamRequest setRobotConfig(String robotConfig) {
        this.robotConfig = robotConfig;
        return this;
    }
    public String getRobotConfig() {
        return this.robotConfig;
    }

}
