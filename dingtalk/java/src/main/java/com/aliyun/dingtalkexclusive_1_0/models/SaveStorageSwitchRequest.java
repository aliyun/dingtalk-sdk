// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class SaveStorageSwitchRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>0-关闭，1-开启</p>
     */
    @NameInMap("openStorage")
    public Integer openStorage;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>dingxxxxxxxxx</p>
     */
    @NameInMap("targetCorpId")
    public String targetCorpId;

    public static SaveStorageSwitchRequest build(java.util.Map<String, ?> map) throws Exception {
        SaveStorageSwitchRequest self = new SaveStorageSwitchRequest();
        return TeaModel.build(map, self);
    }

    public SaveStorageSwitchRequest setOpenStorage(Integer openStorage) {
        this.openStorage = openStorage;
        return this;
    }
    public Integer getOpenStorage() {
        return this.openStorage;
    }

    public SaveStorageSwitchRequest setTargetCorpId(String targetCorpId) {
        this.targetCorpId = targetCorpId;
        return this;
    }
    public String getTargetCorpId() {
        return this.targetCorpId;
    }

}
