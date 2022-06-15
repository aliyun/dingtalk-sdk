// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class GetUserInfoByOpenTokenResponseBody extends TeaModel {
    // 用户的 unionId。
    @NameInMap("unionId")
    public String unionId;

    // 用户的userId。
    @NameInMap("userId")
    public String userId;

    public static GetUserInfoByOpenTokenResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetUserInfoByOpenTokenResponseBody self = new GetUserInfoByOpenTokenResponseBody();
        return TeaModel.build(map, self);
    }

    public GetUserInfoByOpenTokenResponseBody setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

    public GetUserInfoByOpenTokenResponseBody setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
