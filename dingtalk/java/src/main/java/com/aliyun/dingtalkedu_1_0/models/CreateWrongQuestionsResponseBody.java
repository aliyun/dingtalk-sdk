// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class CreateWrongQuestionsResponseBody extends TeaModel {
    @NameInMap("success")
    public Boolean success;

    public static CreateWrongQuestionsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CreateWrongQuestionsResponseBody self = new CreateWrongQuestionsResponseBody();
        return TeaModel.build(map, self);
    }

    public CreateWrongQuestionsResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
