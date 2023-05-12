// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class AppLoginCodeGenResponseBody extends TeaModel {
    @NameInMap("loginCode")
    public String loginCode;

    public static AppLoginCodeGenResponseBody build(java.util.Map<String, ?> map) throws Exception {
        AppLoginCodeGenResponseBody self = new AppLoginCodeGenResponseBody();
        return TeaModel.build(map, self);
    }

    public AppLoginCodeGenResponseBody setLoginCode(String loginCode) {
        this.loginCode = loginCode;
        return this;
    }
    public String getLoginCode() {
        return this.loginCode;
    }

}
