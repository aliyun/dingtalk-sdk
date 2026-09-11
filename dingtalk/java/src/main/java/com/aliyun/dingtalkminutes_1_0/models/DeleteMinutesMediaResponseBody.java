// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkminutes_1_0.models;

import com.aliyun.tea.*;

public class DeleteMinutesMediaResponseBody extends TeaModel {
    @NameInMap("taskUuid")
    public String taskUuid;

    public static DeleteMinutesMediaResponseBody build(java.util.Map<String, ?> map) throws Exception {
        DeleteMinutesMediaResponseBody self = new DeleteMinutesMediaResponseBody();
        return TeaModel.build(map, self);
    }

    public DeleteMinutesMediaResponseBody setTaskUuid(String taskUuid) {
        this.taskUuid = taskUuid;
        return this;
    }
    public String getTaskUuid() {
        return this.taskUuid;
    }

}
