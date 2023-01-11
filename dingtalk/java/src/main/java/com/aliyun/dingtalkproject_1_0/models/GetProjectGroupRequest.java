// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class GetProjectGroupRequest extends TeaModel {
    /**
     * <p>分页大小，最小1，默认10，最大1000</p>
     */
    @NameInMap("pageSize")
    public Integer pageSize;

    /**
     * <p>查看者ID</p>
     */
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
