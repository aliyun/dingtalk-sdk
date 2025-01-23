// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class IsYuwenCertifiedTeacherResponseBody extends TeaModel {
    @NameInMap("result")
    public Boolean result;

    @NameInMap("success")
    public Boolean success;

    public static IsYuwenCertifiedTeacherResponseBody build(java.util.Map<String, ?> map) throws Exception {
        IsYuwenCertifiedTeacherResponseBody self = new IsYuwenCertifiedTeacherResponseBody();
        return TeaModel.build(map, self);
    }

    public IsYuwenCertifiedTeacherResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

    public IsYuwenCertifiedTeacherResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
