// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkblackboard_1_0.models;

import com.aliyun.tea.*;

public class QueryBlackboardSpaceResponseBody extends TeaModel {
    @NameInMap("spaceId")
    public String spaceId;

    public static QueryBlackboardSpaceResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryBlackboardSpaceResponseBody self = new QueryBlackboardSpaceResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryBlackboardSpaceResponseBody setSpaceId(String spaceId) {
        this.spaceId = spaceId;
        return this;
    }
    public String getSpaceId() {
        return this.spaceId;
    }

}
