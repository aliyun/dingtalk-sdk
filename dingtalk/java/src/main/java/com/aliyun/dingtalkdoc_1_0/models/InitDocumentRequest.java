// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class InitDocumentRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>attachments_map</p>
     */
    @NameInMap("attachmentsMap")
    public java.util.Map<String, AttachmentsMapValue> attachmentsMap;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>import_type</p>
     */
    @NameInMap("importType")
    public Integer importType;

    /**
     * <strong>example:</strong>
     * <p>links_key</p>
     */
    @NameInMap("linksKey")
    public String linksKey;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>union_id</p>
     */
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
