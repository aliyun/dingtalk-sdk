// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkokr_1_0.models;

import com.aliyun.tea.*;

public class CreateObjectiveRequest extends TeaModel {
    // 创建Objective 的内容
    @NameInMap("content")
    public String content;

    // 当前周期 ID。
    @NameInMap("periodId")
    public String periodId;

    // 上一个 Objective 的位置。
    @NameInMap("prevPosition")
    public String prevPosition;

    // 当前用户的 userId。
    @NameInMap("userId")
    public String userId;

    public static CreateObjectiveRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateObjectiveRequest self = new CreateObjectiveRequest();
        return TeaModel.build(map, self);
    }

    public CreateObjectiveRequest setContent(String content) {
        this.content = content;
        return this;
    }
    public String getContent() {
        return this.content;
    }

    public CreateObjectiveRequest setPeriodId(String periodId) {
        this.periodId = periodId;
        return this;
    }
    public String getPeriodId() {
        return this.periodId;
    }

    public CreateObjectiveRequest setPrevPosition(String prevPosition) {
        this.prevPosition = prevPosition;
        return this;
    }
    public String getPrevPosition() {
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
