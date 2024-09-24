// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class UpdateCollegeContactExclusiveResponseBody extends TeaModel {
    @NameInMap("success")
    public Boolean success;

    public static UpdateCollegeContactExclusiveResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdateCollegeContactExclusiveResponseBody self = new UpdateCollegeContactExclusiveResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdateCollegeContactExclusiveResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
