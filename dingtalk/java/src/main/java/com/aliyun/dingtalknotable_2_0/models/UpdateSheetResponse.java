// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalknotable_2_0.models;

import com.aliyun.tea.*;

public class UpdateSheetResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public UpdateSheetResponseBody body;

    public static UpdateSheetResponse build(java.util.Map<String, ?> map) throws Exception {
        UpdateSheetResponse self = new UpdateSheetResponse();
        return TeaModel.build(map, self);
    }

    public UpdateSheetResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UpdateSheetResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public UpdateSheetResponse setBody(UpdateSheetResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdateSheetResponseBody getBody() {
        return this.body;
    }

}
