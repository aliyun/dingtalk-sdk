// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class CreateConditionalFormattingRuleResponseBody extends TeaModel {
    // 条件格式ID
    @NameInMap("id")
    public String id;

    public static CreateConditionalFormattingRuleResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CreateConditionalFormattingRuleResponseBody self = new CreateConditionalFormattingRuleResponseBody();
        return TeaModel.build(map, self);
    }

    public CreateConditionalFormattingRuleResponseBody setId(String id) {
        this.id = id;
        return this;
    }
    public String getId() {
        return this.id;
    }

}
