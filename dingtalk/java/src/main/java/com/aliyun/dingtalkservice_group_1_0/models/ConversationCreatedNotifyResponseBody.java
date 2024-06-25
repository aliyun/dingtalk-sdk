// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class ConversationCreatedNotifyResponseBody extends TeaModel {
    @NameInMap("dingOpenErrcode")
    public Integer dingOpenErrcode;

    @NameInMap("errorMsg")
    public String errorMsg;

    /**
     * <strong>example:</strong>
     * <p>true</p>
     */
    @NameInMap("result")
    public Boolean result;

    /**
     * <strong>example:</strong>
     * <p>true</p>
     */
    @NameInMap("success")
    public Boolean success;

    public static ConversationCreatedNotifyResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ConversationCreatedNotifyResponseBody self = new ConversationCreatedNotifyResponseBody();
        return TeaModel.build(map, self);
    }

    public ConversationCreatedNotifyResponseBody setDingOpenErrcode(Integer dingOpenErrcode) {
        this.dingOpenErrcode = dingOpenErrcode;
        return this;
    }
    public Integer getDingOpenErrcode() {
        return this.dingOpenErrcode;
    }

    public ConversationCreatedNotifyResponseBody setErrorMsg(String errorMsg) {
        this.errorMsg = errorMsg;
        return this;
    }
    public String getErrorMsg() {
        return this.errorMsg;
    }

    public ConversationCreatedNotifyResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

    public ConversationCreatedNotifyResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
