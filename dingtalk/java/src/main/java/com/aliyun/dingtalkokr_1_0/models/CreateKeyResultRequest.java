// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkokr_1_0.models;

import com.aliyun.tea.*;

public class CreateKeyResultRequest extends TeaModel {
    @NameInMap("content")
    public java.io.InputStream content;

    @NameInMap("objectiveId")
    public java.io.InputStream objectiveId;

    @NameInMap("periodId")
    public java.io.InputStream periodId;

    @NameInMap("prevPosition")
    public Long prevPosition;

    @NameInMap("weight")
    public Long weight;

    @NameInMap("ownerId")
    public java.io.InputStream ownerId;

    public static CreateKeyResultRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateKeyResultRequest self = new CreateKeyResultRequest();
        return TeaModel.build(map, self);
    }

    public CreateKeyResultRequest setContent(java.io.InputStream content) {
        this.content = content;
        return this;
    }
    public java.io.InputStream getContent() {
        return this.content;
    }

    public CreateKeyResultRequest setObjectiveId(java.io.InputStream objectiveId) {
        this.objectiveId = objectiveId;
        return this;
    }
    public java.io.InputStream getObjectiveId() {
        return this.objectiveId;
    }

    public CreateKeyResultRequest setPeriodId(java.io.InputStream periodId) {
        this.periodId = periodId;
        return this;
    }
    public java.io.InputStream getPeriodId() {
        return this.periodId;
    }

    public CreateKeyResultRequest setPrevPosition(Long prevPosition) {
        this.prevPosition = prevPosition;
        return this;
    }
    public Long getPrevPosition() {
        return this.prevPosition;
    }

    public CreateKeyResultRequest setWeight(Long weight) {
        this.weight = weight;
        return this;
    }
    public Long getWeight() {
        return this.weight;
    }

    public CreateKeyResultRequest setOwnerId(java.io.InputStream ownerId) {
        this.ownerId = ownerId;
        return this;
    }
    public java.io.InputStream getOwnerId() {
        return this.ownerId;
    }

}
