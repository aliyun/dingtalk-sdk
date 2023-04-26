// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkchengfeng_1_0.models;

import com.aliyun.tea.*;

public class GetUserRequest extends TeaModel {
    @NameInMap("okrUserId")
    public String okrUserId;

    @NameInMap("userId")
    public String userId;

    public static GetUserRequest build(java.util.Map<String, ?> map) throws Exception {
        GetUserRequest self = new GetUserRequest();
        return TeaModel.build(map, self);
    }

    public GetUserRequest setOkrUserId(String okrUserId) {
        this.okrUserId = okrUserId;
        return this;
    }
    public String getOkrUserId() {
        return this.okrUserId;
    }

    public GetUserRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
