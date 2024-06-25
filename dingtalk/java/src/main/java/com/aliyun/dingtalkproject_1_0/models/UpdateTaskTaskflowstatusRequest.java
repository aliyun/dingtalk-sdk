// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class UpdateTaskTaskflowstatusRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>60a2187eb72xxxxxxx</p>
     */
    @NameInMap("taskflowStatusId")
    public String taskflowStatusId;

    /**
     * <strong>example:</strong>
     * <p>说明。</p>
     */
    @NameInMap("taskflowStatusUpdateNote")
    public String taskflowStatusUpdateNote;

    public static UpdateTaskTaskflowstatusRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateTaskTaskflowstatusRequest self = new UpdateTaskTaskflowstatusRequest();
        return TeaModel.build(map, self);
    }

    public UpdateTaskTaskflowstatusRequest setTaskflowStatusId(String taskflowStatusId) {
        this.taskflowStatusId = taskflowStatusId;
        return this;
    }
    public String getTaskflowStatusId() {
        return this.taskflowStatusId;
    }

    public UpdateTaskTaskflowstatusRequest setTaskflowStatusUpdateNote(String taskflowStatusUpdateNote) {
        this.taskflowStatusUpdateNote = taskflowStatusUpdateNote;
        return this;
    }
    public String getTaskflowStatusUpdateNote() {
        return this.taskflowStatusUpdateNote;
    }

}
