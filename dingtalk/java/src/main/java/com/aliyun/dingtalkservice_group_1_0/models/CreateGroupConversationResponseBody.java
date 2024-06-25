// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class CreateGroupConversationResponseBody extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>500</p>
     */
    @NameInMap("dingOpenErrcode")
    public Integer dingOpenErrcode;

    /**
     * <strong>example:</strong>
     * <p>SYSTEM_ERROR</p>
     */
    @NameInMap("errorMsg")
    public String errorMsg;

    /**
     * <strong>example:</strong>
     * <p>true</p>
     */
    @NameInMap("result")
    public String result;

    /**
     * <strong>example:</strong>
     * <p>true</p>
     */
    @NameInMap("success")
    public Boolean success;

    public static CreateGroupConversationResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CreateGroupConversationResponseBody self = new CreateGroupConversationResponseBody();
        return TeaModel.build(map, self);
    }

    public CreateGroupConversationResponseBody setDingOpenErrcode(Integer dingOpenErrcode) {
        this.dingOpenErrcode = dingOpenErrcode;
        return this;
    }
    public Integer getDingOpenErrcode() {
        return this.dingOpenErrcode;
    }

    public CreateGroupConversationResponseBody setErrorMsg(String errorMsg) {
        this.errorMsg = errorMsg;
        return this;
    }
    public String getErrorMsg() {
        return this.errorMsg;
    }

    public CreateGroupConversationResponseBody setResult(String result) {
        this.result = result;
        return this;
    }
    public String getResult() {
        return this.result;
    }

    public CreateGroupConversationResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
