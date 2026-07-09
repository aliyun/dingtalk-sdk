// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkats_1_0.models;

import com.aliyun.tea.*;

public class ImportCandidateByResumeResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public ImportCandidateByResumeResponseBody body;

    public static ImportCandidateByResumeResponse build(java.util.Map<String, ?> map) throws Exception {
        ImportCandidateByResumeResponse self = new ImportCandidateByResumeResponse();
        return TeaModel.build(map, self);
    }

    public ImportCandidateByResumeResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ImportCandidateByResumeResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ImportCandidateByResumeResponse setBody(ImportCandidateByResumeResponseBody body) {
        this.body = body;
        return this;
    }
    public ImportCandidateByResumeResponseBody getBody() {
        return this.body;
    }

}
