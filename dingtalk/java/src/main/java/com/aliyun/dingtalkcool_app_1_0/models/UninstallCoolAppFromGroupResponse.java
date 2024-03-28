// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcool_app_1_0.models;

import com.aliyun.tea.*;

public class UninstallCoolAppFromGroupResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public UninstallCoolAppFromGroupResponseBody body;

    public static UninstallCoolAppFromGroupResponse build(java.util.Map<String, ?> map) throws Exception {
        UninstallCoolAppFromGroupResponse self = new UninstallCoolAppFromGroupResponse();
        return TeaModel.build(map, self);
    }

    public UninstallCoolAppFromGroupResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UninstallCoolAppFromGroupResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public UninstallCoolAppFromGroupResponse setBody(UninstallCoolAppFromGroupResponseBody body) {
        this.body = body;
        return this;
    }
    public UninstallCoolAppFromGroupResponseBody getBody() {
        return this.body;
    }

}
