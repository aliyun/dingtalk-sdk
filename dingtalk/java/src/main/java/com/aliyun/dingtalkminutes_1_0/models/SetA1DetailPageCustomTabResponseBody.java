// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkminutes_1_0.models;

import com.aliyun.tea.*;

public class SetA1DetailPageCustomTabResponseBody extends TeaModel {
    @NameInMap("taskUuid")
    public String taskUuid;

    public static SetA1DetailPageCustomTabResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SetA1DetailPageCustomTabResponseBody self = new SetA1DetailPageCustomTabResponseBody();
        return TeaModel.build(map, self);
    }

    public SetA1DetailPageCustomTabResponseBody setTaskUuid(String taskUuid) {
        this.taskUuid = taskUuid;
        return this;
    }
    public String getTaskUuid() {
        return this.taskUuid;
    }

}
