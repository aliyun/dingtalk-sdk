// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class UnbindCoolAppToSheetResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public UnbindCoolAppToSheetResponseBody body;

    public static UnbindCoolAppToSheetResponse build(java.util.Map<String, ?> map) throws Exception {
        UnbindCoolAppToSheetResponse self = new UnbindCoolAppToSheetResponse();
        return TeaModel.build(map, self);
    }

    public UnbindCoolAppToSheetResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UnbindCoolAppToSheetResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public UnbindCoolAppToSheetResponse setBody(UnbindCoolAppToSheetResponseBody body) {
        this.body = body;
        return this;
    }
    public UnbindCoolAppToSheetResponseBody getBody() {
        return this.body;
    }

}
