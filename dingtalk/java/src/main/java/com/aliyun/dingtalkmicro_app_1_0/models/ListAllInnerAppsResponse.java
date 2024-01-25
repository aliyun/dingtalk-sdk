// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmicro_app_1_0.models;

import com.aliyun.tea.*;

public class ListAllInnerAppsResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public ListAllInnerAppsResponseBody body;

    public static ListAllInnerAppsResponse build(java.util.Map<String, ?> map) throws Exception {
        ListAllInnerAppsResponse self = new ListAllInnerAppsResponse();
        return TeaModel.build(map, self);
    }

    public ListAllInnerAppsResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ListAllInnerAppsResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ListAllInnerAppsResponse setBody(ListAllInnerAppsResponseBody body) {
        this.body = body;
        return this;
    }
    public ListAllInnerAppsResponseBody getBody() {
        return this.body;
    }

}
