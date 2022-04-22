// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class ConversationTransferCompleteNotifyResponseBody extends TeaModel {
    // dingOpenErrcode
    @NameInMap("dingOpenErrcode")
    public Integer dingOpenErrcode;

    // errorMsg
    @NameInMap("errorMsg")
    public String errorMsg;

    // result
    @NameInMap("result")
    public Boolean result;

    // success
    @NameInMap("success")
    public Boolean success;

    public static ConversationTransferCompleteNotifyResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ConversationTransferCompleteNotifyResponseBody self = new ConversationTransferCompleteNotifyResponseBody();
        return TeaModel.build(map, self);
    }

    public ConversationTransferCompleteNotifyResponseBody setDingOpenErrcode(Integer dingOpenErrcode) {
        this.dingOpenErrcode = dingOpenErrcode;
        return this;
    }
    public Integer getDingOpenErrcode() {
        return this.dingOpenErrcode;
    }

    public ConversationTransferCompleteNotifyResponseBody setErrorMsg(String errorMsg) {
        this.errorMsg = errorMsg;
        return this;
    }
    public String getErrorMsg() {
        return this.errorMsg;
    }

    public ConversationTransferCompleteNotifyResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

    public ConversationTransferCompleteNotifyResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
