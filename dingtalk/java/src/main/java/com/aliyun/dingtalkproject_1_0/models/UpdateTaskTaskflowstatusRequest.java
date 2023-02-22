// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class UpdateTaskTaskflowstatusRequest extends TeaModel {
    /**
     * <p>任务状态ID。</p>
     */
    @NameInMap("taskflowStatusId")
    public String taskflowStatusId;

    /**
     * <p>任务流转说明。</p>
     */
    @NameInMap("tfsUpdateNote")
    public String tfsUpdateNote;

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

    public UpdateTaskTaskflowstatusRequest setTfsUpdateNote(String tfsUpdateNote) {
        this.tfsUpdateNote = tfsUpdateNote;
        return this;
    }
    public String getTfsUpdateNote() {
        return this.tfsUpdateNote;
    }

}
