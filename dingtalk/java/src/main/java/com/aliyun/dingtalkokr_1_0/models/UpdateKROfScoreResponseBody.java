// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkokr_1_0.models;

import com.aliyun.tea.*;

public class UpdateKROfScoreResponseBody extends TeaModel {
    // 目标分数
    @NameInMap("data")
    public Long data;

    // Id of the request
    @NameInMap("success")
    public Boolean success;

    public static UpdateKROfScoreResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdateKROfScoreResponseBody self = new UpdateKROfScoreResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdateKROfScoreResponseBody setData(Long data) {
        this.data = data;
        return this;
    }
    public Long getData() {
        return this.data;
    }

    public UpdateKROfScoreResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
