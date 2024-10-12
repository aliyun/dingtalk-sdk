// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkteam_sphere_1_0.models;

import com.aliyun.tea.*;

public class GetTbUserIdByDingUserIdRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("dingUserIds")
    public String dingUserIds;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>0517xxx</p>
     */
    @NameInMap("userId")
    public String userId;

    public static GetTbUserIdByDingUserIdRequest build(java.util.Map<String, ?> map) throws Exception {
        GetTbUserIdByDingUserIdRequest self = new GetTbUserIdByDingUserIdRequest();
        return TeaModel.build(map, self);
    }

    public GetTbUserIdByDingUserIdRequest setDingUserIds(String dingUserIds) {
        this.dingUserIds = dingUserIds;
        return this;
    }
    public String getDingUserIds() {
        return this.dingUserIds;
    }

    public GetTbUserIdByDingUserIdRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
