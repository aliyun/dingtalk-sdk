// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrbrain_1_0.models;

import com.aliyun.tea.*;

public class HrbrainImportEduExpResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public HrbrainImportEduExpResponseBody body;

    public static HrbrainImportEduExpResponse build(java.util.Map<String, ?> map) throws Exception {
        HrbrainImportEduExpResponse self = new HrbrainImportEduExpResponse();
        return TeaModel.build(map, self);
    }

    public HrbrainImportEduExpResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public HrbrainImportEduExpResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public HrbrainImportEduExpResponse setBody(HrbrainImportEduExpResponseBody body) {
        this.body = body;
        return this;
    }
    public HrbrainImportEduExpResponseBody getBody() {
        return this.body;
    }

}
