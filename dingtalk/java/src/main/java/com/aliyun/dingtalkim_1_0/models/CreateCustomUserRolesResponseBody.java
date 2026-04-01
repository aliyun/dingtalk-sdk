// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class CreateCustomUserRolesResponseBody extends TeaModel {
    @NameInMap("success")
    public Boolean success;

    public static CreateCustomUserRolesResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CreateCustomUserRolesResponseBody self = new CreateCustomUserRolesResponseBody();
        return TeaModel.build(map, self);
    }

    public CreateCustomUserRolesResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
