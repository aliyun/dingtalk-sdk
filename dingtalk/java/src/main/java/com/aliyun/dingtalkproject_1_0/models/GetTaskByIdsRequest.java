// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class GetTaskByIdsRequest extends TeaModel {
    /**
     * <p>父任务ID,和taskIds冲突(选其一)。</p>
     */
    @NameInMap("parentTaskId")
    public String parentTaskId;

    /**
     * <p>任务ID集合,使用逗号分隔,和parentTaskId冲突(选其一)。</p>
     */
    @NameInMap("taskId")
    public String taskId;

    public static GetTaskByIdsRequest build(java.util.Map<String, ?> map) throws Exception {
        GetTaskByIdsRequest self = new GetTaskByIdsRequest();
        return TeaModel.build(map, self);
    }

    public GetTaskByIdsRequest setParentTaskId(String parentTaskId) {
        this.parentTaskId = parentTaskId;
        return this;
    }
    public String getParentTaskId() {
        return this.parentTaskId;
    }

    public GetTaskByIdsRequest setTaskId(String taskId) {
        this.taskId = taskId;
        return this;
    }
    public String getTaskId() {
        return this.taskId;
    }

}
