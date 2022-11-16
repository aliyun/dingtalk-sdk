// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class UpdateGroupSetResponseBody extends TeaModel {
    @NameInMap("success")
    public Boolean success;

    public static UpdateGroupSetResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdateGroupSetResponseBody self = new UpdateGroupSetResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdateGroupSetResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
