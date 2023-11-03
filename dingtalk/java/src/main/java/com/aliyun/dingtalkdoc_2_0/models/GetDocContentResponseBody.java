// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class GetDocContentResponseBody extends TeaModel {
    @NameInMap("taskId")
    public Long taskId;

    public static GetDocContentResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetDocContentResponseBody self = new GetDocContentResponseBody();
        return TeaModel.build(map, self);
    }

    public GetDocContentResponseBody setTaskId(Long taskId) {
        this.taskId = taskId;
        return this;
    }
    public Long getTaskId() {
        return this.taskId;
    }

}
