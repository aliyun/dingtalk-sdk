// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkattendance_1_0.models;

import com.aliyun.tea.*;

public class InitAndGetLeaveALlocationQuotasRequest extends TeaModel {
    /**
     * <p>假期类型的标识。</p>
     */
    @NameInMap("leaveCode")
    public String leaveCode;

    /**
     * <p>操作者的userId。</p>
     */
    @NameInMap("opUserId")
    public String opUserId;

    /**
     * <p>用户id。</p>
     */
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
