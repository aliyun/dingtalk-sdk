// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkagoal_1_0.models;

import com.aliyun.tea.*;

public class GetObjectiveRuleDetailRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("objectiveRuleId")
    public String objectiveRuleId;

    public static GetObjectiveRuleDetailRequest build(java.util.Map<String, ?> map) throws Exception {
        GetObjectiveRuleDetailRequest self = new GetObjectiveRuleDetailRequest();
        return TeaModel.build(map, self);
    }

    public GetObjectiveRuleDetailRequest setObjectiveRuleId(String objectiveRuleId) {
        this.objectiveRuleId = objectiveRuleId;
        return this;
    }
    public String getObjectiveRuleId() {
        return this.objectiveRuleId;
    }

}
