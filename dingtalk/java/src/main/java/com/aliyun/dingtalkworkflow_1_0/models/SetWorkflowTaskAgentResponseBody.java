// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class SetWorkflowTaskAgentResponseBody extends TeaModel {
    @NameInMap("dingOpenErrcode")
    public Integer dingOpenErrcode;

    @NameInMap("errorMsg")
    public String errorMsg;

    @NameInMap("result")
    public Long result;

    @NameInMap("success")
    public Boolean success;

    public static SetWorkflowTaskAgentResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SetWorkflowTaskAgentResponseBody self = new SetWorkflowTaskAgentResponseBody();
        return TeaModel.build(map, self);
    }

    public SetWorkflowTaskAgentResponseBody setDingOpenErrcode(Integer dingOpenErrcode) {
        this.dingOpenErrcode = dingOpenErrcode;
        return this;
    }
    public Integer getDingOpenErrcode() {
        return this.dingOpenErrcode;
    }

    public SetWorkflowTaskAgentResponseBody setErrorMsg(String errorMsg) {
        this.errorMsg = errorMsg;
        return this;
    }
    public String getErrorMsg() {
        return this.errorMsg;
    }

    public SetWorkflowTaskAgentResponseBody setResult(Long result) {
        this.result = result;
        return this;
    }
    public Long getResult() {
        return this.result;
    }

    public SetWorkflowTaskAgentResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
