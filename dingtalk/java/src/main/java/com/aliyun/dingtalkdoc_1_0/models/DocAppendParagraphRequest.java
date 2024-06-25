// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class DocAppendParagraphRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>element_type</p>
     */
    @NameInMap("elementType")
    public String elementType;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>properties</p>
     */
    @NameInMap("properties")
    public java.util.Map<String, ?> properties;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>union_id</p>
     */
    @NameInMap("operatorId")
    public String operatorId;

    public static DocAppendParagraphRequest build(java.util.Map<String, ?> map) throws Exception {
        DocAppendParagraphRequest self = new DocAppendParagraphRequest();
        return TeaModel.build(map, self);
    }

    public DocAppendParagraphRequest setElementType(String elementType) {
        this.elementType = elementType;
        return this;
    }
    public String getElementType() {
        return this.elementType;
    }

    public DocAppendParagraphRequest setProperties(java.util.Map<String, ?> properties) {
        this.properties = properties;
        return this;
    }
    public java.util.Map<String, ?> getProperties() {
        return this.properties;
    }

    public DocAppendParagraphRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

}
