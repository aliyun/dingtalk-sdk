// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkats_1_0.models;

import com.aliyun.tea.*;

public class AddUserAccountResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public AddUserAccountResponseBody body;

    public static AddUserAccountResponse build(java.util.Map<String, ?> map) throws Exception {
        AddUserAccountResponse self = new AddUserAccountResponse();
        return TeaModel.build(map, self);
    }

    public AddUserAccountResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public AddUserAccountResponse setBody(AddUserAccountResponseBody body) {
        this.body = body;
        return this;
    }
    public AddUserAccountResponseBody getBody() {
        return this.body;
    }

}
