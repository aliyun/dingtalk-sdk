// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class UpdateFileStatusRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("requestIds")
    public java.util.List<String> requestIds;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>1-检测通过，2-检测失败</p>
     */
    @NameInMap("status")
    public Integer status;

    public static UpdateFileStatusRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateFileStatusRequest self = new UpdateFileStatusRequest();
        return TeaModel.build(map, self);
    }

    public UpdateFileStatusRequest setRequestIds(java.util.List<String> requestIds) {
        this.requestIds = requestIds;
        return this;
    }
    public java.util.List<String> getRequestIds() {
        return this.requestIds;
    }

    public UpdateFileStatusRequest setStatus(Integer status) {
        this.status = status;
        return this;
    }
    public Integer getStatus() {
        return this.status;
    }

}
