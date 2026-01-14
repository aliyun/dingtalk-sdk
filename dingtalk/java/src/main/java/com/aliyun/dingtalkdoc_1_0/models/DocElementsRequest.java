// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class DocElementsRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>cursor</p>
     */
    @NameInMap("cursor")
    public String cursor;

    /**
     * <strong>example:</strong>
     * <p>resource</p>
     */
    @NameInMap("elementType")
    public String elementType;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>union_id</p>
     */
    @NameInMap("operatorId")
    public String operatorId;

    /**
     * <strong>example:</strong>
     * <p>20</p>
     */
    @NameInMap("size")
    public Integer size;

    public static DocElementsRequest build(java.util.Map<String, ?> map) throws Exception {
        DocElementsRequest self = new DocElementsRequest();
        return TeaModel.build(map, self);
    }

    public DocElementsRequest setCursor(String cursor) {
        this.cursor = cursor;
        return this;
    }
    public String getCursor() {
        return this.cursor;
    }

    public DocElementsRequest setElementType(String elementType) {
        this.elementType = elementType;
        return this;
    }
    public String getElementType() {
        return this.elementType;
    }

    public DocElementsRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

    public DocElementsRequest setSize(Integer size) {
        this.size = size;
        return this;
    }
    public Integer getSize() {
        return this.size;
    }

}
