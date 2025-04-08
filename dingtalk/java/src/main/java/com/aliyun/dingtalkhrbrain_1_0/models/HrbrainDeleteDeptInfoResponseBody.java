// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrbrain_1_0.models;

import com.aliyun.tea.*;

public class HrbrainDeleteDeptInfoResponseBody extends TeaModel {
    @NameInMap("requestId")
    public String requestId;

    @NameInMap("result")
    public Boolean result;

    @NameInMap("success")
    public Boolean success;

    public static HrbrainDeleteDeptInfoResponseBody build(java.util.Map<String, ?> map) throws Exception {
        HrbrainDeleteDeptInfoResponseBody self = new HrbrainDeleteDeptInfoResponseBody();
        return TeaModel.build(map, self);
    }

    public HrbrainDeleteDeptInfoResponseBody setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public HrbrainDeleteDeptInfoResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

    public HrbrainDeleteDeptInfoResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
