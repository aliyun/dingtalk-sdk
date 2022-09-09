// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class DeleteProcessRequest extends TeaModel {
    // 是否清理正在运行的任务
    @NameInMap("cleanRunningTask")
    public Boolean cleanRunningTask;

    // 模板code
    @NameInMap("processCode")
    public String processCode;

    public static DeleteProcessRequest build(java.util.Map<String, ?> map) throws Exception {
        DeleteProcessRequest self = new DeleteProcessRequest();
        return TeaModel.build(map, self);
    }

    public DeleteProcessRequest setCleanRunningTask(Boolean cleanRunningTask) {
        this.cleanRunningTask = cleanRunningTask;
        return this;
    }
    public Boolean getCleanRunningTask() {
        return this.cleanRunningTask;
    }

    public DeleteProcessRequest setProcessCode(String processCode) {
        this.processCode = processCode;
        return this;
    }
    public String getProcessCode() {
        return this.processCode;
    }

}