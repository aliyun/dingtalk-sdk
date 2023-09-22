// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class PublishRuleRequest extends TeaModel {
    @NameInMap("status")
    public Long status;

    public static PublishRuleRequest build(java.util.Map<String, ?> map) throws Exception {
        PublishRuleRequest self = new PublishRuleRequest();
        return TeaModel.build(map, self);
    }

    public PublishRuleRequest setStatus(Long status) {
        this.status = status;
        return this;
    }
    public Long getStatus() {
        return this.status;
    }

}
