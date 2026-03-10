// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkoauth2_1_0.models;

import com.aliyun.tea.*;

public class KickoffByDeviceIdResponseBody extends TeaModel {
    @NameInMap("errorCode")
    public String errorCode;

    @NameInMap("errorMsg")
    public String errorMsg;

    @NameInMap("success")
    public Boolean success;

    public static KickoffByDeviceIdResponseBody build(java.util.Map<String, ?> map) throws Exception {
        KickoffByDeviceIdResponseBody self = new KickoffByDeviceIdResponseBody();
        return TeaModel.build(map, self);
    }

    public KickoffByDeviceIdResponseBody setErrorCode(String errorCode) {
        this.errorCode = errorCode;
        return this;
    }
    public String getErrorCode() {
        return this.errorCode;
    }

    public KickoffByDeviceIdResponseBody setErrorMsg(String errorMsg) {
        this.errorMsg = errorMsg;
        return this;
    }
    public String getErrorMsg() {
        return this.errorMsg;
    }

    public KickoffByDeviceIdResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
