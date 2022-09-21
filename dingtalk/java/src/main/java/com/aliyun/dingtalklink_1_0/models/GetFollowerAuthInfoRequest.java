// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalklink_1_0.models;

import com.aliyun.tea.*;

public class GetFollowerAuthInfoRequest extends TeaModel {
    // 服务窗帐号ID，用于非服务窗自建应用场景下指定服务窗帐号。
    @NameInMap("accountId")
    public String accountId;

    // 关注用户的userId
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
