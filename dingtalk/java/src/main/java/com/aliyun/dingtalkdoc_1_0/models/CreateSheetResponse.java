// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class CreateSheetResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public CreateSheetResponseBody body;

    public static CreateSheetResponse build(java.util.Map<String, ?> map) throws Exception {
        CreateSheetResponse self = new CreateSheetResponse();
        return TeaModel.build(map, self);
    }

    public CreateSheetResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CreateSheetResponse setBody(CreateSheetResponseBody body) {
        this.body = body;
        return this;
    }
    public CreateSheetResponseBody getBody() {
        return this.body;
    }

}
