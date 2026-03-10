// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkminutes_1_0.models;

import com.aliyun.tea.*;

public class SetDetailPageCustomTabResponseBody extends TeaModel {
    @NameInMap("taskUuid")
    public String taskUuid;

    public static SetDetailPageCustomTabResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SetDetailPageCustomTabResponseBody self = new SetDetailPageCustomTabResponseBody();
        return TeaModel.build(map, self);
    }

    public SetDetailPageCustomTabResponseBody setTaskUuid(String taskUuid) {
        this.taskUuid = taskUuid;
        return this;
    }
    public String getTaskUuid() {
        return this.taskUuid;
    }

}
