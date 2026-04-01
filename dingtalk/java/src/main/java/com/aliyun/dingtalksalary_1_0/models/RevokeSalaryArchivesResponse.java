// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalksalary_1_0.models;

import com.aliyun.tea.*;

public class RevokeSalaryArchivesResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public RevokeSalaryArchivesResponseBody body;

    public static RevokeSalaryArchivesResponse build(java.util.Map<String, ?> map) throws Exception {
        RevokeSalaryArchivesResponse self = new RevokeSalaryArchivesResponse();
        return TeaModel.build(map, self);
    }

    public RevokeSalaryArchivesResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public RevokeSalaryArchivesResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public RevokeSalaryArchivesResponse setBody(RevokeSalaryArchivesResponseBody body) {
        this.body = body;
        return this;
    }
    public RevokeSalaryArchivesResponseBody getBody() {
        return this.body;
    }

}
