// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdvi_1_0.models;

import com.aliyun.tea.*;

public class ControlRecordingResponseBody extends TeaModel {
    @NameInMap("result")
    public Boolean result;

    public static ControlRecordingResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ControlRecordingResponseBody self = new ControlRecordingResponseBody();
        return TeaModel.build(map, self);
    }

    public ControlRecordingResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
