// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdrive_1_0.models;

import com.aliyun.tea.*;

public class DeleteFilesResponseBody extends TeaModel {
    @NameInMap("success")
    public Boolean success;

    @NameInMap("taskId")
    public String taskId;

    public static DeleteFilesResponseBody build(java.util.Map<String, ?> map) throws Exception {
        DeleteFilesResponseBody self = new DeleteFilesResponseBody();
        return TeaModel.build(map, self);
    }

    public DeleteFilesResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public DeleteFilesResponseBody setTaskId(String taskId) {
        this.taskId = taskId;
        return this;
    }
    public String getTaskId() {
        return this.taskId;
    }

}
