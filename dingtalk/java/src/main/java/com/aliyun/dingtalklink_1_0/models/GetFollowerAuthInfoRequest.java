// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalklink_1_0.models;

import com.aliyun.tea.*;

public class GetFollowerAuthInfoRequest extends TeaModel {
    @NameInMap("accountId")
    public String accountId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("userId")
    public String userId;

    public static GetFollowerAuthInfoRequest build(java.util.Map<String, ?> map) throws Exception {
        GetFollowerAuthInfoRequest self = new GetFollowerAuthInfoRequest();
        return TeaModel.build(map, self);
    }

    public GetFollowerAuthInfoRequest setAccountId(String accountId) {
        this.accountId = accountId;
        return this;
    }
    public String getAccountId() {
        return this.accountId;
    }

    public GetFollowerAuthInfoRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
