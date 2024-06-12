// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconference_1_0.models;

import com.aliyun.tea.*;

public class StopMinutesResponseBody extends TeaModel {
    @NameInMap("code")
    public String code;

    public static StopMinutesResponseBody build(java.util.Map<String, ?> map) throws Exception {
        StopMinutesResponseBody self = new StopMinutesResponseBody();
        return TeaModel.build(map, self);
    }

    public StopMinutesResponseBody setCode(String code) {
        this.code = code;
        return this;
    }
    public String getCode() {
        return this.code;
    }

}
