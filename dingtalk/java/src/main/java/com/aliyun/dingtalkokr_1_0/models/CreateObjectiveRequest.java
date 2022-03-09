// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkokr_1_0.models;

import com.aliyun.tea.*;

public class CreateObjectiveRequest extends TeaModel {
    // content
    @NameInMap("content")
    public java.io.InputStream content;

    // periodId
    @NameInMap("periodId")
    public java.io.InputStream periodId;

    // prevPosition
    @NameInMap("prevPosition")
    public java.io.InputStream prevPosition;

    // userId
    @NameInMap("userId")
    public String userId;

    public static CreateObjectiveRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateObjectiveRequest self = new CreateObjectiveRequest();
        return TeaModel.build(map, self);
    }

    public CreateObjectiveRequest setContent(java.io.InputStream content) {
        this.content = content;
        return this;
    }
    public java.io.InputStream getContent() {
        return this.content;
    }

    public CreateObjectiveRequest setPeriodId(java.io.InputStream periodId) {
        this.periodId = periodId;
        return this;
    }
    public java.io.InputStream getPeriodId() {
        return this.periodId;
    }

    public CreateObjectiveRequest setPrevPosition(java.io.InputStream prevPosition) {
        this.prevPosition = prevPosition;
        return this;
    }
    public java.io.InputStream getPrevPosition() {
        return this.prevPosition;
    }

    public CreateObjectiveRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
