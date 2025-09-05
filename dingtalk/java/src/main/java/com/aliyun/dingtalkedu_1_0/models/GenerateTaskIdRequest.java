// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class GenerateTaskIdRequest extends TeaModel {
    @NameInMap("maxTokens")
    public Integer maxTokens;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>qwen-max</p>
     */
    @NameInMap("model")
    public String model;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("prompt")
    public String prompt;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("scene")
    public String scene;

    @NameInMap("temperature")
    public Double temperature;

    @NameInMap("top_p")
    public Double topP;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>123</p>
     */
    @NameInMap("userId")
    public String userId;

    public static GenerateTaskIdRequest build(java.util.Map<String, ?> map) throws Exception {
        GenerateTaskIdRequest self = new GenerateTaskIdRequest();
        return TeaModel.build(map, self);
    }

    public GenerateTaskIdRequest setMaxTokens(Integer maxTokens) {
        this.maxTokens = maxTokens;
        return this;
    }
    public Integer getMaxTokens() {
        return this.maxTokens;
    }

    public GenerateTaskIdRequest setModel(String model) {
        this.model = model;
        return this;
    }
    public String getModel() {
        return this.model;
    }

    public GenerateTaskIdRequest setPrompt(String prompt) {
        this.prompt = prompt;
        return this;
    }
    public String getPrompt() {
        return this.prompt;
    }

    public GenerateTaskIdRequest setScene(String scene) {
        this.scene = scene;
        return this;
    }
    public String getScene() {
        return this.scene;
    }

    public GenerateTaskIdRequest setTemperature(Double temperature) {
        this.temperature = temperature;
        return this;
    }
    public Double getTemperature() {
        return this.temperature;
    }

    public GenerateTaskIdRequest setTopP(Double topP) {
        this.topP = topP;
        return this;
    }
    public Double getTopP() {
        return this.topP;
    }

    public GenerateTaskIdRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
