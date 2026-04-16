// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class SortFilterRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("field")
    public SortFilterRequestField field;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("operatorId")
    public String operatorId;

    public static SortFilterRequest build(java.util.Map<String, ?> map) throws Exception {
        SortFilterRequest self = new SortFilterRequest();
        return TeaModel.build(map, self);
    }

    public SortFilterRequest setField(SortFilterRequestField field) {
        this.field = field;
        return this;
    }
    public SortFilterRequestField getField() {
        return this.field;
    }

    public SortFilterRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

    public static class SortFilterRequestField extends TeaModel {
        @NameInMap("ascending")
        public Boolean ascending;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("column")
        public Long column;

        public static SortFilterRequestField build(java.util.Map<String, ?> map) throws Exception {
            SortFilterRequestField self = new SortFilterRequestField();
            return TeaModel.build(map, self);
        }

        public SortFilterRequestField setAscending(Boolean ascending) {
            this.ascending = ascending;
            return this;
        }
        public Boolean getAscending() {
            return this.ascending;
        }

        public SortFilterRequestField setColumn(Long column) {
            this.column = column;
            return this;
        }
        public Long getColumn() {
            return this.column;
        }

    }

}
