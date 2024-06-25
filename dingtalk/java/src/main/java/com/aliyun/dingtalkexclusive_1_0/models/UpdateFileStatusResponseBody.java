// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class UpdateFileStatusResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>true</p>
     */
    @NameInMap("success")
    public Boolean success;

    public static UpdateFileStatusResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdateFileStatusResponseBody self = new UpdateFileStatusResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdateFileStatusResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
