// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalklink_1_0.models;

import com.aliyun.tea.*;

public class QueryUserFollowStatusRequest extends TeaModel {
    /**
     * <p>服务窗帐号ID，此ID可以通过服务窗帐号信息查询接口获取。</p>
     */
    @NameInMap("accountId")
    public String accountId;

    /**
     * <p>待查询的服务窗关注者unionId。</p>
     */
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
