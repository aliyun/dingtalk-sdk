// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class DeleteDeviceOrgResponseBody extends TeaModel {
    /**
     * <p>Id of the request</p>
     */
    @NameInMap("success")
    public Boolean success;

    public static DeleteDeviceOrgResponseBody build(java.util.Map<String, ?> map) throws Exception {
        DeleteDeviceOrgResponseBody self = new DeleteDeviceOrgResponseBody();
        return TeaModel.build(map, self);
    }

    public DeleteDeviceOrgResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
