// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class DelOrgAccUserOwnnessResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public DelOrgAccUserOwnnessResponseBody body;

    public static DelOrgAccUserOwnnessResponse build(java.util.Map<String, ?> map) throws Exception {
        DelOrgAccUserOwnnessResponse self = new DelOrgAccUserOwnnessResponse();
        return TeaModel.build(map, self);
    }

    public DelOrgAccUserOwnnessResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public DelOrgAccUserOwnnessResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public DelOrgAccUserOwnnessResponse setBody(DelOrgAccUserOwnnessResponseBody body) {
        this.body = body;
        return this;
    }
    public DelOrgAccUserOwnnessResponseBody getBody() {
        return this.body;
    }

}
