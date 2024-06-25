// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkattendance_1_0.models;

import com.aliyun.tea.*;

public class GetShiftRequest extends TeaModel {
    @NameInMap("opUserId")
    public String opUserId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>10</p>
     */
    @NameInMap("shiftId")
    public Long shiftId;

    public static GetShiftRequest build(java.util.Map<String, ?> map) throws Exception {
        GetShiftRequest self = new GetShiftRequest();
        return TeaModel.build(map, self);
    }

    public GetShiftRequest setOpUserId(String opUserId) {
        this.opUserId = opUserId;
        return this;
    }
    public String getOpUserId() {
        return this.opUserId;
    }

    public GetShiftRequest setShiftId(Long shiftId) {
        this.shiftId = shiftId;
        return this;
    }
    public Long getShiftId() {
        return this.shiftId;
    }

}
