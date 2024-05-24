// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class HrmAuthResourcesQueryRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("authResourceIds")
    public java.util.List<String> authResourceIds;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("userId")
    public String userId;

    public static HrmAuthResourcesQueryRequest build(java.util.Map<String, ?> map) throws Exception {
        HrmAuthResourcesQueryRequest self = new HrmAuthResourcesQueryRequest();
        return TeaModel.build(map, self);
    }

    public HrmAuthResourcesQueryRequest setAuthResourceIds(java.util.List<String> authResourceIds) {
        this.authResourceIds = authResourceIds;
        return this;
    }
    public java.util.List<String> getAuthResourceIds() {
        return this.authResourceIds;
    }

    public HrmAuthResourcesQueryRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
