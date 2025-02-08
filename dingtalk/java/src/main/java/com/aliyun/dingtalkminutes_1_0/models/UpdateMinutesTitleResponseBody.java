// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkminutes_1_0.models;

import com.aliyun.tea.*;

public class UpdateMinutesTitleResponseBody extends TeaModel {
    @NameInMap("taskUuid")
    public String taskUuid;

    @NameInMap("title")
    public String title;

    public static UpdateMinutesTitleResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdateMinutesTitleResponseBody self = new UpdateMinutesTitleResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdateMinutesTitleResponseBody setTaskUuid(String taskUuid) {
        this.taskUuid = taskUuid;
        return this;
    }
    public String getTaskUuid() {
        return this.taskUuid;
    }

    public UpdateMinutesTitleResponseBody setTitle(String title) {
        this.title = title;
        return this;
    }
    public String getTitle() {
        return this.title;
    }

}
