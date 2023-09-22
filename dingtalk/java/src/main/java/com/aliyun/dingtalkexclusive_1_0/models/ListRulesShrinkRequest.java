// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class ListRulesShrinkRequest extends TeaModel {
    @NameInMap("body")
    public String bodyShrink;

    public static ListRulesShrinkRequest build(java.util.Map<String, ?> map) throws Exception {
        ListRulesShrinkRequest self = new ListRulesShrinkRequest();
        return TeaModel.build(map, self);
    }

    public ListRulesShrinkRequest setBodyShrink(String bodyShrink) {
        this.bodyShrink = bodyShrink;
        return this;
    }
    public String getBodyShrink() {
        return this.bodyShrink;
    }

}
