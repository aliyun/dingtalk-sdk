// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class DocInsertBlocksRequest extends TeaModel {
    @NameInMap("blockId")
    public String blockId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("element")
    public java.util.Map<String, ?> element;

    @NameInMap("index")
    public Integer index;

    @NameInMap("where")
    public String where;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("operatorId")
    public String operatorId;

    public static DocInsertBlocksRequest build(java.util.Map<String, ?> map) throws Exception {
        DocInsertBlocksRequest self = new DocInsertBlocksRequest();
        return TeaModel.build(map, self);
    }

    public DocInsertBlocksRequest setBlockId(String blockId) {
        this.blockId = blockId;
        return this;
    }
    public String getBlockId() {
        return this.blockId;
    }

    public DocInsertBlocksRequest setElement(java.util.Map<String, ?> element) {
        this.element = element;
        return this;
    }
    public java.util.Map<String, ?> getElement() {
        return this.element;
    }

    public DocInsertBlocksRequest setIndex(Integer index) {
        this.index = index;
        return this;
    }
    public Integer getIndex() {
        return this.index;
    }

    public DocInsertBlocksRequest setWhere(String where) {
        this.where = where;
        return this;
    }
    public String getWhere() {
        return this.where;
    }

    public DocInsertBlocksRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

}
