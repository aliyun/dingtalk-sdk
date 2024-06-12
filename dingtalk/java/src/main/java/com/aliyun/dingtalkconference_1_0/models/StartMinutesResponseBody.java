// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconference_1_0.models;

import com.aliyun.tea.*;

public class StartMinutesResponseBody extends TeaModel {
    @NameInMap("code")
    public String code;

    public static StartMinutesResponseBody build(java.util.Map<String, ?> map) throws Exception {
        StartMinutesResponseBody self = new StartMinutesResponseBody();
        return TeaModel.build(map, self);
    }

    public StartMinutesResponseBody setCode(String code) {
        this.code = code;
        return this;
    }
    public String getCode() {
        return this.code;
    }

}
