// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkteam_sphere_1_0.models;

import com.aliyun.tea.*;

public class GetFreeTaskRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>0517xxx</p>
     */
    @NameInMap("userId")
    public String userId;

    public static GetFreeTaskRequest build(java.util.Map<String, ?> map) throws Exception {
        GetFreeTaskRequest self = new GetFreeTaskRequest();
        return TeaModel.build(map, self);
    }

    public GetFreeTaskRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
