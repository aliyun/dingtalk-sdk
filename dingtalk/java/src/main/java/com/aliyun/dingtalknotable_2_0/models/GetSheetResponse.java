// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalknotable_2_0.models;

import com.aliyun.tea.*;

public class GetSheetResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetSheetResponseBody body;

    public static GetSheetResponse build(java.util.Map<String, ?> map) throws Exception {
        GetSheetResponse self = new GetSheetResponse();
        return TeaModel.build(map, self);
    }

    public GetSheetResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetSheetResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetSheetResponse setBody(GetSheetResponseBody body) {
        this.body = body;
        return this;
    }
    public GetSheetResponseBody getBody() {
        return this.body;
    }

}
