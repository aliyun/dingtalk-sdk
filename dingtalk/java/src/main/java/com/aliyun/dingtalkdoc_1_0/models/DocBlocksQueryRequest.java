// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class DocBlocksQueryRequest extends TeaModel {
    @NameInMap("blockType")
    public String blockType;

    @NameInMap("endIndex")
    public Integer endIndex;

    @NameInMap("operatorId")
    public String operatorId;

    @NameInMap("startIndex")
    public Integer startIndex;

    public static DocBlocksQueryRequest build(java.util.Map<String, ?> map) throws Exception {
        DocBlocksQueryRequest self = new DocBlocksQueryRequest();
        return TeaModel.build(map, self);
    }

    public DocBlocksQueryRequest setBlockType(String blockType) {
        this.blockType = blockType;
        return this;
    }
    public String getBlockType() {
        return this.blockType;
    }

    public DocBlocksQueryRequest setEndIndex(Integer endIndex) {
        this.endIndex = endIndex;
        return this;
    }
    public Integer getEndIndex() {
        return this.endIndex;
    }

    public DocBlocksQueryRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

    public DocBlocksQueryRequest setStartIndex(Integer startIndex) {
        this.startIndex = startIndex;
        return this;
    }
    public Integer getStartIndex() {
        return this.startIndex;
    }

}
