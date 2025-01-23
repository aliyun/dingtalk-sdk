// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkassistant_1_0.models;

import com.aliyun.tea.*;

public class AddToOrgSkillRepositoryRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("actionId")
    public String actionId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("actionVersion")
    public String actionVersion;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("operatorUnionId")
    public String operatorUnionId;

    public static AddToOrgSkillRepositoryRequest build(java.util.Map<String, ?> map) throws Exception {
        AddToOrgSkillRepositoryRequest self = new AddToOrgSkillRepositoryRequest();
        return TeaModel.build(map, self);
    }

    public AddToOrgSkillRepositoryRequest setActionId(String actionId) {
        this.actionId = actionId;
        return this;
    }
    public String getActionId() {
        return this.actionId;
    }

    public AddToOrgSkillRepositoryRequest setActionVersion(String actionVersion) {
        this.actionVersion = actionVersion;
        return this;
    }
    public String getActionVersion() {
        return this.actionVersion;
    }

    public AddToOrgSkillRepositoryRequest setOperatorUnionId(String operatorUnionId) {
        this.operatorUnionId = operatorUnionId;
        return this;
    }
    public String getOperatorUnionId() {
        return this.operatorUnionId;
    }

}
