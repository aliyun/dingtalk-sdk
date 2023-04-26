// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalklive_1_0.models;

import com.aliyun.tea.*;

public class QuerySubscribeStatusShrinkRequest extends TeaModel {
    @NameInMap("body")
    public String bodyShrink;

    @NameInMap("unionId")
    public String unionId;

    public static QuerySubscribeStatusShrinkRequest build(java.util.Map<String, ?> map) throws Exception {
        QuerySubscribeStatusShrinkRequest self = new QuerySubscribeStatusShrinkRequest();
        return TeaModel.build(map, self);
    }

    public QuerySubscribeStatusShrinkRequest setBodyShrink(String bodyShrink) {
        this.bodyShrink = bodyShrink;
        return this;
    }
    public String getBodyShrink() {
        return this.bodyShrink;
    }

    public QuerySubscribeStatusShrinkRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

}
