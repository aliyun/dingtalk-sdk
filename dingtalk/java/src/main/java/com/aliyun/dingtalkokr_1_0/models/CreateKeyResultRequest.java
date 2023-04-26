// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkokr_1_0.models;

import com.aliyun.tea.*;

public class CreateKeyResultRequest extends TeaModel {
    @NameInMap("content")
    public String content;

    @NameInMap("objectiveId")
    public String objectiveId;

    @NameInMap("periodId")
    public String periodId;

    @NameInMap("prevPosition")
    public Long prevPosition;

    @NameInMap("weight")
    public Long weight;

    @NameInMap("userId")
    public String userId;

    public static CreateKeyResultRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateKeyResultRequest self = new CreateKeyResultRequest();
        return TeaModel.build(map, self);
    }

    public CreateKeyResultRequest setContent(String content) {
        this.content = content;
        return this;
    }
    public String getContent() {
        return this.content;
    }

    public CreateKeyResultRequest setObjectiveId(String objectiveId) {
        this.objectiveId = objectiveId;
        return this;
    }
    public String getObjectiveId() {
        return this.objectiveId;
    }

    public CreateKeyResultRequest setPeriodId(String periodId) {
        this.periodId = periodId;
        return this;
    }
    public String getPeriodId() {
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

    public CreateKeyResultRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
