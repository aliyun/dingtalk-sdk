// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkh3yun_1_0.models;

import com.aliyun.tea.*;

public class CreateBizObjectResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public CreateBizObjectResponseBody body;

    public static CreateBizObjectResponse build(java.util.Map<String, ?> map) throws Exception {
        CreateBizObjectResponse self = new CreateBizObjectResponse();
        return TeaModel.build(map, self);
    }

    public CreateBizObjectResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CreateBizObjectResponse setBody(CreateBizObjectResponseBody body) {
        this.body = body;
        return this;
    }
    public CreateBizObjectResponseBody getBody() {
        return this.body;
    }

}
