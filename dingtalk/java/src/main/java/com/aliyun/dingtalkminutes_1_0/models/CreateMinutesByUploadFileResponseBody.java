// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkminutes_1_0.models;

import com.aliyun.tea.*;

public class CreateMinutesByUploadFileResponseBody extends TeaModel {
    @NameInMap("bizId")
    public String bizId;

    /**
     * <strong>example:</strong>
     * <p>7632756964313430aaaaaaaaaaaaaaaaaaaaaaaaaa7363731333633305f35</p>
     */
    @NameInMap("taskUuid")
    public String taskUuid;

    public static CreateMinutesByUploadFileResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CreateMinutesByUploadFileResponseBody self = new CreateMinutesByUploadFileResponseBody();
        return TeaModel.build(map, self);
    }

    public CreateMinutesByUploadFileResponseBody setBizId(String bizId) {
        this.bizId = bizId;
        return this;
    }
    public String getBizId() {
        return this.bizId;
    }

    public CreateMinutesByUploadFileResponseBody setTaskUuid(String taskUuid) {
        this.taskUuid = taskUuid;
        return this;
    }
    public String getTaskUuid() {
        return this.taskUuid;
    }

}
