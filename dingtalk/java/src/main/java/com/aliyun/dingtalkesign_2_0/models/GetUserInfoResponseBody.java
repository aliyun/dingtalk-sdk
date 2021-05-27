// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkesign_2_0.models;

import com.aliyun.tea.*;

public class GetUserInfoResponseBody extends TeaModel {
    @NameInMap("isRealName")
    public String isRealName;

    @NameInMap("userRealName")
    public String userRealName;

    public static GetUserInfoResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetUserInfoResponseBody self = new GetUserInfoResponseBody();
        return TeaModel.build(map, self);
    }

    public GetUserInfoResponseBody setIsRealName(String isRealName) {
        this.isRealName = isRealName;
        return this;
    }
    public String getIsRealName() {
        return this.isRealName;
    }

    public GetUserInfoResponseBody setUserRealName(String userRealName) {
        this.userRealName = userRealName;
        return this;
    }
    public String getUserRealName() {
        return this.userRealName;
    }

}
