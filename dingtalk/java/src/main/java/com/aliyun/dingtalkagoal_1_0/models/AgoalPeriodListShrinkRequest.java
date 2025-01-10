// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkagoal_1_0.models;

import com.aliyun.tea.*;

public class AgoalPeriodListShrinkRequest extends TeaModel {
    @NameInMap("body")
    public String bodyShrink;

    public static AgoalPeriodListShrinkRequest build(java.util.Map<String, ?> map) throws Exception {
        AgoalPeriodListShrinkRequest self = new AgoalPeriodListShrinkRequest();
        return TeaModel.build(map, self);
    }

    public AgoalPeriodListShrinkRequest setBodyShrink(String bodyShrink) {
        this.bodyShrink = bodyShrink;
        return this;
    }
    public String getBodyShrink() {
        return this.bodyShrink;
    }

}
