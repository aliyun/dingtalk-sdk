// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkamdp_1_0.models;

import com.aliyun.tea.*;

public class AmdpEmployeeDataPushResponseBody extends TeaModel {
    @NameInMap("requestId")
    public String requestId;

    @NameInMap("result")
    public Boolean result;

    @NameInMap("status")
    public String status;

    @NameInMap("success")
    public Boolean success;

    public static AmdpEmployeeDataPushResponseBody build(java.util.Map<String, ?> map) throws Exception {
        AmdpEmployeeDataPushResponseBody self = new AmdpEmployeeDataPushResponseBody();
        return TeaModel.build(map, self);
    }

    public AmdpEmployeeDataPushResponseBody setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public AmdpEmployeeDataPushResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

    public AmdpEmployeeDataPushResponseBody setStatus(String status) {
        this.status = status;
        return this;
    }
    public String getStatus() {
        return this.status;
    }

    public AmdpEmployeeDataPushResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
