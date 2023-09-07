// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkflashmsg_1_0.models;

import com.aliyun.tea.*;

public class DeletePlguinRuleResponseBody extends TeaModel {
    @NameInMap("success")
    public Boolean success;

    public static DeletePlguinRuleResponseBody build(java.util.Map<String, ?> map) throws Exception {
        DeletePlguinRuleResponseBody self = new DeletePlguinRuleResponseBody();
        return TeaModel.build(map, self);
    }

    public DeletePlguinRuleResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
