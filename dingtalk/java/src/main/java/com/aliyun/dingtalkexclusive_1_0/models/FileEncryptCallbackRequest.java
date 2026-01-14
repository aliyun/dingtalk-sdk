// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class FileEncryptCallbackRequest extends TeaModel {
    @NameInMap("bizId")
    public String bizId;

    @NameInMap("timestamp")
    public Long timestamp;

    public static FileEncryptCallbackRequest build(java.util.Map<String, ?> map) throws Exception {
        FileEncryptCallbackRequest self = new FileEncryptCallbackRequest();
        return TeaModel.build(map, self);
    }

    public FileEncryptCallbackRequest setBizId(String bizId) {
        this.bizId = bizId;
        return this;
    }
    public String getBizId() {
        return this.bizId;
    }

    public FileEncryptCallbackRequest setTimestamp(Long timestamp) {
        this.timestamp = timestamp;
        return this;
    }
    public Long getTimestamp() {
        return this.timestamp;
    }

}
