// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class GetSheetResponseBody extends TeaModel {
    // 工作表列数
    @NameInMap("columnCount")
    public Long columnCount;

    // 工作表ID
    @NameInMap("id")
    public String id;

    // 最后一列非空列的位置，从0开始。表为空时返回-1。
    @NameInMap("lastNonEmptyColumn")
    public Long lastNonEmptyColumn;

    // 最后一行非空行的位置，从0开始。表为空时返回-1。
    @NameInMap("lastNonEmptyRow")
    public Long lastNonEmptyRow;

    // 工作表名称
    @NameInMap("name")
    public String name;

    // 工作表行数
    @NameInMap("rowCount")
    public Long rowCount;

    // 工作表可见性
    @NameInMap("visibility")
    public String visibility;

    public static GetSheetResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetSheetResponseBody self = new GetSheetResponseBody();
        return TeaModel.build(map, self);
    }

    public GetSheetResponseBody setColumnCount(Long columnCount) {
        this.columnCount = columnCount;
        return this;
    }
    public Long getColumnCount() {
        return this.columnCount;
    }

    public GetSheetResponseBody setId(String id) {
        this.id = id;
        return this;
    }
    public String getId() {
        return this.id;
    }

    public GetSheetResponseBody setLastNonEmptyColumn(Long lastNonEmptyColumn) {
        this.lastNonEmptyColumn = lastNonEmptyColumn;
        return this;
    }
    public Long getLastNonEmptyColumn() {
        return this.lastNonEmptyColumn;
    }

    public GetSheetResponseBody setLastNonEmptyRow(Long lastNonEmptyRow) {
        this.lastNonEmptyRow = lastNonEmptyRow;
        return this;
    }
    public Long getLastNonEmptyRow() {
        return this.lastNonEmptyRow;
    }

    public GetSheetResponseBody setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public GetSheetResponseBody setRowCount(Long rowCount) {
        this.rowCount = rowCount;
        return this;
    }
    public Long getRowCount() {
        return this.rowCount;
    }

    public GetSheetResponseBody setVisibility(String visibility) {
        this.visibility = visibility;
        return this;
    }
    public String getVisibility() {
        return this.visibility;
    }

}
