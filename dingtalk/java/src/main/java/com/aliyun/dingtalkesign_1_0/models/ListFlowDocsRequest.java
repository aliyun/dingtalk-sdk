// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkesign_1_0.models;

import com.aliyun.tea.*;

public class ListFlowDocsRequest extends TeaModel {
    @NameInMap("taskId")
    public String taskId;

    public static ListFlowDocsRequest build(java.util.Map<String, ?> map) throws Exception {
        ListFlowDocsRequest self = new ListFlowDocsRequest();
        return TeaModel.build(map, self);
    }

    public ListFlowDocsRequest setTaskId(String taskId) {
        this.taskId = taskId;
        return this;
    }
    public String getTaskId() {
        return this.taskId;
    }

}
