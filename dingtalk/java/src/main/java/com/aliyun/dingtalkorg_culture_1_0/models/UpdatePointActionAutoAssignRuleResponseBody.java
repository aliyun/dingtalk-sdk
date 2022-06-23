// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkorg_culture_1_0.models;

import com.aliyun.tea.*;

public class UpdatePointActionAutoAssignRuleResponseBody extends TeaModel {
    @NameInMap("success")
    public Boolean success;

    public static UpdatePointActionAutoAssignRuleResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdatePointActionAutoAssignRuleResponseBody self = new UpdatePointActionAutoAssignRuleResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdatePointActionAutoAssignRuleResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
