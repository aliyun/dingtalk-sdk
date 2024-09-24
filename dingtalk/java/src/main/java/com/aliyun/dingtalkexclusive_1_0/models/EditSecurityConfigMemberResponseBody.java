// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class EditSecurityConfigMemberResponseBody extends TeaModel {
    @NameInMap("success")
    public Boolean success;

    public static EditSecurityConfigMemberResponseBody build(java.util.Map<String, ?> map) throws Exception {
        EditSecurityConfigMemberResponseBody self = new EditSecurityConfigMemberResponseBody();
        return TeaModel.build(map, self);
    }

    public EditSecurityConfigMemberResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
