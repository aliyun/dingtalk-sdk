// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class GetUuidByDentryIdResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetUuidByDentryIdResponseBody body;

    public static GetUuidByDentryIdResponse build(java.util.Map<String, ?> map) throws Exception {
        GetUuidByDentryIdResponse self = new GetUuidByDentryIdResponse();
        return TeaModel.build(map, self);
    }

    public GetUuidByDentryIdResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetUuidByDentryIdResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetUuidByDentryIdResponse setBody(GetUuidByDentryIdResponseBody body) {
        this.body = body;
        return this;
    }
    public GetUuidByDentryIdResponseBody getBody() {
        return this.body;
    }

}
