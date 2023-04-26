// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class CreateWorkspaceDocRequest extends TeaModel {
    @NameInMap("docType")
    public String docType;

    @NameInMap("name")
    public String name;

    @NameInMap("operatorId")
    public String operatorId;

    @NameInMap("parentNodeId")
    public String parentNodeId;

    @NameInMap("templateId")
    public String templateId;

    @NameInMap("templateType")
    public String templateType;

    public static CreateWorkspaceDocRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateWorkspaceDocRequest self = new CreateWorkspaceDocRequest();
        return TeaModel.build(map, self);
    }

    public CreateWorkspaceDocRequest setDocType(String docType) {
        this.docType = docType;
        return this;
    }
    public String getDocType() {
        return this.docType;
    }

    public CreateWorkspaceDocRequest setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public CreateWorkspaceDocRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

    public CreateWorkspaceDocRequest setParentNodeId(String parentNodeId) {
        this.parentNodeId = parentNodeId;
        return this;
    }
    public String getParentNodeId() {
        return this.parentNodeId;
    }

    public CreateWorkspaceDocRequest setTemplateId(String templateId) {
        this.templateId = templateId;
        return this;
    }
    public String getTemplateId() {
        return this.templateId;
    }

    public CreateWorkspaceDocRequest setTemplateType(String templateType) {
        this.templateType = templateType;
        return this;
    }
    public String getTemplateType() {
        return this.templateType;
    }

}
