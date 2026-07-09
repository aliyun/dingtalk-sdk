// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalknotable_1_0.models;

import com.aliyun.tea.*;

public class MarkExternalAuthControlledSheetResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public MarkExternalAuthControlledSheetResponseBody body;

    public static MarkExternalAuthControlledSheetResponse build(java.util.Map<String, ?> map) throws Exception {
        MarkExternalAuthControlledSheetResponse self = new MarkExternalAuthControlledSheetResponse();
        return TeaModel.build(map, self);
    }

    public MarkExternalAuthControlledSheetResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public MarkExternalAuthControlledSheetResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public MarkExternalAuthControlledSheetResponse setBody(MarkExternalAuthControlledSheetResponseBody body) {
        this.body = body;
        return this;
    }
    public MarkExternalAuthControlledSheetResponseBody getBody() {
        return this.body;
    }

}
