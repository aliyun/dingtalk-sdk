// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkactivity_1_0.models;

import com.aliyun.tea.*;

public class CreateActivityResponseBody extends TeaModel {
    @NameInMap("activityId")
    public String activityId;

    public static CreateActivityResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CreateActivityResponseBody self = new CreateActivityResponseBody();
        return TeaModel.build(map, self);
    }

    public CreateActivityResponseBody setActivityId(String activityId) {
        this.activityId = activityId;
        return this;
    }
    public String getActivityId() {
        return this.activityId;
    }

}
