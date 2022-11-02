// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkats_1_0.models;

import com.aliyun.tea.*;

public class AddUserAccountResponseBody extends TeaModel {
    @NameInMap("success")
    public Boolean success;

    public static AddUserAccountResponseBody build(java.util.Map<String, ?> map) throws Exception {
        AddUserAccountResponseBody self = new AddUserAccountResponseBody();
        return TeaModel.build(map, self);
    }

    public AddUserAccountResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
