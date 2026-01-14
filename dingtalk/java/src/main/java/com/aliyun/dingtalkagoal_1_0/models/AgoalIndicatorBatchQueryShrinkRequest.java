// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkagoal_1_0.models;

import com.aliyun.tea.*;

public class AgoalIndicatorBatchQueryShrinkRequest extends TeaModel {
    @NameInMap("codeList")
    public String codeListShrink;

    public static AgoalIndicatorBatchQueryShrinkRequest build(java.util.Map<String, ?> map) throws Exception {
        AgoalIndicatorBatchQueryShrinkRequest self = new AgoalIndicatorBatchQueryShrinkRequest();
        return TeaModel.build(map, self);
    }

    public AgoalIndicatorBatchQueryShrinkRequest setCodeListShrink(String codeListShrink) {
        this.codeListShrink = codeListShrink;
        return this;
    }
    public String getCodeListShrink() {
        return this.codeListShrink;
    }

}
