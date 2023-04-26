// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconference_1_0.models;

import com.aliyun.tea.*;

public class FocusRequest extends TeaModel {
    @NameInMap("action")
    public String action;

    @NameInMap("unionId")
    public String unionId;

    public static FocusRequest build(java.util.Map<String, ?> map) throws Exception {
        FocusRequest self = new FocusRequest();
        return TeaModel.build(map, self);
    }

    public FocusRequest setAction(String action) {
        this.action = action;
        return this;
    }
    public String getAction() {
        return this.action;
    }

    public FocusRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

}
