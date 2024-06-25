// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkai_paa_s_1_0.models;

import com.aliyun.tea.*;

public class LiandanluTextToImageModelRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>IMAGE</p>
     */
    @NameInMap("module")
    public String module;

    /**
     * <strong>example:</strong>
     * <p>1</p>
     */
    @NameInMap("number")
    public Long number;

    @NameInMap("parameters")
    public java.util.Map<String, String> parameters;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>画一副风景画</p>
     */
    @NameInMap("prompt")
    public String prompt;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>1</p>
     */
    @NameInMap("userId")
    public String userId;

    public static LiandanluTextToImageModelRequest build(java.util.Map<String, ?> map) throws Exception {
        LiandanluTextToImageModelRequest self = new LiandanluTextToImageModelRequest();
        return TeaModel.build(map, self);
    }

    public LiandanluTextToImageModelRequest setModule(String module) {
        this.module = module;
        return this;
    }
    public String getModule() {
        return this.module;
    }

    public LiandanluTextToImageModelRequest setNumber(Long number) {
        this.number = number;
        return this;
    }
    public Long getNumber() {
        return this.number;
    }

    public LiandanluTextToImageModelRequest setParameters(java.util.Map<String, String> parameters) {
        this.parameters = parameters;
        return this;
    }
    public java.util.Map<String, String> getParameters() {
        return this.parameters;
    }

    public LiandanluTextToImageModelRequest setPrompt(String prompt) {
        this.prompt = prompt;
        return this;
    }
    public String getPrompt() {
        return this.prompt;
    }

    public LiandanluTextToImageModelRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
