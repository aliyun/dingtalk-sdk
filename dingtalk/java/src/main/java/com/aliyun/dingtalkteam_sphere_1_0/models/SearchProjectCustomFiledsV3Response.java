// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkteam_sphere_1_0.models;

import com.aliyun.tea.*;

public class SearchProjectCustomFiledsV3Response extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public SearchProjectCustomFiledsV3ResponseBody body;

    public static SearchProjectCustomFiledsV3Response build(java.util.Map<String, ?> map) throws Exception {
        SearchProjectCustomFiledsV3Response self = new SearchProjectCustomFiledsV3Response();
        return TeaModel.build(map, self);
    }

    public SearchProjectCustomFiledsV3Response setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SearchProjectCustomFiledsV3Response setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public SearchProjectCustomFiledsV3Response setBody(SearchProjectCustomFiledsV3ResponseBody body) {
        this.body = body;
        return this;
    }
    public SearchProjectCustomFiledsV3ResponseBody getBody() {
        return this.body;
    }

}
