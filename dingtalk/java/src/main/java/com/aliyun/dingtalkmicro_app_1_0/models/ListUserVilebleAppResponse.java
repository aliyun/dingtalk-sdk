// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmicro_app_1_0.models;

import com.aliyun.tea.*;

public class ListUserVilebleAppResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public ListUserVilebleAppResponseBody body;

    public static ListUserVilebleAppResponse build(java.util.Map<String, ?> map) throws Exception {
        ListUserVilebleAppResponse self = new ListUserVilebleAppResponse();
        return TeaModel.build(map, self);
    }

    public ListUserVilebleAppResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ListUserVilebleAppResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ListUserVilebleAppResponse setBody(ListUserVilebleAppResponseBody body) {
        this.body = body;
        return this;
    }
    public ListUserVilebleAppResponseBody getBody() {
        return this.body;
    }

}
