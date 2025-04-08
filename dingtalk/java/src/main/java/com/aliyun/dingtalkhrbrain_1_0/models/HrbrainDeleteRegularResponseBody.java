// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrbrain_1_0.models;

import com.aliyun.tea.*;

public class HrbrainDeleteRegularResponseBody extends TeaModel {
    @NameInMap("requestId")
    public String requestId;

    @NameInMap("result")
    public Boolean result;

    @NameInMap("success")
    public Boolean success;

    public static HrbrainDeleteRegularResponseBody build(java.util.Map<String, ?> map) throws Exception {
        HrbrainDeleteRegularResponseBody self = new HrbrainDeleteRegularResponseBody();
        return TeaModel.build(map, self);
    }

    public HrbrainDeleteRegularResponseBody setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public HrbrainDeleteRegularResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

    public HrbrainDeleteRegularResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
