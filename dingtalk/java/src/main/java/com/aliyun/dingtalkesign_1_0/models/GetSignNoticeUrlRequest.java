// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkesign_1_0.models;

import com.aliyun.tea.*;

public class GetSignNoticeUrlRequest extends TeaModel {
    @NameInMap("taskId")
    public String taskId;

    public static GetSignNoticeUrlRequest build(java.util.Map<String, ?> map) throws Exception {
        GetSignNoticeUrlRequest self = new GetSignNoticeUrlRequest();
        return TeaModel.build(map, self);
    }

    public GetSignNoticeUrlRequest setTaskId(String taskId) {
        this.taskId = taskId;
        return this;
    }
    public String getTaskId() {
        return this.taskId;
    }

}
