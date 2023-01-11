// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class TerminateProcessInstanceResponseBody extends TeaModel {
    /**
     * <p>撤销结果。</p>
     */
    @NameInMap("result")
    public Boolean result;

    /**
     * <p>接口调用是否成功。</p>
     */
    @NameInMap("success")
    public Boolean success;

    public static TerminateProcessInstanceResponseBody build(java.util.Map<String, ?> map) throws Exception {
        TerminateProcessInstanceResponseBody self = new TerminateProcessInstanceResponseBody();
        return TeaModel.build(map, self);
    }

    public TerminateProcessInstanceResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

    public TerminateProcessInstanceResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
