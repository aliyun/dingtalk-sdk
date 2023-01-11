// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class RedirectWorkflowTaskResponseBody extends TeaModel {
    /**
     * <p>是否转交成功</p>
     */
    @NameInMap("result")
    public Boolean result;

    public static RedirectWorkflowTaskResponseBody build(java.util.Map<String, ?> map) throws Exception {
        RedirectWorkflowTaskResponseBody self = new RedirectWorkflowTaskResponseBody();
        return TeaModel.build(map, self);
    }

    public RedirectWorkflowTaskResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
