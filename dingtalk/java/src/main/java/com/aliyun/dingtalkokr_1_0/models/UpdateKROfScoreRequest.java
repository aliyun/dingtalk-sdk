// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkokr_1_0.models;

import com.aliyun.tea.*;

public class UpdateKROfScoreRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("score")
    public Long score;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("krId")
    public String krId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("userId")
    public String userId;

    public static UpdateKROfScoreRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateKROfScoreRequest self = new UpdateKROfScoreRequest();
        return TeaModel.build(map, self);
    }

    public UpdateKROfScoreRequest setScore(Long score) {
        this.score = score;
        return this;
    }
    public Long getScore() {
        return this.score;
    }

    public UpdateKROfScoreRequest setKrId(String krId) {
        this.krId = krId;
        return this;
    }
    public String getKrId() {
        return this.krId;
    }

    public UpdateKROfScoreRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
