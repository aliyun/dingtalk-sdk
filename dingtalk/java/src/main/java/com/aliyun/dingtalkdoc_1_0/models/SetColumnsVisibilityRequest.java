// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class SetColumnsVisibilityRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("column")
    public Long column;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("columnCount")
    public Long columnCount;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("visibility")
    public String visibility;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("operatorId")
    public String operatorId;

    public static SetColumnsVisibilityRequest build(java.util.Map<String, ?> map) throws Exception {
        SetColumnsVisibilityRequest self = new SetColumnsVisibilityRequest();
        return TeaModel.build(map, self);
    }

    public SetColumnsVisibilityRequest setColumn(Long column) {
        this.column = column;
        return this;
    }
    public Long getColumn() {
        return this.column;
    }

    public SetColumnsVisibilityRequest setColumnCount(Long columnCount) {
        this.columnCount = columnCount;
        return this;
    }
    public Long getColumnCount() {
        return this.columnCount;
    }

    public SetColumnsVisibilityRequest setVisibility(String visibility) {
        this.visibility = visibility;
        return this;
    }
    public String getVisibility() {
        return this.visibility;
    }

    public SetColumnsVisibilityRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

}
