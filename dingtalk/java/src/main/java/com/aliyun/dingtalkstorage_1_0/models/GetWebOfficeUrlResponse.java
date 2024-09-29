// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_1_0.models;

import com.aliyun.tea.*;

public class GetWebOfficeUrlResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetWebOfficeUrlResponseBody body;

    public static GetWebOfficeUrlResponse build(java.util.Map<String, ?> map) throws Exception {
        GetWebOfficeUrlResponse self = new GetWebOfficeUrlResponse();
        return TeaModel.build(map, self);
    }

    public GetWebOfficeUrlResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetWebOfficeUrlResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetWebOfficeUrlResponse setBody(GetWebOfficeUrlResponseBody body) {
        this.body = body;
        return this;
    }
    public GetWebOfficeUrlResponseBody getBody() {
        return this.body;
    }

}
