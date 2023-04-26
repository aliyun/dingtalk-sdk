// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkokr_1_0.models;

import com.aliyun.tea.*;

public class UpdateKROfContentResponseBody extends TeaModel {
    @NameInMap("data")
    public Boolean data;

    @NameInMap("success")
    public Boolean success;

    public static UpdateKROfContentResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdateKROfContentResponseBody self = new UpdateKROfContentResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdateKROfContentResponseBody setData(Boolean data) {
        this.data = data;
        return this;
    }
    public Boolean getData() {
        return this.data;
    }

    public UpdateKROfContentResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
