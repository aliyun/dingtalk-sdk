// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkattendance_1_0.models;

import com.aliyun.tea.*;

public class GetCheckInSchemaTemplateResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetCheckInSchemaTemplateResponseBody body;

    public static GetCheckInSchemaTemplateResponse build(java.util.Map<String, ?> map) throws Exception {
        GetCheckInSchemaTemplateResponse self = new GetCheckInSchemaTemplateResponse();
        return TeaModel.build(map, self);
    }

    public GetCheckInSchemaTemplateResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetCheckInSchemaTemplateResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetCheckInSchemaTemplateResponse setBody(GetCheckInSchemaTemplateResponseBody body) {
        this.body = body;
        return this;
    }
    public GetCheckInSchemaTemplateResponseBody getBody() {
        return this.body;
    }

}
