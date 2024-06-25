// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkagoal_1_0.models;

import com.aliyun.tea.*;

public class AgoalObjectiveRulePeriodListRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>6444f5e9a4261c6e699dxxxx</p>
     */
    @NameInMap("objectiveRuleId")
    public String objectiveRuleId;

    public static AgoalObjectiveRulePeriodListRequest build(java.util.Map<String, ?> map) throws Exception {
        AgoalObjectiveRulePeriodListRequest self = new AgoalObjectiveRulePeriodListRequest();
        return TeaModel.build(map, self);
    }

    public AgoalObjectiveRulePeriodListRequest setObjectiveRuleId(String objectiveRuleId) {
        this.objectiveRuleId = objectiveRuleId;
        return this;
    }
    public String getObjectiveRuleId() {
        return this.objectiveRuleId;
    }

}
