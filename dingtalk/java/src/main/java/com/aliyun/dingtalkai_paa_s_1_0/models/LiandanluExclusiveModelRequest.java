// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkai_paa_s_1_0.models;

import com.aliyun.tea.*;

public class LiandanluExclusiveModelRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("modelId")
    public String modelId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("module")
    public String module;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("prompt")
    public String prompt;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("userId")
    public String userId;

    public static LiandanluExclusiveModelRequest build(java.util.Map<String, ?> map) throws Exception {
        LiandanluExclusiveModelRequest self = new LiandanluExclusiveModelRequest();
        return TeaModel.build(map, self);
    }

    public LiandanluExclusiveModelRequest setModelId(String modelId) {
        this.modelId = modelId;
        return this;
    }
    public String getModelId() {
        return this.modelId;
    }

    public LiandanluExclusiveModelRequest setModule(String module) {
        this.module = module;
        return this;
    }
    public String getModule() {
        return this.module;
    }

    public LiandanluExclusiveModelRequest setPrompt(String prompt) {
        this.prompt = prompt;
        return this;
    }
    public String getPrompt() {
        return this.prompt;
    }

    public LiandanluExclusiveModelRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
