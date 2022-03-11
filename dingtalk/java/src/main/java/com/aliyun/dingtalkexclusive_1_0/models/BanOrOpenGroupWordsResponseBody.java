// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class BanOrOpenGroupWordsResponseBody extends TeaModel {
    // 原因
    @NameInMap("cause")
    public String cause;

    // 返回码
    @NameInMap("code")
    public String code;

    public static BanOrOpenGroupWordsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        BanOrOpenGroupWordsResponseBody self = new BanOrOpenGroupWordsResponseBody();
        return TeaModel.build(map, self);
    }

    public BanOrOpenGroupWordsResponseBody setCause(String cause) {
        this.cause = cause;
        return this;
    }
    public String getCause() {
        return this.cause;
    }

    public BanOrOpenGroupWordsResponseBody setCode(String code) {
        this.code = code;
        return this;
    }
    public String getCode() {
        return this.code;
    }

}
