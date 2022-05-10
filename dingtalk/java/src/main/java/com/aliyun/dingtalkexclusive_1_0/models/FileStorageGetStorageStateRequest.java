// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class FileStorageGetStorageStateRequest extends TeaModel {
    // 企业的corpId
    @NameInMap("targetCorpId")
    public String targetCorpId;

    public static FileStorageGetStorageStateRequest build(java.util.Map<String, ?> map) throws Exception {
        FileStorageGetStorageStateRequest self = new FileStorageGetStorageStateRequest();
        return TeaModel.build(map, self);
    }

    public FileStorageGetStorageStateRequest setTargetCorpId(String targetCorpId) {
        this.targetCorpId = targetCorpId;
        return this;
    }
    public String getTargetCorpId() {
        return this.targetCorpId;
    }

}
