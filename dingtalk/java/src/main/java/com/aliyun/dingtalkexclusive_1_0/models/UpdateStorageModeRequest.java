// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class UpdateStorageModeRequest extends TeaModel {
    /**
     * <p>专属文件跨云存储类型 0：公有模式，1：私有模式，注意，如不更新，则不填写这个字段，字段一旦有值，都会触发原有配置的删除</p>
     */
    @NameInMap("fileStorageMode")
    public String fileStorageMode;

    /**
     * <p>企业id</p>
     */
    @NameInMap("targetCorpId")
    public String targetCorpId;

    public static UpdateStorageModeRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateStorageModeRequest self = new UpdateStorageModeRequest();
        return TeaModel.build(map, self);
    }

    public UpdateStorageModeRequest setFileStorageMode(String fileStorageMode) {
        this.fileStorageMode = fileStorageMode;
        return this;
    }
    public String getFileStorageMode() {
        return this.fileStorageMode;
    }

    public UpdateStorageModeRequest setTargetCorpId(String targetCorpId) {
        this.targetCorpId = targetCorpId;
        return this;
    }
    public String getTargetCorpId() {
        return this.targetCorpId;
    }

}
