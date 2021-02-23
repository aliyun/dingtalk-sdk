// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkesign_1_0.models;

import com.aliyun.tea.*;

public class ListSealApprovalRequest extends TeaModel {
    @NameInMap("taskId")
    public String taskId;

    public static ListSealApprovalRequest build(java.util.Map<String, ?> map) throws Exception {
        ListSealApprovalRequest self = new ListSealApprovalRequest();
        return TeaModel.build(map, self);
    }

    public ListSealApprovalRequest setTaskId(String taskId) {
        this.taskId = taskId;
        return this;
    }
    public String getTaskId() {
        return this.taskId;
    }

}
