// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalklink_1_0.models;

import com.aliyun.tea.*;

public class QueryUserFollowStatusRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>ding1234</p>
     */
    @NameInMap("accountId")
    public String accountId;

    /**
     * <strong>example:</strong>
     * <p>UgIzXXo+Rp3Rqcts7BE08y49Jr6iu6xW4iQ</p>
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
