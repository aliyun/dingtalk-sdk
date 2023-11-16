// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class GetPointActionRecordShrinkRequest extends TeaModel {
    @NameInMap("body")
    public String bodyShrink;

    public static GetPointActionRecordShrinkRequest build(java.util.Map<String, ?> map) throws Exception {
        GetPointActionRecordShrinkRequest self = new GetPointActionRecordShrinkRequest();
        return TeaModel.build(map, self);
    }

    public GetPointActionRecordShrinkRequest setBodyShrink(String bodyShrink) {
        this.bodyShrink = bodyShrink;
        return this;
    }
    public String getBodyShrink() {
        return this.bodyShrink;
    }

}
