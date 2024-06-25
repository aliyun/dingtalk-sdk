// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkattendance_1_0.models;

import com.aliyun.tea.*;

public class RetainLeaveTypesRequest extends TeaModel {
    @NameInMap("leaveCodes")
    public java.util.List<String> leaveCodes;

    /**
     * <strong>example:</strong>
     * <p>manager233</p>
     */
    @NameInMap("opUserId")
    public String opUserId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>1</p>
     */
    @NameInMap("source")
    public Long source;

    public static RetainLeaveTypesRequest build(java.util.Map<String, ?> map) throws Exception {
        RetainLeaveTypesRequest self = new RetainLeaveTypesRequest();
        return TeaModel.build(map, self);
    }

    public RetainLeaveTypesRequest setLeaveCodes(java.util.List<String> leaveCodes) {
        this.leaveCodes = leaveCodes;
        return this;
    }
    public java.util.List<String> getLeaveCodes() {
        return this.leaveCodes;
    }

    public RetainLeaveTypesRequest setOpUserId(String opUserId) {
        this.opUserId = opUserId;
        return this;
    }
    public String getOpUserId() {
        return this.opUserId;
    }

    public RetainLeaveTypesRequest setSource(Long source) {
        this.source = source;
        return this;
    }
    public Long getSource() {
        return this.source;
    }

}
