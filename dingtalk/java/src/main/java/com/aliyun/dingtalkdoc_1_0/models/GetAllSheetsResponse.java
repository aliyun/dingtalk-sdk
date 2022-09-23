// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class GetAllSheetsResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public GetAllSheetsResponseBody body;

    public static GetAllSheetsResponse build(java.util.Map<String, ?> map) throws Exception {
        GetAllSheetsResponse self = new GetAllSheetsResponse();
        return TeaModel.build(map, self);
    }

    public GetAllSheetsResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetAllSheetsResponse setBody(GetAllSheetsResponseBody body) {
        this.body = body;
        return this;
    }
    public GetAllSheetsResponseBody getBody() {
        return this.body;
    }

}
