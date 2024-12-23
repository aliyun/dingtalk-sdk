// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class EnableCollegeContactSceneStruResponseBody extends TeaModel {
    @NameInMap("success")
    public Boolean success;

    public static EnableCollegeContactSceneStruResponseBody build(java.util.Map<String, ?> map) throws Exception {
        EnableCollegeContactSceneStruResponseBody self = new EnableCollegeContactSceneStruResponseBody();
        return TeaModel.build(map, self);
    }

    public EnableCollegeContactSceneStruResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
