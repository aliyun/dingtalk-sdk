// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class GetWorkCopyrightResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetWorkCopyrightResponseBody body;

    public static GetWorkCopyrightResponse build(java.util.Map<String, ?> map) throws Exception {
        GetWorkCopyrightResponse self = new GetWorkCopyrightResponse();
        return TeaModel.build(map, self);
    }

    public GetWorkCopyrightResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetWorkCopyrightResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetWorkCopyrightResponse setBody(GetWorkCopyrightResponseBody body) {
        this.body = body;
        return this;
    }
    public GetWorkCopyrightResponseBody getBody() {
        return this.body;
    }

}
