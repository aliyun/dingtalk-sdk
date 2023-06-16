// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkding_phone_1_0.models;

import com.aliyun.tea.*;

public class AddCallConfigResponseBody extends TeaModel {
    @NameInMap("token")
    public String token;

    public static AddCallConfigResponseBody build(java.util.Map<String, ?> map) throws Exception {
        AddCallConfigResponseBody self = new AddCallConfigResponseBody();
        return TeaModel.build(map, self);
    }

    public AddCallConfigResponseBody setToken(String token) {
        this.token = token;
        return this;
    }
    public String getToken() {
        return this.token;
    }

}
