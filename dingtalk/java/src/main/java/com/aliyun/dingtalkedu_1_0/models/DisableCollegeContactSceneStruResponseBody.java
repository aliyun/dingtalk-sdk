// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class DisableCollegeContactSceneStruResponseBody extends TeaModel {
    @NameInMap("success")
    public Boolean success;

    public static DisableCollegeContactSceneStruResponseBody build(java.util.Map<String, ?> map) throws Exception {
        DisableCollegeContactSceneStruResponseBody self = new DisableCollegeContactSceneStruResponseBody();
        return TeaModel.build(map, self);
    }

    public DisableCollegeContactSceneStruResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
