// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalklink_1_0.models;

import com.aliyun.tea.*;

public class GetUserFollowStatusRequest extends TeaModel {
    /**
     * <p>服务窗帐号ID，可选参数。</p>
     * <p>帐号ID用于开发者应用为服务窗所属组织应用场景，此ID可以通过服务窗帐号信息查询接口获取。</p>
     */
    @NameInMap("accountId")
    public String accountId;

    /**
     * <p>待查询的服务窗关注者unionId。</p>
     */
    @NameInMap("unionId")
    public String unionId;

    /**
     * <p>待查询的服务窗关注者userId。</p>
     */
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
