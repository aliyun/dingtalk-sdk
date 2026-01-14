// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkai_search_ask_1_0.models;

import com.aliyun.tea.*;

public class GetAiTaskResultRequest extends TeaModel {
    @NameInMap("taskId")
    public String taskId;

    public static GetAiTaskResultRequest build(java.util.Map<String, ?> map) throws Exception {
        GetAiTaskResultRequest self = new GetAiTaskResultRequest();
        return TeaModel.build(map, self);
    }

    public GetAiTaskResultRequest setTaskId(String taskId) {
        this.taskId = taskId;
        return this;
    }
    public String getTaskId() {
        return this.taskId;
    }

}
