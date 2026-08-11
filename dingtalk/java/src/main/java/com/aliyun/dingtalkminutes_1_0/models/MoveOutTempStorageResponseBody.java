// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkminutes_1_0.models;

import com.aliyun.tea.*;

public class MoveOutTempStorageResponseBody extends TeaModel {
    @NameInMap("taskUuid")
    public String taskUuid;

    public static MoveOutTempStorageResponseBody build(java.util.Map<String, ?> map) throws Exception {
        MoveOutTempStorageResponseBody self = new MoveOutTempStorageResponseBody();
        return TeaModel.build(map, self);
    }

    public MoveOutTempStorageResponseBody setTaskUuid(String taskUuid) {
        this.taskUuid = taskUuid;
        return this;
    }
    public String getTaskUuid() {
        return this.taskUuid;
    }

}
