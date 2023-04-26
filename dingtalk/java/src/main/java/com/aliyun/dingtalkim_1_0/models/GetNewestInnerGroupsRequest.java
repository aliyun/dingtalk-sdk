// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class GetNewestInnerGroupsRequest extends TeaModel {
    @NameInMap("userId")
    public String userId;

    public static GetNewestInnerGroupsRequest build(java.util.Map<String, ?> map) throws Exception {
        GetNewestInnerGroupsRequest self = new GetNewestInnerGroupsRequest();
        return TeaModel.build(map, self);
    }

    public GetNewestInnerGroupsRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
