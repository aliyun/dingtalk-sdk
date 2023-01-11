// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class SetColumnsVisibilityRequest extends TeaModel {
    /**
     * <p>要显示、隐藏的第一列的位置，从0开始</p>
     */
    @NameInMap("column")
    public Long column;

    /**
     * <p>要显示、隐藏的列的数量</p>
     */
    @NameInMap("columnCount")
    public Long columnCount;

    /**
     * <p>可见性</p>
     */
    @NameInMap("visibility")
    public String visibility;

    /**
     * <p>操作人unionId</p>
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
