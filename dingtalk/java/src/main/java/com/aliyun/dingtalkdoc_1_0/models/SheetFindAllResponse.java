// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class SheetFindAllResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public SheetFindAllResponseBody body;

    public static SheetFindAllResponse build(java.util.Map<String, ?> map) throws Exception {
        SheetFindAllResponse self = new SheetFindAllResponse();
        return TeaModel.build(map, self);
    }

    public SheetFindAllResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SheetFindAllResponse setBody(SheetFindAllResponseBody body) {
        this.body = body;
        return this;
    }
    public SheetFindAllResponseBody getBody() {
        return this.body;
    }

}
