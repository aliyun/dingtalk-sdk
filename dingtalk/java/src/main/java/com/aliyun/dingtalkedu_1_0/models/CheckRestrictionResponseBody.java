// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class CheckRestrictionResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("success")
    public Boolean success;

    public static CheckRestrictionResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CheckRestrictionResponseBody self = new CheckRestrictionResponseBody();
        return TeaModel.build(map, self);
    }

    public CheckRestrictionResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
