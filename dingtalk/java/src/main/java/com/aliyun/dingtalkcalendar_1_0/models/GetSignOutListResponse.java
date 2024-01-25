// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcalendar_1_0.models;

import com.aliyun.tea.*;

public class GetSignOutListResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetSignOutListResponseBody body;

    public static GetSignOutListResponse build(java.util.Map<String, ?> map) throws Exception {
        GetSignOutListResponse self = new GetSignOutListResponse();
        return TeaModel.build(map, self);
    }

    public GetSignOutListResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetSignOutListResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetSignOutListResponse setBody(GetSignOutListResponseBody body) {
        this.body = body;
        return this;
    }
    public GetSignOutListResponseBody getBody() {
        return this.body;
    }

}
