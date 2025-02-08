// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkminutes_1_0.models;

import com.aliyun.tea.*;

public class DeleteMinutesResponseBody extends TeaModel {
    @NameInMap("taskUuid")
    public String taskUuid;

    public static DeleteMinutesResponseBody build(java.util.Map<String, ?> map) throws Exception {
        DeleteMinutesResponseBody self = new DeleteMinutesResponseBody();
        return TeaModel.build(map, self);
    }

    public DeleteMinutesResponseBody setTaskUuid(String taskUuid) {
        this.taskUuid = taskUuid;
        return this;
    }
    public String getTaskUuid() {
        return this.taskUuid;
    }

}
