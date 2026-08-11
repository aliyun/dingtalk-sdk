// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class GetUserByDingTalkIdResponseBody extends TeaModel {
    @NameInMap("userId")
    public String userId;

    public static GetUserByDingTalkIdResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetUserByDingTalkIdResponseBody self = new GetUserByDingTalkIdResponseBody();
        return TeaModel.build(map, self);
    }

    public GetUserByDingTalkIdResponseBody setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
