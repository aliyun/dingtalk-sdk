// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkats_1_0.models;

import com.aliyun.tea.*;

public class AddApplicationRegFormTemplateRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>ddats</p>
     */
    @NameInMap("bizCode")
    public String bizCode;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>{&quot;key&quot;:&quot;value&quot;}</p>
     */
    @NameInMap("content")
    public String content;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>应聘登记表</p>
     */
    @NameInMap("name")
    public String name;

    /**
     * <strong>example:</strong>
     * <p>xxx</p>
     */
    @NameInMap("outerId")
    public String outerId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>xxx</p>
     */
    @NameInMap("opUserId")
    public String opUserId;

    public static AddApplicationRegFormTemplateRequest build(java.util.Map<String, ?> map) throws Exception {
        AddApplicationRegFormTemplateRequest self = new AddApplicationRegFormTemplateRequest();
        return TeaModel.build(map, self);
    }

    public AddApplicationRegFormTemplateRequest setBizCode(String bizCode) {
        this.bizCode = bizCode;
        return this;
    }
    public String getBizCode() {
        return this.bizCode;
    }

    public AddApplicationRegFormTemplateRequest setContent(String content) {
        this.content = content;
        return this;
    }
    public String getContent() {
        return this.content;
    }

    public AddApplicationRegFormTemplateRequest setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public AddApplicationRegFormTemplateRequest setOuterId(String outerId) {
        this.outerId = outerId;
        return this;
    }
    public String getOuterId() {
        return this.outerId;
    }

    public AddApplicationRegFormTemplateRequest setOpUserId(String opUserId) {
        this.opUserId = opUserId;
        return this;
    }
    public String getOpUserId() {
        return this.opUserId;
    }

}
