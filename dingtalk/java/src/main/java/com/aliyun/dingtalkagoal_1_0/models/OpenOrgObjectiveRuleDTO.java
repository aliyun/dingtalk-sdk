// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkagoal_1_0.models;

import com.aliyun.tea.*;

public class OpenOrgObjectiveRuleDTO extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("objectiveRuleId")
    public String objectiveRuleId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("objectiveRuleName")
    public String objectiveRuleName;

    public static OpenOrgObjectiveRuleDTO build(java.util.Map<String, ?> map) throws Exception {
        OpenOrgObjectiveRuleDTO self = new OpenOrgObjectiveRuleDTO();
        return TeaModel.build(map, self);
    }

    public OpenOrgObjectiveRuleDTO setObjectiveRuleId(String objectiveRuleId) {
        this.objectiveRuleId = objectiveRuleId;
        return this;
    }
    public String getObjectiveRuleId() {
        return this.objectiveRuleId;
    }

    public OpenOrgObjectiveRuleDTO setObjectiveRuleName(String objectiveRuleName) {
        this.objectiveRuleName = objectiveRuleName;
        return this;
    }
    public String getObjectiveRuleName() {
        return this.objectiveRuleName;
    }

}
