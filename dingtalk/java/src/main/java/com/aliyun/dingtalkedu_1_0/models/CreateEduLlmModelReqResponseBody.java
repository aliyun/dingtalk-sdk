// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class CreateEduLlmModelReqResponseBody extends TeaModel {
    @NameInMap("result")
    public String result;

    @NameInMap("success")
    public Boolean success;

    public static CreateEduLlmModelReqResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CreateEduLlmModelReqResponseBody self = new CreateEduLlmModelReqResponseBody();
        return TeaModel.build(map, self);
    }

    public CreateEduLlmModelReqResponseBody setResult(String result) {
        this.result = result;
        return this;
    }
    public String getResult() {
        return this.result;
    }

    public CreateEduLlmModelReqResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
