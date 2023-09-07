// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkflashmsg_1_0.models;

import com.aliyun.tea.*;

public class AddPluginRuleResponseBody extends TeaModel {
    @NameInMap("success")
    public Boolean success;

    public static AddPluginRuleResponseBody build(java.util.Map<String, ?> map) throws Exception {
        AddPluginRuleResponseBody self = new AddPluginRuleResponseBody();
        return TeaModel.build(map, self);
    }

    public AddPluginRuleResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
