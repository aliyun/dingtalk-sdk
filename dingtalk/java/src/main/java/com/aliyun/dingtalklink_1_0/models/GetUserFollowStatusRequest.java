// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalklink_1_0.models;

import com.aliyun.tea.*;

public class GetUserFollowStatusRequest extends TeaModel {
    @NameInMap("accountId")
    public String accountId;

    @NameInMap("unionId")
    public String unionId;

    @NameInMap("userId")
    public String userId;

    public static GetUserFollowStatusRequest build(java.util.Map<String, ?> map) throws Exception {
        GetUserFollowStatusRequest self = new GetUserFollowStatusRequest();
        return TeaModel.build(map, self);
    }

    public GetUserFollowStatusRequest setAccountId(String accountId) {
        this.accountId = accountId;
        return this;
    }
    public String getAccountId() {
        return this.accountId;
    }

    public GetUserFollowStatusRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

    public GetUserFollowStatusRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
