// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalklink_1_0.models;

import com.aliyun.tea.*;

public class QueryUserFollowStatusRequest extends TeaModel {
    @NameInMap("accountId")
    public String accountId;

    @NameInMap("unionId")
    public String unionId;

    public static QueryUserFollowStatusRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryUserFollowStatusRequest self = new QueryUserFollowStatusRequest();
        return TeaModel.build(map, self);
    }

    public QueryUserFollowStatusRequest setAccountId(String accountId) {
        this.accountId = accountId;
        return this;
    }
    public String getAccountId() {
        return this.accountId;
    }

    public QueryUserFollowStatusRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

}
