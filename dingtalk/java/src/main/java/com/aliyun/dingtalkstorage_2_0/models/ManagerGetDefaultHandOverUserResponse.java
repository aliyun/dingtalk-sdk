// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_2_0.models;

import com.aliyun.tea.*;

public class ManagerGetDefaultHandOverUserResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public ManagerGetDefaultHandOverUserResponseBody body;

    public static ManagerGetDefaultHandOverUserResponse build(java.util.Map<String, ?> map) throws Exception {
        ManagerGetDefaultHandOverUserResponse self = new ManagerGetDefaultHandOverUserResponse();
        return TeaModel.build(map, self);
    }

    public ManagerGetDefaultHandOverUserResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ManagerGetDefaultHandOverUserResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ManagerGetDefaultHandOverUserResponse setBody(ManagerGetDefaultHandOverUserResponseBody body) {
        this.body = body;
        return this;
    }
    public ManagerGetDefaultHandOverUserResponseBody getBody() {
        return this.body;
    }

}
