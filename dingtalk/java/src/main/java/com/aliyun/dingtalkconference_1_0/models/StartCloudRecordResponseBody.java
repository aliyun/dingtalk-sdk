// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconference_1_0.models;

import com.aliyun.tea.*;

public class StartCloudRecordResponseBody extends TeaModel {
    // 是否成功
    @NameInMap("cause")
    public String cause;

    // 返回码
    @NameInMap("code")
    public String code;

    public static StartCloudRecordResponseBody build(java.util.Map<String, ?> map) throws Exception {
        StartCloudRecordResponseBody self = new StartCloudRecordResponseBody();
        return TeaModel.build(map, self);
    }

    public StartCloudRecordResponseBody setCause(String cause) {
        this.cause = cause;
        return this;
    }
    public String getCause() {
        return this.cause;
    }

    public StartCloudRecordResponseBody setCode(String code) {
        this.code = code;
        return this;
    }
    public String getCode() {
        return this.code;
    }

}
