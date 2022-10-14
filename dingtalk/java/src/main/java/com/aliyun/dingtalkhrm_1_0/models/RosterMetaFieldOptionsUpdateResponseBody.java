// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class RosterMetaFieldOptionsUpdateResponseBody extends TeaModel {
    @NameInMap("result")
    public Boolean result;

    public static RosterMetaFieldOptionsUpdateResponseBody build(java.util.Map<String, ?> map) throws Exception {
        RosterMetaFieldOptionsUpdateResponseBody self = new RosterMetaFieldOptionsUpdateResponseBody();
        return TeaModel.build(map, self);
    }

    public RosterMetaFieldOptionsUpdateResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
