// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class CloseConversationResponseBody extends TeaModel {
    /**
     * <p>dingOpenErrcode</p>
     */
    @NameInMap("dingOpenErrcode")
    public Integer dingOpenErrcode;

    /**
     * <p>errorMsg</p>
     */
    @NameInMap("errorMsg")
    public String errorMsg;

    /**
     * <p>result</p>
     */
    @NameInMap("result")
    public Boolean result;

    /**
     * <p>success</p>
     */
    @NameInMap("success")
    public Boolean success;

    public static CloseConversationResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CloseConversationResponseBody self = new CloseConversationResponseBody();
        return TeaModel.build(map, self);
    }

    public CloseConversationResponseBody setDingOpenErrcode(Integer dingOpenErrcode) {
        this.dingOpenErrcode = dingOpenErrcode;
        return this;
    }
    public Integer getDingOpenErrcode() {
        return this.dingOpenErrcode;
    }

    public CloseConversationResponseBody setErrorMsg(String errorMsg) {
        this.errorMsg = errorMsg;
        return this;
    }
    public String getErrorMsg() {
        return this.errorMsg;
    }

    public CloseConversationResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

    public CloseConversationResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
