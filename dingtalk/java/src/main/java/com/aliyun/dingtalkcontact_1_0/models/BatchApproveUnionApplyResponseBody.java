// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class BatchApproveUnionApplyResponseBody extends TeaModel {
    @NameInMap("result")
    public Boolean result;

    public static BatchApproveUnionApplyResponseBody build(java.util.Map<String, ?> map) throws Exception {
        BatchApproveUnionApplyResponseBody self = new BatchApproveUnionApplyResponseBody();
        return TeaModel.build(map, self);
    }

    public BatchApproveUnionApplyResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
