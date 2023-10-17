// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class DocContentResponseBody extends TeaModel {
    @NameInMap("taskId")
    public Long taskId;

    public static DocContentResponseBody build(java.util.Map<String, ?> map) throws Exception {
        DocContentResponseBody self = new DocContentResponseBody();
        return TeaModel.build(map, self);
    }

    public DocContentResponseBody setTaskId(Long taskId) {
        this.taskId = taskId;
        return this;
    }
    public Long getTaskId() {
        return this.taskId;
    }

}
