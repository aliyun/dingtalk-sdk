// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconference_1_0.models;

import com.aliyun.tea.*;

public class UpdateMemberNickResponseBody extends TeaModel {
    @NameInMap("success")
    public Boolean success;

    public static UpdateMemberNickResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdateMemberNickResponseBody self = new UpdateMemberNickResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdateMemberNickResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
