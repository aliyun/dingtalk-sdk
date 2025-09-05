// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class GenerateTaskIdResponseBody extends TeaModel {
    @NameInMap("result")
    public String result;

    @NameInMap("success")
    public Boolean success;

    public static GenerateTaskIdResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GenerateTaskIdResponseBody self = new GenerateTaskIdResponseBody();
        return TeaModel.build(map, self);
    }

    public GenerateTaskIdResponseBody setResult(String result) {
        this.result = result;
        return this;
    }
    public String getResult() {
        return this.result;
    }

    public GenerateTaskIdResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
