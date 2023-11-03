// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkwatt_1_0.models;

import com.aliyun.tea.*;

public class ConsumePointShrinkRequest extends TeaModel {
    @NameInMap("body")
    public String bodyShrink;

    public static ConsumePointShrinkRequest build(java.util.Map<String, ?> map) throws Exception {
        ConsumePointShrinkRequest self = new ConsumePointShrinkRequest();
        return TeaModel.build(map, self);
    }

    public ConsumePointShrinkRequest setBodyShrink(String bodyShrink) {
        this.bodyShrink = bodyShrink;
        return this;
    }
    public String getBodyShrink() {
        return this.bodyShrink;
    }

}
