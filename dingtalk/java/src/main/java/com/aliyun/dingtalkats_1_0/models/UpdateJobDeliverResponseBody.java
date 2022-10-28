// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkats_1_0.models;

import com.aliyun.tea.*;

public class UpdateJobDeliverResponseBody extends TeaModel {
    @NameInMap("success")
    public Boolean success;

    public static UpdateJobDeliverResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdateJobDeliverResponseBody self = new UpdateJobDeliverResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdateJobDeliverResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
