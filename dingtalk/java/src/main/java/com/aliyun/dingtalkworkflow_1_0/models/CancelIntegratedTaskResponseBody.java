// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class CancelIntegratedTaskResponseBody extends TeaModel {
    @NameInMap("success")
    public Boolean success;

    public static CancelIntegratedTaskResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CancelIntegratedTaskResponseBody self = new CancelIntegratedTaskResponseBody();
        return TeaModel.build(map, self);
    }

    public CancelIntegratedTaskResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
