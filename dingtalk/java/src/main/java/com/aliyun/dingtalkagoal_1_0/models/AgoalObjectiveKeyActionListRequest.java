// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkagoal_1_0.models;

import com.aliyun.tea.*;

public class AgoalObjectiveKeyActionListRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("dingUserId")
    public String dingUserId;

    @NameInMap("keyResultId")
    public String keyResultId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("objectiveId")
    public String objectiveId;

    public static AgoalObjectiveKeyActionListRequest build(java.util.Map<String, ?> map) throws Exception {
        AgoalObjectiveKeyActionListRequest self = new AgoalObjectiveKeyActionListRequest();
        return TeaModel.build(map, self);
    }

    public AgoalObjectiveKeyActionListRequest setDingUserId(String dingUserId) {
        this.dingUserId = dingUserId;
        return this;
    }
    public String getDingUserId() {
        return this.dingUserId;
    }

    public AgoalObjectiveKeyActionListRequest setKeyResultId(String keyResultId) {
        this.keyResultId = keyResultId;
        return this;
    }
    public String getKeyResultId() {
        return this.keyResultId;
    }

    public AgoalObjectiveKeyActionListRequest setObjectiveId(String objectiveId) {
        this.objectiveId = objectiveId;
        return this;
    }
    public String getObjectiveId() {
        return this.objectiveId;
    }

}
