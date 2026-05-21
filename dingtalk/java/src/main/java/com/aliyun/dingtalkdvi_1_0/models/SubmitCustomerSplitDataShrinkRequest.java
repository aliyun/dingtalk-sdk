// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdvi_1_0.models;

import com.aliyun.tea.*;

public class SubmitCustomerSplitDataShrinkRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("splitParams")
    public String splitParamsShrink;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("userId")
    public String userId;

    public static SubmitCustomerSplitDataShrinkRequest build(java.util.Map<String, ?> map) throws Exception {
        SubmitCustomerSplitDataShrinkRequest self = new SubmitCustomerSplitDataShrinkRequest();
        return TeaModel.build(map, self);
    }

    public SubmitCustomerSplitDataShrinkRequest setSplitParamsShrink(String splitParamsShrink) {
        this.splitParamsShrink = splitParamsShrink;
        return this;
    }
    public String getSplitParamsShrink() {
        return this.splitParamsShrink;
    }

    public SubmitCustomerSplitDataShrinkRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
