// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class CopyUnfurlingRegisterResponseBody extends TeaModel {
    @NameInMap("result")
    public Long result;

    @NameInMap("success")
    public Boolean success;

    public static CopyUnfurlingRegisterResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CopyUnfurlingRegisterResponseBody self = new CopyUnfurlingRegisterResponseBody();
        return TeaModel.build(map, self);
    }

    public CopyUnfurlingRegisterResponseBody setResult(Long result) {
        this.result = result;
        return this;
    }
    public Long getResult() {
        return this.result;
    }

    public CopyUnfurlingRegisterResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
