// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class QueryUserCredentialsRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("userIds")
    public java.util.List<String> userIds;

    public static QueryUserCredentialsRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryUserCredentialsRequest self = new QueryUserCredentialsRequest();
        return TeaModel.build(map, self);
    }

    public QueryUserCredentialsRequest setUserIds(java.util.List<String> userIds) {
        this.userIds = userIds;
        return this;
    }
    public java.util.List<String> getUserIds() {
        return this.userIds;
    }

}
