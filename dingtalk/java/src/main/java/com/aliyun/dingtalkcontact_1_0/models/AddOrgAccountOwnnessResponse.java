// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class AddOrgAccountOwnnessResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public AddOrgAccountOwnnessResponseBody body;

    public static AddOrgAccountOwnnessResponse build(java.util.Map<String, ?> map) throws Exception {
        AddOrgAccountOwnnessResponse self = new AddOrgAccountOwnnessResponse();
        return TeaModel.build(map, self);
    }

    public AddOrgAccountOwnnessResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public AddOrgAccountOwnnessResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public AddOrgAccountOwnnessResponse setBody(AddOrgAccountOwnnessResponseBody body) {
        this.body = body;
        return this;
    }
    public AddOrgAccountOwnnessResponseBody getBody() {
        return this.body;
    }

}
