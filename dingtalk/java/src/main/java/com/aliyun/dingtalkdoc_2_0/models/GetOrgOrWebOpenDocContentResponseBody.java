// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class GetOrgOrWebOpenDocContentResponseBody extends TeaModel {
    @NameInMap("taskId")
    public Long taskId;

    public static GetOrgOrWebOpenDocContentResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetOrgOrWebOpenDocContentResponseBody self = new GetOrgOrWebOpenDocContentResponseBody();
        return TeaModel.build(map, self);
    }

    public GetOrgOrWebOpenDocContentResponseBody setTaskId(Long taskId) {
        this.taskId = taskId;
        return this;
    }
    public Long getTaskId() {
        return this.taskId;
    }

}
