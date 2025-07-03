// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_2_0.models;

import com.aliyun.tea.*;

public class QueryPermissionUserIdsResponseBody extends TeaModel {
    @NameInMap("dingUserIds")
    public java.util.List<String> dingUserIds;

    public static QueryPermissionUserIdsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryPermissionUserIdsResponseBody self = new QueryPermissionUserIdsResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryPermissionUserIdsResponseBody setDingUserIds(java.util.List<String> dingUserIds) {
        this.dingUserIds = dingUserIds;
        return this;
    }
    public java.util.List<String> getDingUserIds() {
        return this.dingUserIds;
    }

}
