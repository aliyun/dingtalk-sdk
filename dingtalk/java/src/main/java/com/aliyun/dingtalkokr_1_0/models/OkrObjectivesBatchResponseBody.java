// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkokr_1_0.models;

import com.aliyun.tea.*;

public class OkrObjectivesBatchResponseBody extends TeaModel {
    @NameInMap("content")
    public java.util.List<OpenObjectiveDTO> content;

    @NameInMap("success")
    public Boolean success;

    public static OkrObjectivesBatchResponseBody build(java.util.Map<String, ?> map) throws Exception {
        OkrObjectivesBatchResponseBody self = new OkrObjectivesBatchResponseBody();
        return TeaModel.build(map, self);
    }

    public OkrObjectivesBatchResponseBody setContent(java.util.List<OpenObjectiveDTO> content) {
        this.content = content;
        return this;
    }
    public java.util.List<OpenObjectiveDTO> getContent() {
        return this.content;
    }

    public OkrObjectivesBatchResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
