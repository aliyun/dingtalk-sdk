// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconference_1_0.models;

import com.aliyun.tea.*;

public class OptRecordWhiteAccountShrinkRequest extends TeaModel {
    @NameInMap("requestBody")
    public String requestBodyShrink;

    public static OptRecordWhiteAccountShrinkRequest build(java.util.Map<String, ?> map) throws Exception {
        OptRecordWhiteAccountShrinkRequest self = new OptRecordWhiteAccountShrinkRequest();
        return TeaModel.build(map, self);
    }

    public OptRecordWhiteAccountShrinkRequest setRequestBodyShrink(String requestBodyShrink) {
        this.requestBodyShrink = requestBodyShrink;
        return this;
    }
    public String getRequestBodyShrink() {
        return this.requestBodyShrink;
    }

}
