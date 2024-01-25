// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmicro_app_1_0.models;

import com.aliyun.tea.*;

public class AddAppRolesToMemberResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
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

    public AddAppRolesToMemberResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public AddAppRolesToMemberResponse setBody(AddAppRolesToMemberResponseBody body) {
        this.body = body;
        return this;
    }
    public AddAppRolesToMemberResponseBody getBody() {
        return this.body;
    }

}
