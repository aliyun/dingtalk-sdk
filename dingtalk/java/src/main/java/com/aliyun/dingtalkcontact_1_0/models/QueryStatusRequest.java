// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class QueryStatusRequest extends TeaModel {
    @NameInMap("userId")
    public String userId;

    public static QueryStatusRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryStatusRequest self = new QueryStatusRequest();
        return TeaModel.build(map, self);
    }

    public QueryStatusRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
