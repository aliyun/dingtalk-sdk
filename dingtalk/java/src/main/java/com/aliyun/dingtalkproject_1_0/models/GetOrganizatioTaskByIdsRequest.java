// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class GetOrganizatioTaskByIdsRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>62a010c153c2ef5244xxxx, 62a010c153c2ef524xxxxxx</p>
     */
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
