// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class PublishRuleResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>true</p>
     */
    @NameInMap("isPublish")
    public Boolean isPublish;

    public static PublishRuleResponseBody build(java.util.Map<String, ?> map) throws Exception {
        PublishRuleResponseBody self = new PublishRuleResponseBody();
        return TeaModel.build(map, self);
    }

    public PublishRuleResponseBody setIsPublish(Boolean isPublish) {
        this.isPublish = isPublish;
        return this;
    }
    public Boolean getIsPublish() {
        return this.isPublish;
    }

}
