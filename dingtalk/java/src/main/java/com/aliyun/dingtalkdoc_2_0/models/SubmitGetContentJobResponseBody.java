// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class SubmitGetContentJobResponseBody extends TeaModel {
    @NameInMap("taskId")
    public Long taskId;

    public static SubmitGetContentJobResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SubmitGetContentJobResponseBody self = new SubmitGetContentJobResponseBody();
        return TeaModel.build(map, self);
    }

    public SubmitGetContentJobResponseBody setTaskId(Long taskId) {
        this.taskId = taskId;
        return this;
    }
    public Long getTaskId() {
        return this.taskId;
    }

}
