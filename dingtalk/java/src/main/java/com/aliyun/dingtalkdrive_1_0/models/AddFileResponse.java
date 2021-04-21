// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdrive_1_0.models;

import com.aliyun.tea.*;

public class AddFileResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public AddFileResponseBody body;

    public static AddFileResponse build(java.util.Map<String, ?> map) throws Exception {
        AddFileResponse self = new AddFileResponse();
        return TeaModel.build(map, self);
    }

    public AddFileResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public AddFileResponse setBody(AddFileResponseBody body) {
        this.body = body;
        return this;
    }
    public AddFileResponseBody getBody() {
        return this.body;
    }

}
