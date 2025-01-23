// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkassistant_1_0.models;

import com.aliyun.tea.*;

public class RemoveFromOrgSkillRepositoryRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("actionId")
    public String actionId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("operatorUnionId")
    public String operatorUnionId;

    public static RemoveFromOrgSkillRepositoryRequest build(java.util.Map<String, ?> map) throws Exception {
        RemoveFromOrgSkillRepositoryRequest self = new RemoveFromOrgSkillRepositoryRequest();
        return TeaModel.build(map, self);
    }

    public RemoveFromOrgSkillRepositoryRequest setActionId(String actionId) {
        this.actionId = actionId;
        return this;
    }
    public String getActionId() {
        return this.actionId;
    }

    public RemoveFromOrgSkillRepositoryRequest setOperatorUnionId(String operatorUnionId) {
        this.operatorUnionId = operatorUnionId;
        return this;
    }
    public String getOperatorUnionId() {
        return this.operatorUnionId;
    }

}
