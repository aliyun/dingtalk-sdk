// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class GetSheetResponseBody extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>column_count</p>
     */
    @NameInMap("columnCount")
    public Long columnCount;

    @NameInMap("frozenColumnCount")
    public Long frozenColumnCount;

    @NameInMap("frozenRowCount")
    public Long frozenRowCount;

    /**
     * <strong>example:</strong>
     * <p>sheet_id</p>
     */
    @NameInMap("id")
    public String id;

    /**
     * <strong>example:</strong>
     * <p>last_non_empty_column</p>
     */
    @NameInMap("lastNonEmptyColumn")
    public Long lastNonEmptyColumn;

    /**
     * <strong>example:</strong>
     * <p>last_non_empty_row</p>
     */
    @NameInMap("lastNonEmptyRow")
    public Long lastNonEmptyRow;

    /**
     * <strong>example:</strong>
     * <p>sheet_name</p>
     */
    @NameInMap("name")
    public String name;

    /**
     * <strong>example:</strong>
     * <p>row_count</p>
     */
    @NameInMap("rowCount")
    public Long rowCount;

    /**
     * <strong>example:</strong>
     * <p>visible</p>
     */
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

    public GetSheetResponseBody setFrozenColumnCount(Long frozenColumnCount) {
        this.frozenColumnCount = frozenColumnCount;
        return this;
    }
    public Long getFrozenColumnCount() {
        return this.frozenColumnCount;
    }

    public GetSheetResponseBody setFrozenRowCount(Long frozenRowCount) {
        this.frozenRowCount = frozenRowCount;
        return this;
    }
    public Long getFrozenRowCount() {
        return this.frozenRowCount;
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
