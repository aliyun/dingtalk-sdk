// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkagoal_1_0.models;

import com.aliyun.tea.*;

public class AgoalOrgObjectiveQueryRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>662e006fe4b0f579bbcxxxxx</p>
     */
    @NameInMap("objectiveId")
    public String objectiveId;

    public static AgoalOrgObjectiveQueryRequest build(java.util.Map<String, ?> map) throws Exception {
        AgoalOrgObjectiveQueryRequest self = new AgoalOrgObjectiveQueryRequest();
        return TeaModel.build(map, self);
    }

    public AgoalOrgObjectiveQueryRequest setObjectiveId(String objectiveId) {
        this.objectiveId = objectiveId;
        return this;
    }
    public String getObjectiveId() {
        return this.objectiveId;
    }

}
