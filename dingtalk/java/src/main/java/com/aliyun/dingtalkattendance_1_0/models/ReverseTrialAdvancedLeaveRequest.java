// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkattendance_1_0.models;

import com.aliyun.tea.*;

public class ReverseTrialAdvancedLeaveRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>manager234</p>
     */
    @NameInMap("opUserId")
    public String opUserId;

    /**
     * <strong>example:</strong>
     * <p>1</p>
     */
    @NameInMap("servCode")
    public Long servCode;

    public static ReverseTrialAdvancedLeaveRequest build(java.util.Map<String, ?> map) throws Exception {
        ReverseTrialAdvancedLeaveRequest self = new ReverseTrialAdvancedLeaveRequest();
        return TeaModel.build(map, self);
    }

    public ReverseTrialAdvancedLeaveRequest setOpUserId(String opUserId) {
        this.opUserId = opUserId;
        return this;
    }
    public String getOpUserId() {
        return this.opUserId;
    }

    public ReverseTrialAdvancedLeaveRequest setServCode(Long servCode) {
        this.servCode = servCode;
        return this;
    }
    public Long getServCode() {
        return this.servCode;
    }

}
