// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconference_1_0.models;

import com.aliyun.tea.*;

public class StopCloudRecordResponseBody extends TeaModel {
    /**
     * <p>返回码</p>
     */
    @NameInMap("code")
    public String code;

    public static StopCloudRecordResponseBody build(java.util.Map<String, ?> map) throws Exception {
        StopCloudRecordResponseBody self = new StopCloudRecordResponseBody();
        return TeaModel.build(map, self);
    }

    public StopCloudRecordResponseBody setCode(String code) {
        this.code = code;
        return this;
    }
    public String getCode() {
        return this.code;
    }

}
