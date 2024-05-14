// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkattendance_1_0.models;

import com.aliyun.tea.*;

public class CheckClosingAccountResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("code")
    public String code;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("mesage")
    public String mesage;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("pass")
    public Boolean pass;

    public static CheckClosingAccountResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CheckClosingAccountResponseBody self = new CheckClosingAccountResponseBody();
        return TeaModel.build(map, self);
    }

    public CheckClosingAccountResponseBody setCode(String code) {
        this.code = code;
        return this;
    }
    public String getCode() {
        return this.code;
    }

    public CheckClosingAccountResponseBody setMesage(String mesage) {
        this.mesage = mesage;
        return this;
    }
    public String getMesage() {
        return this.mesage;
    }

    public CheckClosingAccountResponseBody setPass(Boolean pass) {
        this.pass = pass;
        return this;
    }
    public Boolean getPass() {
        return this.pass;
    }

}
