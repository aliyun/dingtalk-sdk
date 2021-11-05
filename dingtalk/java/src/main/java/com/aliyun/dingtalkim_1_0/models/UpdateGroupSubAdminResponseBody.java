// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class UpdateGroupSubAdminResponseBody extends TeaModel {
    // success
    @NameInMap("success")
    public Boolean success;

    public static UpdateGroupSubAdminResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdateGroupSubAdminResponseBody self = new UpdateGroupSubAdminResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdateGroupSubAdminResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
