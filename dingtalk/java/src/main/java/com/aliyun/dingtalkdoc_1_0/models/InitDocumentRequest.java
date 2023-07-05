// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class InitDocumentRequest extends TeaModel {
    @NameInMap("attachmentsMap")
    public java.util.Map<String, AttachmentsMapValue> attachmentsMap;

    @NameInMap("importType")
    public Integer importType;

    @NameInMap("linksKey")
    public String linksKey;

    @NameInMap("operatorId")
    public String operatorId;

    public static InitDocumentRequest build(java.util.Map<String, ?> map) throws Exception {
        InitDocumentRequest self = new InitDocumentRequest();
        return TeaModel.build(map, self);
    }

    public InitDocumentRequest setAttachmentsMap(java.util.Map<String, AttachmentsMapValue> attachmentsMap) {
        this.attachmentsMap = attachmentsMap;
        return this;
    }
    public java.util.Map<String, AttachmentsMapValue> getAttachmentsMap() {
        return this.attachmentsMap;
    }

    public InitDocumentRequest setImportType(Integer importType) {
        this.importType = importType;
        return this;
    }
    public Integer getImportType() {
        return this.importType;
    }

    public InitDocumentRequest setLinksKey(String linksKey) {
        this.linksKey = linksKey;
        return this;
    }
    public String getLinksKey() {
        return this.linksKey;
    }

    public InitDocumentRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

}
