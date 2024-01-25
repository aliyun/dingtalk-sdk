// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmicro_app_1_0.models;

import com.aliyun.tea.*;

public class AnheiTest888Response extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public AnheiTest888ResponseBody body;

    public static AnheiTest888Response build(java.util.Map<String, ?> map) throws Exception {
        AnheiTest888Response self = new AnheiTest888Response();
        return TeaModel.build(map, self);
    }

    public AnheiTest888Response setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public AnheiTest888Response setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public AnheiTest888Response setBody(AnheiTest888ResponseBody body) {
        this.body = body;
        return this;
    }
    public AnheiTest888ResponseBody getBody() {
        return this.body;
    }

}
