// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class BindCoolAppToSheetResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public BindCoolAppToSheetResponseBody body;

    public static BindCoolAppToSheetResponse build(java.util.Map<String, ?> map) throws Exception {
        BindCoolAppToSheetResponse self = new BindCoolAppToSheetResponse();
        return TeaModel.build(map, self);
    }

    public BindCoolAppToSheetResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public BindCoolAppToSheetResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public BindCoolAppToSheetResponse setBody(BindCoolAppToSheetResponseBody body) {
        this.body = body;
        return this;
    }
    public BindCoolAppToSheetResponseBody getBody() {
        return this.body;
    }

}
