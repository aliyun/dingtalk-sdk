// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkai_paa_s_1_0.models;

import com.aliyun.tea.*;

public class NLToFrameServiceRequest extends TeaModel {
    @NameInMap("extensionStr")
    public String extensionStr;

    @NameInMap("isNewModel")
    public Boolean isNewModel;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("modelId")
    public String modelId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("modelName")
    public String modelName;

    @NameInMap("userId")
    public Long userId;

    public static NLToFrameServiceRequest build(java.util.Map<String, ?> map) throws Exception {
        NLToFrameServiceRequest self = new NLToFrameServiceRequest();
        return TeaModel.build(map, self);
    }

    public NLToFrameServiceRequest setExtensionStr(String extensionStr) {
        this.extensionStr = extensionStr;
        return this;
    }
    public String getExtensionStr() {
        return this.extensionStr;
    }

    public NLToFrameServiceRequest setIsNewModel(Boolean isNewModel) {
        this.isNewModel = isNewModel;
        return this;
    }
    public Boolean getIsNewModel() {
        return this.isNewModel;
    }

    public NLToFrameServiceRequest setModelId(String modelId) {
        this.modelId = modelId;
        return this;
    }
    public String getModelId() {
        return this.modelId;
    }

    public NLToFrameServiceRequest setModelName(String modelName) {
        this.modelName = modelName;
        return this;
    }
    public String getModelName() {
        return this.modelName;
    }

    public NLToFrameServiceRequest setUserId(Long userId) {
        this.userId = userId;
        return this;
    }
    public Long getUserId() {
        return this.userId;
    }

}
