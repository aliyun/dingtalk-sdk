// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkbench_1_0.models;

import com.aliyun.tea.*;

public class AddRecentUserAppListResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public AddRecentUserAppListResponseBody body;

    public static AddRecentUserAppListResponse build(java.util.Map<String, ?> map) throws Exception {
        AddRecentUserAppListResponse self = new AddRecentUserAppListResponse();
        return TeaModel.build(map, self);
    }

    public AddRecentUserAppListResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public AddRecentUserAppListResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public AddRecentUserAppListResponse setBody(AddRecentUserAppListResponseBody body) {
        this.body = body;
        return this;
    }
    public AddRecentUserAppListResponseBody getBody() {
        return this.body;
    }

}
