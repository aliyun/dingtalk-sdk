// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class ExecuteProcessInstanceResponseBody extends TeaModel {
    /**
     * <p>同意或拒绝结果。</p>
     */
    @NameInMap("result")
    public Boolean result;

    /**
     * <p>接口调用是否成功。</p>
     */
    @NameInMap("success")
    public Boolean success;

    public static ExecuteProcessInstanceResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ExecuteProcessInstanceResponseBody self = new ExecuteProcessInstanceResponseBody();
        return TeaModel.build(map, self);
    }

    public ExecuteProcessInstanceResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

    public ExecuteProcessInstanceResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
