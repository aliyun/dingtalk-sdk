// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class UpdateCollegeContactDeptResponseBody extends TeaModel {
    @NameInMap("success")
    public Boolean success;

    public static UpdateCollegeContactDeptResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdateCollegeContactDeptResponseBody self = new UpdateCollegeContactDeptResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdateCollegeContactDeptResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
