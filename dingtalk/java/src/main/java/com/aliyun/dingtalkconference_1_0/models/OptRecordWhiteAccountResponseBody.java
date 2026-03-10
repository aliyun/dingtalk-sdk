// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconference_1_0.models;

import com.aliyun.tea.*;

public class OptRecordWhiteAccountResponseBody extends TeaModel {
    @NameInMap("code")
    public String code;

    public static OptRecordWhiteAccountResponseBody build(java.util.Map<String, ?> map) throws Exception {
        OptRecordWhiteAccountResponseBody self = new OptRecordWhiteAccountResponseBody();
        return TeaModel.build(map, self);
    }

    public OptRecordWhiteAccountResponseBody setCode(String code) {
        this.code = code;
        return this;
    }
    public String getCode() {
        return this.code;
    }

}
