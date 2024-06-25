// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class IsvDataWriteRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>tb_test01</p>
     */
    @NameInMap("objectCode")
    public String objectCode;

    @NameInMap("rowValueList")
    public java.util.List<java.util.List<IsvDataWriteRequestRowValueList>> rowValueList;

    public static IsvDataWriteRequest build(java.util.Map<String, ?> map) throws Exception {
        IsvDataWriteRequest self = new IsvDataWriteRequest();
        return TeaModel.build(map, self);
    }

    public IsvDataWriteRequest setObjectCode(String objectCode) {
        this.objectCode = objectCode;
        return this;
    }
    public String getObjectCode() {
        return this.objectCode;
    }

    public IsvDataWriteRequest setRowValueList(java.util.List<java.util.List<IsvDataWriteRequestRowValueList>> rowValueList) {
        this.rowValueList = rowValueList;
        return this;
    }
    public java.util.List<java.util.List<IsvDataWriteRequestRowValueList>> getRowValueList() {
        return this.rowValueList;
    }

    public static class IsvDataWriteRequestRowValueList extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>id</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <strong>example:</strong>
         * <p>1</p>
         */
        @NameInMap("value")
        public String value;

        public static IsvDataWriteRequestRowValueList build(java.util.Map<String, ?> map) throws Exception {
            IsvDataWriteRequestRowValueList self = new IsvDataWriteRequestRowValueList();
            return TeaModel.build(map, self);
        }

        public IsvDataWriteRequestRowValueList setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public IsvDataWriteRequestRowValueList setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

    }

}
