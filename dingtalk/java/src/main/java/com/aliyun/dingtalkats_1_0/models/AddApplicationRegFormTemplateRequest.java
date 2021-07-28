// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkats_1_0.models;

import com.aliyun.tea.*;

public class AddApplicationRegFormTemplateRequest extends TeaModel {
    // 业务标识
    @NameInMap("bizCode")
    public String bizCode;

    // 模板名称
    @NameInMap("name")
    public String name;

    // 模板内容
    @NameInMap("content")
    public String content;

    // 外部唯一标识
    @NameInMap("outerId")
    public String outerId;

    // 操作人员工标识
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

    public AddApplicationRegFormTemplateRequest setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public AddApplicationRegFormTemplateRequest setContent(String content) {
        this.content = content;
        return this;
    }
    public String getContent() {
        return this.content;
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
