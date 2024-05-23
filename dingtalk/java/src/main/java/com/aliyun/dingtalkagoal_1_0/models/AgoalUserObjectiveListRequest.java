// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkagoal_1_0.models;

import com.aliyun.tea.*;

public class AgoalUserObjectiveListRequest extends TeaModel {
    @NameInMap("dingUserId")
    public String dingUserId;

    @NameInMap("objectiveRuleId")
    public String objectiveRuleId;

    @NameInMap("periodIds")
    public java.util.List<String> periodIds;

    public static AgoalUserObjectiveListRequest build(java.util.Map<String, ?> map) throws Exception {
        AgoalUserObjectiveListRequest self = new AgoalUserObjectiveListRequest();
        return TeaModel.build(map, self);
    }

    public AgoalUserObjectiveListRequest setDingUserId(String dingUserId) {
        this.dingUserId = dingUserId;
        return this;
    }
    public String getDingUserId() {
        return this.dingUserId;
    }

    public AgoalUserObjectiveListRequest setObjectiveRuleId(String objectiveRuleId) {
        this.objectiveRuleId = objectiveRuleId;
        return this;
    }
    public String getObjectiveRuleId() {
        return this.objectiveRuleId;
    }

    public AgoalUserObjectiveListRequest setPeriodIds(java.util.List<String> periodIds) {
        this.periodIds = periodIds;
        return this;
    }
    public java.util.List<String> getPeriodIds() {
        return this.periodIds;
    }

}
