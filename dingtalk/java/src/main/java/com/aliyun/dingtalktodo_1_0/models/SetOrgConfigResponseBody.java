// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktodo_1_0.models;

import com.aliyun.tea.*;

public class SetOrgConfigResponseBody extends TeaModel {
    @NameInMap("success")
    public Boolean success;

    public static SetOrgConfigResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SetOrgConfigResponseBody self = new SetOrgConfigResponseBody();
        return TeaModel.build(map, self);
    }

    public SetOrgConfigResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
