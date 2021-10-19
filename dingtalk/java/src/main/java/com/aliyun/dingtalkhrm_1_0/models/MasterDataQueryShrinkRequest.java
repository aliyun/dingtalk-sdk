// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class MasterDataQueryShrinkRequest extends TeaModel {
    @NameInMap("body")
    public String bodyShrink;

    public static MasterDataQueryShrinkRequest build(java.util.Map<String, ?> map) throws Exception {
        MasterDataQueryShrinkRequest self = new MasterDataQueryShrinkRequest();
        return TeaModel.build(map, self);
    }

    public MasterDataQueryShrinkRequest setBodyShrink(String bodyShrink) {
        this.bodyShrink = bodyShrink;
        return this;
    }
    public String getBodyShrink() {
        return this.bodyShrink;
    }

}
