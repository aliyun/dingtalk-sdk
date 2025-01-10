// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkagoal_1_0.models;

import com.aliyun.tea.*;

public class AgoalFieldUpdateShrinkRequest extends TeaModel {
    @NameInMap("body")
    public String bodyShrink;

    public static AgoalFieldUpdateShrinkRequest build(java.util.Map<String, ?> map) throws Exception {
        AgoalFieldUpdateShrinkRequest self = new AgoalFieldUpdateShrinkRequest();
        return TeaModel.build(map, self);
    }

    public AgoalFieldUpdateShrinkRequest setBodyShrink(String bodyShrink) {
        this.bodyShrink = bodyShrink;
        return this;
    }
    public String getBodyShrink() {
        return this.bodyShrink;
    }

}
