// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkagoal_1_0.models;

import com.aliyun.tea.*;

public class GetObjectiveDetailRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("objectiveId")
    public String objectiveId;

    public static GetObjectiveDetailRequest build(java.util.Map<String, ?> map) throws Exception {
        GetObjectiveDetailRequest self = new GetObjectiveDetailRequest();
        return TeaModel.build(map, self);
    }

    public GetObjectiveDetailRequest setObjectiveId(String objectiveId) {
        this.objectiveId = objectiveId;
        return this;
    }
    public String getObjectiveId() {
        return this.objectiveId;
    }

}
