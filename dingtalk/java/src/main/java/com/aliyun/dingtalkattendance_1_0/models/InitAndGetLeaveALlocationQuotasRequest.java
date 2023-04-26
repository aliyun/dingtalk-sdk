// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkattendance_1_0.models;

import com.aliyun.tea.*;

public class InitAndGetLeaveALlocationQuotasRequest extends TeaModel {
    @NameInMap("leaveCode")
    public String leaveCode;

    @NameInMap("opUserId")
    public String opUserId;

    @NameInMap("userId")
    public String userId;

    public static InitAndGetLeaveALlocationQuotasRequest build(java.util.Map<String, ?> map) throws Exception {
        InitAndGetLeaveALlocationQuotasRequest self = new InitAndGetLeaveALlocationQuotasRequest();
        return TeaModel.build(map, self);
    }

    public InitAndGetLeaveALlocationQuotasRequest setLeaveCode(String leaveCode) {
        this.leaveCode = leaveCode;
        return this;
    }
    public String getLeaveCode() {
        return this.leaveCode;
    }

    public InitAndGetLeaveALlocationQuotasRequest setOpUserId(String opUserId) {
        this.opUserId = opUserId;
        return this;
    }
    public String getOpUserId() {
        return this.opUserId;
    }

    public InitAndGetLeaveALlocationQuotasRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
