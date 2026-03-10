// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontract_1_0.models;

import com.aliyun.tea.*;

public class GetContractReviewResultShrinkRequest extends TeaModel {
    @NameInMap("body")
    public String bodyShrink;

    public static GetContractReviewResultShrinkRequest build(java.util.Map<String, ?> map) throws Exception {
        GetContractReviewResultShrinkRequest self = new GetContractReviewResultShrinkRequest();
        return TeaModel.build(map, self);
    }

    public GetContractReviewResultShrinkRequest setBodyShrink(String bodyShrink) {
        this.bodyShrink = bodyShrink;
        return this;
    }
    public String getBodyShrink() {
        return this.bodyShrink;
    }

}
