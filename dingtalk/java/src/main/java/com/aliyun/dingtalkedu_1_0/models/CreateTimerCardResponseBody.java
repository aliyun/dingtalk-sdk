// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class CreateTimerCardResponseBody extends TeaModel {
    @NameInMap("result")
    public Boolean result;

    @NameInMap("sucess")
    public Boolean sucess;

    public static CreateTimerCardResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CreateTimerCardResponseBody self = new CreateTimerCardResponseBody();
        return TeaModel.build(map, self);
    }

    public CreateTimerCardResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

    public CreateTimerCardResponseBody setSucess(Boolean sucess) {
        this.sucess = sucess;
        return this;
    }
    public Boolean getSucess() {
        return this.sucess;
    }

}
