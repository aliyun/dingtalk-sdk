// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconference_1_0.models;

import com.aliyun.tea.*;

public class StopCloudRecordResponseBody extends TeaModel {
    // 是否成功
    @NameInMap("cause")
    public String cause;

    // 返回码
    @NameInMap("code")
    public String code;

    public static StopCloudRecordResponseBody build(java.util.Map<String, ?> map) throws Exception {
        StopCloudRecordResponseBody self = new StopCloudRecordResponseBody();
        return TeaModel.build(map, self);
    }

    public StopCloudRecordResponseBody setCause(String cause) {
        this.cause = cause;
        return this;
    }
    public String getCause() {
        return this.cause;
    }

    public StopCloudRecordResponseBody setCode(String code) {
        this.code = code;
        return this;
    }
    public String getCode() {
        return this.code;
    }

}
