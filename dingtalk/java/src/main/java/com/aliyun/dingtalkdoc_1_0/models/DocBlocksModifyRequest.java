// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class DocBlocksModifyRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>element</p>
     */
    @NameInMap("element")
    public java.util.Map<String, ?> element;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>union_id</p>
     */
    @NameInMap("operatorId")
    public String operatorId;

    public static DocBlocksModifyRequest build(java.util.Map<String, ?> map) throws Exception {
        DocBlocksModifyRequest self = new DocBlocksModifyRequest();
        return TeaModel.build(map, self);
    }

    public DocBlocksModifyRequest setElement(java.util.Map<String, ?> element) {
        this.element = element;
        return this;
    }
    public java.util.Map<String, ?> getElement() {
        return this.element;
    }

    public DocBlocksModifyRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

}
