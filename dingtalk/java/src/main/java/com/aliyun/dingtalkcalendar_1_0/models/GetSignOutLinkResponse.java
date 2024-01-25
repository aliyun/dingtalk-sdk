// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcalendar_1_0.models;

import com.aliyun.tea.*;

public class GetSignOutLinkResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetSignOutLinkResponseBody body;

    public static GetSignOutLinkResponse build(java.util.Map<String, ?> map) throws Exception {
        GetSignOutLinkResponse self = new GetSignOutLinkResponse();
        return TeaModel.build(map, self);
    }

    public GetSignOutLinkResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetSignOutLinkResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetSignOutLinkResponse setBody(GetSignOutLinkResponseBody body) {
        this.body = body;
        return this;
    }
    public GetSignOutLinkResponseBody getBody() {
        return this.body;
    }

}
