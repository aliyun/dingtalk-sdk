// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkminutes_1_0.models;

import com.aliyun.tea.*;

public class SetMinutesTodosVisibleResponseBody extends TeaModel {
    @NameInMap("taskUuid")
    public String taskUuid;

    @NameInMap("todosVisible")
    public Boolean todosVisible;

    public static SetMinutesTodosVisibleResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SetMinutesTodosVisibleResponseBody self = new SetMinutesTodosVisibleResponseBody();
        return TeaModel.build(map, self);
    }

    public SetMinutesTodosVisibleResponseBody setTaskUuid(String taskUuid) {
        this.taskUuid = taskUuid;
        return this;
    }
    public String getTaskUuid() {
        return this.taskUuid;
    }

    public SetMinutesTodosVisibleResponseBody setTodosVisible(Boolean todosVisible) {
        this.todosVisible = todosVisible;
        return this;
    }
    public Boolean getTodosVisible() {
        return this.todosVisible;
    }

}
