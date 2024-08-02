// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class QueryMicroAppViewResponseBody extends TeaModel {
    @NameInMap("requestId")
    public String requestId;

    @NameInMap("result")
    public java.util.Map<String, Boolean> result;

    @NameInMap("success")
    public Boolean success;

    public static QueryMicroAppViewResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryMicroAppViewResponseBody self = new QueryMicroAppViewResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryMicroAppViewResponseBody setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public QueryMicroAppViewResponseBody setResult(java.util.Map<String, Boolean> result) {
        this.result = result;
        return this;
    }
    public java.util.Map<String, Boolean> getResult() {
        return this.result;
    }

    public QueryMicroAppViewResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
