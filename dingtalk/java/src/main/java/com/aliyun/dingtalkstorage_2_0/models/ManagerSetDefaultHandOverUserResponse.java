// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_2_0.models;

import com.aliyun.tea.*;

public class ManagerSetDefaultHandOverUserResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public ManagerSetDefaultHandOverUserResponseBody body;

    public static ManagerSetDefaultHandOverUserResponse build(java.util.Map<String, ?> map) throws Exception {
        ManagerSetDefaultHandOverUserResponse self = new ManagerSetDefaultHandOverUserResponse();
        return TeaModel.build(map, self);
    }

    public ManagerSetDefaultHandOverUserResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ManagerSetDefaultHandOverUserResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ManagerSetDefaultHandOverUserResponse setBody(ManagerSetDefaultHandOverUserResponseBody body) {
        this.body = body;
        return this;
    }
    public ManagerSetDefaultHandOverUserResponseBody getBody() {
        return this.body;
    }

}
