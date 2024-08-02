// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class QueryMicroAppStatusResponseBody extends TeaModel {
    @NameInMap("requestId")
    public String requestId;

    @NameInMap("result")
    public java.util.Map<String, ResultValue> result;

    @NameInMap("success")
    public Boolean success;

    public static QueryMicroAppStatusResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryMicroAppStatusResponseBody self = new QueryMicroAppStatusResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryMicroAppStatusResponseBody setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public QueryMicroAppStatusResponseBody setResult(java.util.Map<String, ResultValue> result) {
        this.result = result;
        return this;
    }
    public java.util.Map<String, ResultValue> getResult() {
        return this.result;
    }

    public QueryMicroAppStatusResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
