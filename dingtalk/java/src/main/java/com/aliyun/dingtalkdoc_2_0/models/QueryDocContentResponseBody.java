// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class QueryDocContentResponseBody extends TeaModel {
    @NameInMap("taskId")
    public Long taskId;

    public static QueryDocContentResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryDocContentResponseBody self = new QueryDocContentResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryDocContentResponseBody setTaskId(Long taskId) {
        this.taskId = taskId;
        return this;
    }
    public Long getTaskId() {
        return this.taskId;
    }

}
