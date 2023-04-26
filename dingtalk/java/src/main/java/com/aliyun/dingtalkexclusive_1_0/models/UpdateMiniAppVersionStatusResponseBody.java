// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class UpdateMiniAppVersionStatusResponseBody extends TeaModel {
    @NameInMap("cause")
    public String cause;

    @NameInMap("code")
    public String code;

    public static UpdateMiniAppVersionStatusResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdateMiniAppVersionStatusResponseBody self = new UpdateMiniAppVersionStatusResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdateMiniAppVersionStatusResponseBody setCause(String cause) {
        this.cause = cause;
        return this;
    }
    public String getCause() {
        return this.cause;
    }

    public UpdateMiniAppVersionStatusResponseBody setCode(String code) {
        this.code = code;
        return this;
    }
    public String getCode() {
        return this.code;
    }

}
