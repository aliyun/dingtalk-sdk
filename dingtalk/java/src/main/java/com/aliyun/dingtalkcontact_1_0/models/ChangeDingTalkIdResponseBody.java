// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class ChangeDingTalkIdResponseBody extends TeaModel {
    @NameInMap("result")
    public Boolean result;

    public static ChangeDingTalkIdResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ChangeDingTalkIdResponseBody self = new ChangeDingTalkIdResponseBody();
        return TeaModel.build(map, self);
    }

    public ChangeDingTalkIdResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
