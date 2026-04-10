// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class FileDecryptCallbackRequest extends TeaModel {
    @NameInMap("bizId")
    public String bizId;

    @NameInMap("decryptFileSize")
    public Long decryptFileSize;

    @NameInMap("timestamp")
    public Long timestamp;

    public static FileDecryptCallbackRequest build(java.util.Map<String, ?> map) throws Exception {
        FileDecryptCallbackRequest self = new FileDecryptCallbackRequest();
        return TeaModel.build(map, self);
    }

    public FileDecryptCallbackRequest setBizId(String bizId) {
        this.bizId = bizId;
        return this;
    }
    public String getBizId() {
        return this.bizId;
    }

    public FileDecryptCallbackRequest setDecryptFileSize(Long decryptFileSize) {
        this.decryptFileSize = decryptFileSize;
        return this;
    }
    public Long getDecryptFileSize() {
        return this.decryptFileSize;
    }

    public FileDecryptCallbackRequest setTimestamp(Long timestamp) {
        this.timestamp = timestamp;
        return this;
    }
    public Long getTimestamp() {
        return this.timestamp;
    }

}
