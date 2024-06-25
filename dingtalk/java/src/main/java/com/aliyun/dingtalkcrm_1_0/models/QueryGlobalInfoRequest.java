// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class QueryGlobalInfoRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>301227837938</p>
     */
    @NameInMap("userId")
    public String userId;

    public static QueryGlobalInfoRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryGlobalInfoRequest self = new QueryGlobalInfoRequest();
        return TeaModel.build(map, self);
    }

    public QueryGlobalInfoRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
