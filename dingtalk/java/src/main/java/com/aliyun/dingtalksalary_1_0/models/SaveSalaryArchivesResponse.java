// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalksalary_1_0.models;

import com.aliyun.tea.*;

public class SaveSalaryArchivesResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public SaveSalaryArchivesResponseBody body;

    public static SaveSalaryArchivesResponse build(java.util.Map<String, ?> map) throws Exception {
        SaveSalaryArchivesResponse self = new SaveSalaryArchivesResponse();
        return TeaModel.build(map, self);
    }

    public SaveSalaryArchivesResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SaveSalaryArchivesResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public SaveSalaryArchivesResponse setBody(SaveSalaryArchivesResponseBody body) {
        this.body = body;
        return this;
    }
    public SaveSalaryArchivesResponseBody getBody() {
        return this.body;
    }

}
