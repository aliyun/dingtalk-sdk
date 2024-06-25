// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class CreateRuleResponseBody extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>1</p>
     */
    @NameInMap("id")
    public Long id;

    public static CreateRuleResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CreateRuleResponseBody self = new CreateRuleResponseBody();
        return TeaModel.build(map, self);
    }

    public CreateRuleResponseBody setId(Long id) {
        this.id = id;
        return this;
    }
    public Long getId() {
        return this.id;
    }

}
