// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class QueryUserManagementResourcesResponseBody extends TeaModel {
    @NameInMap("resourceIds")
    public java.util.List<String> resourceIds;

    public static QueryUserManagementResourcesResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryUserManagementResourcesResponseBody self = new QueryUserManagementResourcesResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryUserManagementResourcesResponseBody setResourceIds(java.util.List<String> resourceIds) {
        this.resourceIds = resourceIds;
        return this;
    }
    public java.util.List<String> getResourceIds() {
        return this.resourceIds;
    }

}
