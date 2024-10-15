// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalklive_1_0.models;

import com.aliyun.tea.*;

public class GetGroupLiveListShrinkRequest extends TeaModel {
    @NameInMap("requestBody")
    public String requestBodyShrink;

    @NameInMap("unionId")
    public String unionId;

    public static GetGroupLiveListShrinkRequest build(java.util.Map<String, ?> map) throws Exception {
        GetGroupLiveListShrinkRequest self = new GetGroupLiveListShrinkRequest();
        return TeaModel.build(map, self);
    }

    public GetGroupLiveListShrinkRequest setRequestBodyShrink(String requestBodyShrink) {
        this.requestBodyShrink = requestBodyShrink;
        return this;
    }
    public String getRequestBodyShrink() {
        return this.requestBodyShrink;
    }

    public GetGroupLiveListShrinkRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

}
