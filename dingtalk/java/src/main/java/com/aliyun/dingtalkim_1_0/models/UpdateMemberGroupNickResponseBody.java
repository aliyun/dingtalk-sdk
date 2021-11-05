// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class UpdateMemberGroupNickResponseBody extends TeaModel {
    // result
    @NameInMap("success")
    public Boolean success;

    public static UpdateMemberGroupNickResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdateMemberGroupNickResponseBody self = new UpdateMemberGroupNickResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdateMemberGroupNickResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
