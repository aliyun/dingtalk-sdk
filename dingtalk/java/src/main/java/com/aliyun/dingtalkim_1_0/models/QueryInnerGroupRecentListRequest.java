// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class QueryInnerGroupRecentListRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>015*****</p>
     */
    @NameInMap("userId")
    public String userId;

    public static QueryInnerGroupRecentListRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryInnerGroupRecentListRequest self = new QueryInnerGroupRecentListRequest();
        return TeaModel.build(map, self);
    }

    public QueryInnerGroupRecentListRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
