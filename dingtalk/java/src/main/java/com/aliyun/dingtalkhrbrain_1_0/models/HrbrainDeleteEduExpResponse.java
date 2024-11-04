// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrbrain_1_0.models;

import com.aliyun.tea.*;

public class HrbrainDeleteEduExpResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public HrbrainDeleteEduExpResponseBody body;

    public static HrbrainDeleteEduExpResponse build(java.util.Map<String, ?> map) throws Exception {
        HrbrainDeleteEduExpResponse self = new HrbrainDeleteEduExpResponse();
        return TeaModel.build(map, self);
    }

    public HrbrainDeleteEduExpResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public HrbrainDeleteEduExpResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public HrbrainDeleteEduExpResponse setBody(HrbrainDeleteEduExpResponseBody body) {
        this.body = body;
        return this;
    }
    public HrbrainDeleteEduExpResponseBody getBody() {
        return this.body;
    }

}
