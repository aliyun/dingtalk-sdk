// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class CustomizeContactListResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public CustomizeContactListResponseBody body;

    public static CustomizeContactListResponse build(java.util.Map<String, ?> map) throws Exception {
        CustomizeContactListResponse self = new CustomizeContactListResponse();
        return TeaModel.build(map, self);
    }

    public CustomizeContactListResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CustomizeContactListResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CustomizeContactListResponse setBody(CustomizeContactListResponseBody body) {
        this.body = body;
        return this;
    }
    public CustomizeContactListResponseBody getBody() {
        return this.body;
    }

}
