// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalknotable_1_0.models;

import com.aliyun.tea.*;

public class UnmarkExternalAuthControlledSheetResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public UnmarkExternalAuthControlledSheetResponseBody body;

    public static UnmarkExternalAuthControlledSheetResponse build(java.util.Map<String, ?> map) throws Exception {
        UnmarkExternalAuthControlledSheetResponse self = new UnmarkExternalAuthControlledSheetResponse();
        return TeaModel.build(map, self);
    }

    public UnmarkExternalAuthControlledSheetResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UnmarkExternalAuthControlledSheetResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public UnmarkExternalAuthControlledSheetResponse setBody(UnmarkExternalAuthControlledSheetResponseBody body) {
        this.body = body;
        return this;
    }
    public UnmarkExternalAuthControlledSheetResponseBody getBody() {
        return this.body;
    }

}
