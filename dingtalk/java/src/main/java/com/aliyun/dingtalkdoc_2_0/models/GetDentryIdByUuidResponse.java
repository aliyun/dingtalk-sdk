// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class GetDentryIdByUuidResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public GetDentryIdByUuidResponseBody body;

    public static GetDentryIdByUuidResponse build(java.util.Map<String, ?> map) throws Exception {
        GetDentryIdByUuidResponse self = new GetDentryIdByUuidResponse();
        return TeaModel.build(map, self);
    }

    public GetDentryIdByUuidResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetDentryIdByUuidResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetDentryIdByUuidResponse setBody(GetDentryIdByUuidResponseBody body) {
        this.body = body;
        return this;
    }
    public GetDentryIdByUuidResponseBody getBody() {
        return this.body;
    }

}
