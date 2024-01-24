// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmail_1_0.models;

import com.aliyun.tea.*;

public class CreateUserResponseBody extends TeaModel {
    @NameInMap("email")
    public String email;

    public static CreateUserResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CreateUserResponseBody self = new CreateUserResponseBody();
        return TeaModel.build(map, self);
    }

    public CreateUserResponseBody setEmail(String email) {
        this.email = email;
        return this;
    }
    public String getEmail() {
        return this.email;
    }

}
