// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkattendance_1_0.models;

import com.aliyun.tea.*;

public class CheckClosingAccountResponseBody extends TeaModel {
    @NameInMap("mesage")
    public String mesage;

    @NameInMap("code")
    public Long code;

    @NameInMap("success")
    public Boolean success;

    public static CheckClosingAccountResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CheckClosingAccountResponseBody self = new CheckClosingAccountResponseBody();
        return TeaModel.build(map, self);
    }

    public CheckClosingAccountResponseBody setMesage(String mesage) {
        this.mesage = mesage;
        return this;
    }
    public String getMesage() {
        return this.mesage;
    }

    public CheckClosingAccountResponseBody setCode(Long code) {
        this.code = code;
        return this;
    }
    public Long getCode() {
        return this.code;
    }

    public CheckClosingAccountResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
