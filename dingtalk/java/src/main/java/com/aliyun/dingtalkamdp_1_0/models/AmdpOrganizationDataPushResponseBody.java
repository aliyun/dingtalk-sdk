// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkamdp_1_0.models;

import com.aliyun.tea.*;

public class AmdpOrganizationDataPushResponseBody extends TeaModel {
    @NameInMap("requestId")
    public String requestId;

    @NameInMap("result")
    public Boolean result;

    @NameInMap("status")
    public String status;

    @NameInMap("success")
    public Boolean success;

    public static AmdpOrganizationDataPushResponseBody build(java.util.Map<String, ?> map) throws Exception {
        AmdpOrganizationDataPushResponseBody self = new AmdpOrganizationDataPushResponseBody();
        return TeaModel.build(map, self);
    }

    public AmdpOrganizationDataPushResponseBody setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public AmdpOrganizationDataPushResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

    public AmdpOrganizationDataPushResponseBody setStatus(String status) {
        this.status = status;
        return this;
    }
    public String getStatus() {
        return this.status;
    }

    public AmdpOrganizationDataPushResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
