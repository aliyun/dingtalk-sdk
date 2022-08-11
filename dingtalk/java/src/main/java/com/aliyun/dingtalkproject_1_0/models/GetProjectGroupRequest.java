// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class GetProjectGroupRequest extends TeaModel {
    // 分页大小，最小1，默认10，最大1000
    @NameInMap("pageSize")
    public Integer pageSize;

    // 查看者ID
    @NameInMap("viewerId")
    public String viewerId;

    public static GetProjectGroupRequest build(java.util.Map<String, ?> map) throws Exception {
        GetProjectGroupRequest self = new GetProjectGroupRequest();
        return TeaModel.build(map, self);
    }

    public GetProjectGroupRequest setPageSize(Integer pageSize) {
        this.pageSize = pageSize;
        return this;
    }
    public Integer getPageSize() {
        return this.pageSize;
    }

    public GetProjectGroupRequest setViewerId(String viewerId) {
        this.viewerId = viewerId;
        return this;
    }
    public String getViewerId() {
        return this.viewerId;
    }

}
