// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkagoal_1_0.models;

import com.aliyun.tea.*;

public class AgoalObjectiveKeyActionListRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>211042291978xxxx</p>
     */
    @NameInMap("dingUserId")
    public String dingUserId;

    /**
     * <strong>example:</strong>
     * <p>6444f5e9a4261c6e699dxxxx</p>
     */
    @NameInMap("keyResultId")
    public String keyResultId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>6444f5e9a4261c6e699dxxxx</p>
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
