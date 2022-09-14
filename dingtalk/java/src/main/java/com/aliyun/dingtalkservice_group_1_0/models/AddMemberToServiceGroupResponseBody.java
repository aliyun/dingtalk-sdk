// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class AddMemberToServiceGroupResponseBody extends TeaModel {
    @NameInMap("success")
    public Boolean success;

    public static AddMemberToServiceGroupResponseBody build(java.util.Map<String, ?> map) throws Exception {
        AddMemberToServiceGroupResponseBody self = new AddMemberToServiceGroupResponseBody();
        return TeaModel.build(map, self);
    }

    public AddMemberToServiceGroupResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
