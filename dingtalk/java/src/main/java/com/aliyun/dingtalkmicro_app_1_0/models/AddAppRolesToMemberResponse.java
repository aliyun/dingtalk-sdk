// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmicro_app_1_0.models;

import com.aliyun.tea.*;

public class AddAppRolesToMemberResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public AddAppRolesToMemberResponseBody body;

    public static AddAppRolesToMemberResponse build(java.util.Map<String, ?> map) throws Exception {
        AddAppRolesToMemberResponse self = new AddAppRolesToMemberResponse();
        return TeaModel.build(map, self);
    }

    public AddAppRolesToMemberResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public AddAppRolesToMemberResponse setBody(AddAppRolesToMemberResponseBody body) {
        this.body = body;
        return this;
    }
    public AddAppRolesToMemberResponseBody getBody() {
        return this.body;
    }

}
