// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class GetOfficialAccountContactInfoShrinkRequest extends TeaModel {
    @NameInMap("context")
    public String contextShrink;

    public static GetOfficialAccountContactInfoShrinkRequest build(java.util.Map<String, ?> map) throws Exception {
        GetOfficialAccountContactInfoShrinkRequest self = new GetOfficialAccountContactInfoShrinkRequest();
        return TeaModel.build(map, self);
    }

    public GetOfficialAccountContactInfoShrinkRequest setContextShrink(String contextShrink) {
        this.contextShrink = contextShrink;
        return this;
    }
    public String getContextShrink() {
        return this.contextShrink;
    }

}
