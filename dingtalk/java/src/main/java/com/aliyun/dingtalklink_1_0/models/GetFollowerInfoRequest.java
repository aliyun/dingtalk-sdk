// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalklink_1_0.models;

import com.aliyun.tea.*;

public class GetFollowerInfoRequest extends TeaModel {
    /**
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

    /**
     * <strong>example:</strong>
     * <p>Rp3Rqcts7BE08y49Jr6iu6xW4iQ</p>
     */
    @NameInMap("userId")
    public String userId;

    public static GetFollowerInfoRequest build(java.util.Map<String, ?> map) throws Exception {
        GetFollowerInfoRequest self = new GetFollowerInfoRequest();
        return TeaModel.build(map, self);
    }

    public GetFollowerInfoRequest setAccountId(String accountId) {
        this.accountId = accountId;
        return this;
    }
    public String getAccountId() {
        return this.accountId;
    }

    public GetFollowerInfoRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

    public GetFollowerInfoRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
