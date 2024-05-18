// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkamdp_1_0.models;

import com.aliyun.tea.*;

public class AmdpEmpRoleDataPushResponseBody extends TeaModel {
    @NameInMap("requestId")
    public String requestId;

    @NameInMap("result")
    public Boolean result;

    @NameInMap("status")
    public String status;

    @NameInMap("success")
    public Boolean success;

    public static AmdpEmpRoleDataPushResponseBody build(java.util.Map<String, ?> map) throws Exception {
        AmdpEmpRoleDataPushResponseBody self = new AmdpEmpRoleDataPushResponseBody();
        return TeaModel.build(map, self);
    }

    public AmdpEmpRoleDataPushResponseBody setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public AmdpEmpRoleDataPushResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

    public AmdpEmpRoleDataPushResponseBody setStatus(String status) {
        this.status = status;
        return this;
    }
    public String getStatus() {
        return this.status;
    }

    public AmdpEmpRoleDataPushResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
