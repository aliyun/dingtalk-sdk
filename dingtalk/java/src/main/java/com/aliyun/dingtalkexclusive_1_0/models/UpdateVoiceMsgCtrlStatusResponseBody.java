// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class UpdateVoiceMsgCtrlStatusResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>true</p>
     */
    @NameInMap("success")
    public Boolean success;

    public static UpdateVoiceMsgCtrlStatusResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdateVoiceMsgCtrlStatusResponseBody self = new UpdateVoiceMsgCtrlStatusResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdateVoiceMsgCtrlStatusResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
