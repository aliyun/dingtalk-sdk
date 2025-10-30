// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkai_global_e_c_1_0.models;

import com.aliyun.tea.*;

public class GetLoginUserRequest extends TeaModel {
    @NameInMap("authCode")
    public String authCode;

    public static GetLoginUserRequest build(java.util.Map<String, ?> map) throws Exception {
        GetLoginUserRequest self = new GetLoginUserRequest();
        return TeaModel.build(map, self);
    }

    public GetLoginUserRequest setAuthCode(String authCode) {
        this.authCode = authCode;
        return this;
    }
    public String getAuthCode() {
        return this.authCode;
    }

}
