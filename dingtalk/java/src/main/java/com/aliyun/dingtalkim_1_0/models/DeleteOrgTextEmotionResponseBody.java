// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class DeleteOrgTextEmotionResponseBody extends TeaModel {
    @NameInMap("success")
    public Boolean success;

    public static DeleteOrgTextEmotionResponseBody build(java.util.Map<String, ?> map) throws Exception {
        DeleteOrgTextEmotionResponseBody self = new DeleteOrgTextEmotionResponseBody();
        return TeaModel.build(map, self);
    }

    public DeleteOrgTextEmotionResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
