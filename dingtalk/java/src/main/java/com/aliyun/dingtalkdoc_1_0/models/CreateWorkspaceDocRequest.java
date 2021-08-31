// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class CreateWorkspaceDocRequest extends TeaModel {
    // 文档名
    @NameInMap("name")
    public String name;

    // 文档类型
    @NameInMap("docType")
    public String docType;

    // 操作人unionId
    @NameInMap("operatorId")
    public String operatorId;

    public static CreateWorkspaceDocRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateWorkspaceDocRequest self = new CreateWorkspaceDocRequest();
        return TeaModel.build(map, self);
    }

    public CreateWorkspaceDocRequest setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public CreateWorkspaceDocRequest setDocType(String docType) {
        this.docType = docType;
        return this;
    }
    public String getDocType() {
        return this.docType;
    }

    public CreateWorkspaceDocRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

}
