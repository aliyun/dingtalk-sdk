// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class UpdateStorageModeRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>0</p>
     */
    @NameInMap("fileStorageMode")
    public String fileStorageMode;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>dingxxxxxxxxxxxx</p>
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
