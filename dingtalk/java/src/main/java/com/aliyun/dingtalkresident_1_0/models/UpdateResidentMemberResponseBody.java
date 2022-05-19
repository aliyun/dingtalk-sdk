// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkresident_1_0.models;

import com.aliyun.tea.*;

public class UpdateResidentMemberResponseBody extends TeaModel {
    // 是否成功
    @NameInMap("success")
    public Boolean success;

    public static UpdateResidentMemberResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdateResidentMemberResponseBody self = new UpdateResidentMemberResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdateResidentMemberResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
