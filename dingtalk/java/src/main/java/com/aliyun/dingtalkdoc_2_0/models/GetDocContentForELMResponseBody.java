// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class GetDocContentForELMResponseBody extends TeaModel {
    @NameInMap("taskId")
    public Long taskId;

    public static GetDocContentForELMResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetDocContentForELMResponseBody self = new GetDocContentForELMResponseBody();
        return TeaModel.build(map, self);
    }

    public GetDocContentForELMResponseBody setTaskId(Long taskId) {
        this.taskId = taskId;
        return this;
    }
    public Long getTaskId() {
        return this.taskId;
    }

}
