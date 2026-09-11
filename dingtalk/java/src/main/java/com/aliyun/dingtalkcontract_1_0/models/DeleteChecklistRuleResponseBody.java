// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontract_1_0.models;

import com.aliyun.tea.*;

public class DeleteChecklistRuleResponseBody extends TeaModel {
    @NameInMap("data")
    public String data;

    public static DeleteChecklistRuleResponseBody build(java.util.Map<String, ?> map) throws Exception {
        DeleteChecklistRuleResponseBody self = new DeleteChecklistRuleResponseBody();
        return TeaModel.build(map, self);
    }

    public DeleteChecklistRuleResponseBody setData(String data) {
        this.data = data;
        return this;
    }
    public String getData() {
        return this.data;
    }

}
