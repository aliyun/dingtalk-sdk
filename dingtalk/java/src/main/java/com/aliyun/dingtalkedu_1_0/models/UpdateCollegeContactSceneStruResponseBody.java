// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class UpdateCollegeContactSceneStruResponseBody extends TeaModel {
    @NameInMap("success")
    public Boolean success;

    public static UpdateCollegeContactSceneStruResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdateCollegeContactSceneStruResponseBody self = new UpdateCollegeContactSceneStruResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdateCollegeContactSceneStruResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
