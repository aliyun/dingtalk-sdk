// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class CreateResponseBody extends TeaModel {
    @NameInMap("success")
    public Boolean success;

    public static CreateResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CreateResponseBody self = new CreateResponseBody();
        return TeaModel.build(map, self);
    }

    public CreateResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
