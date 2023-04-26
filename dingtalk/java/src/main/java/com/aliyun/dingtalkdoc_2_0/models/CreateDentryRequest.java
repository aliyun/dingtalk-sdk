// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class CreateDentryRequest extends TeaModel {
    @NameInMap("dentryType")
    public String dentryType;

    @NameInMap("documentType")
    public Long documentType;

    @NameInMap("name")
    public String name;

    @NameInMap("operatorId")
    public String operatorId;

    @NameInMap("parentDentryId")
    public String parentDentryId;

    public static CreateDentryRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateDentryRequest self = new CreateDentryRequest();
        return TeaModel.build(map, self);
    }

    public CreateDentryRequest setDentryType(String dentryType) {
        this.dentryType = dentryType;
        return this;
    }
    public String getDentryType() {
        return this.dentryType;
    }

    public CreateDentryRequest setDocumentType(Long documentType) {
        this.documentType = documentType;
        return this;
    }
    public Long getDocumentType() {
        return this.documentType;
    }

    public CreateDentryRequest setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public CreateDentryRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

    public CreateDentryRequest setParentDentryId(String parentDentryId) {
        this.parentDentryId = parentDentryId;
        return this;
    }
    public String getParentDentryId() {
        return this.parentDentryId;
    }

}
