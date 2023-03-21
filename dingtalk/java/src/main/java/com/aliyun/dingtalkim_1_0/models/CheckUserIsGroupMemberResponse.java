// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class CheckUserIsGroupMemberResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public CheckUserIsGroupMemberResponseBody body;

    public static CheckUserIsGroupMemberResponse build(java.util.Map<String, ?> map) throws Exception {
        CheckUserIsGroupMemberResponse self = new CheckUserIsGroupMemberResponse();
        return TeaModel.build(map, self);
    }

    public CheckUserIsGroupMemberResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CheckUserIsGroupMemberResponse setBody(CheckUserIsGroupMemberResponseBody body) {
        this.body = body;
        return this;
    }
    public CheckUserIsGroupMemberResponseBody getBody() {
        return this.body;
    }

}
