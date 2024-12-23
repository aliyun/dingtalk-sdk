// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class DeleteCollegeContactSceneStruResponseBody extends TeaModel {
    @NameInMap("success")
    public Boolean success;

    public static DeleteCollegeContactSceneStruResponseBody build(java.util.Map<String, ?> map) throws Exception {
        DeleteCollegeContactSceneStruResponseBody self = new DeleteCollegeContactSceneStruResponseBody();
        return TeaModel.build(map, self);
    }

    public DeleteCollegeContactSceneStruResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
