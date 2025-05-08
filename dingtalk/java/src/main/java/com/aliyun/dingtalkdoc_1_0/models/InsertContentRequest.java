// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class InsertContentRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>content</p>
     */
    @NameInMap("content")
    public java.util.Map<String, ?> content;

    /**
     * <strong>example:</strong>
     * <p>index</p>
     */
    @NameInMap("index")
    public Integer index;

    /**
     * <strong>example:</strong>
     * <p>path</p>
     */
    @NameInMap("path")
    public java.util.List<Integer> path;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>union_id</p>
     */
    @NameInMap("operatorId")
    public String operatorId;

    public static InsertContentRequest build(java.util.Map<String, ?> map) throws Exception {
        InsertContentRequest self = new InsertContentRequest();
        return TeaModel.build(map, self);
    }

    public InsertContentRequest setContent(java.util.Map<String, ?> content) {
        this.content = content;
        return this;
    }
    public java.util.Map<String, ?> getContent() {
        return this.content;
    }

    public InsertContentRequest setIndex(Integer index) {
        this.index = index;
        return this;
    }
    public Integer getIndex() {
        return this.index;
    }

    public InsertContentRequest setPath(java.util.List<Integer> path) {
        this.path = path;
        return this;
    }
    public java.util.List<Integer> getPath() {
        return this.path;
    }

    public InsertContentRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

}
