// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkokr_1_0.models;

import com.aliyun.tea.*;

public class UpdateKROfScoreRequest extends TeaModel {
    @NameInMap("score")
    public Long score;

    // A short description of struct
    @NameInMap("krId")
    public java.io.InputStream krId;

    @NameInMap("ownerId")
    public java.io.InputStream ownerId;

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

    public UpdateKROfScoreRequest setKrId(java.io.InputStream krId) {
        this.krId = krId;
        return this;
    }
    public java.io.InputStream getKrId() {
        return this.krId;
    }

    public UpdateKROfScoreRequest setOwnerId(java.io.InputStream ownerId) {
        this.ownerId = ownerId;
        return this;
    }
    public java.io.InputStream getOwnerId() {
        return this.ownerId;
    }

}
