// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkattendance_1_0.models;

import com.aliyun.tea.*;

public class ReduceQuotaWithLeaveRecordResponseBody extends TeaModel {
    @NameInMap("result")
    public Boolean result;

    @NameInMap("success")
    public Boolean success;

    public static ReduceQuotaWithLeaveRecordResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ReduceQuotaWithLeaveRecordResponseBody self = new ReduceQuotaWithLeaveRecordResponseBody();
        return TeaModel.build(map, self);
    }

    public ReduceQuotaWithLeaveRecordResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

    public ReduceQuotaWithLeaveRecordResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
