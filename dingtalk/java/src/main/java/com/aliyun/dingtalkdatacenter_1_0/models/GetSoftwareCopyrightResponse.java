// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class GetSoftwareCopyrightResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public GetSoftwareCopyrightResponseBody body;

    public static GetSoftwareCopyrightResponse build(java.util.Map<String, ?> map) throws Exception {
        GetSoftwareCopyrightResponse self = new GetSoftwareCopyrightResponse();
        return TeaModel.build(map, self);
    }

    public GetSoftwareCopyrightResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetSoftwareCopyrightResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetSoftwareCopyrightResponse setBody(GetSoftwareCopyrightResponseBody body) {
        this.body = body;
        return this;
    }
    public GetSoftwareCopyrightResponseBody getBody() {
        return this.body;
    }

}
