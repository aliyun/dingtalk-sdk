// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkwatt_1_0.models;

import com.aliyun.tea.*;

public class RevertPointShrinkRequest extends TeaModel {
    @NameInMap("body")
    public String bodyShrink;

    public static RevertPointShrinkRequest build(java.util.Map<String, ?> map) throws Exception {
        RevertPointShrinkRequest self = new RevertPointShrinkRequest();
        return TeaModel.build(map, self);
    }

    public RevertPointShrinkRequest setBodyShrink(String bodyShrink) {
        this.bodyShrink = bodyShrink;
        return this;
    }
    public String getBodyShrink() {
        return this.bodyShrink;
    }

}
