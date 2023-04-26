// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class GetOrganizatioTaskByIdsRequest extends TeaModel {
    @NameInMap("taskIds")
    public String taskIds;

    public static GetOrganizatioTaskByIdsRequest build(java.util.Map<String, ?> map) throws Exception {
        GetOrganizatioTaskByIdsRequest self = new GetOrganizatioTaskByIdsRequest();
        return TeaModel.build(map, self);
    }

    public GetOrganizatioTaskByIdsRequest setTaskIds(String taskIds) {
        this.taskIds = taskIds;
        return this;
    }
    public String getTaskIds() {
        return this.taskIds;
    }

}
