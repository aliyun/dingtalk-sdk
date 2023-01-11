// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcustomer_service_1_0.models;

import com.aliyun.tea.*;

public class PageListActionResponseBody extends TeaModel {
    /**
     * <p>list</p>
     */
    @NameInMap("list")
    public java.util.List<PageListActionResponseBodyList> list;

    /**
     * <p>nextCursor</p>
     */
    @NameInMap("nextCursor")
    public Long nextCursor;

    /**
     * <p>total</p>
     */
    @NameInMap("total")
    public Long total;

    public static PageListActionResponseBody build(java.util.Map<String, ?> map) throws Exception {
        PageListActionResponseBody self = new PageListActionResponseBody();
        return TeaModel.build(map, self);
    }

    public PageListActionResponseBody setList(java.util.List<PageListActionResponseBodyList> list) {
        this.list = list;
        return this;
    }
    public java.util.List<PageListActionResponseBodyList> getList() {
        return this.list;
    }

    public PageListActionResponseBody setNextCursor(Long nextCursor) {
        this.nextCursor = nextCursor;
        return this;
    }
    public Long getNextCursor() {
        return this.nextCursor;
    }

    public PageListActionResponseBody setTotal(Long total) {
        this.total = total;
        return this;
    }
    public Long getTotal() {
        return this.total;
    }

    public static class PageListActionResponseBodyListActionContent extends TeaModel {
        /**
         * <p>displayName</p>
         */
        @NameInMap("displayName")
        public String displayName;

        /**
         * <p>displayValue</p>
         */
        @NameInMap("displayValue")
        public String displayValue;

        /**
         * <p>name</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <p>value</p>
         */
        @NameInMap("value")
        public String value;

        /**
         * <p>valueType</p>
         */
        @NameInMap("valueType")
        public String valueType;

        public static PageListActionResponseBodyListActionContent build(java.util.Map<String, ?> map) throws Exception {
            PageListActionResponseBodyListActionContent self = new PageListActionResponseBodyListActionContent();
            return TeaModel.build(map, self);
        }

        public PageListActionResponseBodyListActionContent setDisplayName(String displayName) {
            this.displayName = displayName;
            return this;
        }
        public String getDisplayName() {
            return this.displayName;
        }

        public PageListActionResponseBodyListActionContent setDisplayValue(String displayValue) {
            this.displayValue = displayValue;
            return this;
        }
        public String getDisplayValue() {
            return this.displayValue;
        }

        public PageListActionResponseBodyListActionContent setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public PageListActionResponseBodyListActionContent setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

        public PageListActionResponseBodyListActionContent setValueType(String valueType) {
            this.valueType = valueType;
            return this;
        }
        public String getValueType() {
            return this.valueType;
        }

    }

    public static class PageListActionResponseBodyList extends TeaModel {
        /**
         * <p>actionCode</p>
         */
        @NameInMap("actionCode")
        public String actionCode;

        /**
         * <p>actionContent</p>
         */
        @NameInMap("actionContent")
        public java.util.List<PageListActionResponseBodyListActionContent> actionContent;

        /**
         * <p>operator</p>
         */
        @NameInMap("operator")
        public String operator;

        /**
         * <p>operatorId</p>
         */
        @NameInMap("operatorId")
        public String operatorId;

        /**
         * <p>operatorRole</p>
         */
        @NameInMap("operatorRole")
        public String operatorRole;

        public static PageListActionResponseBodyList build(java.util.Map<String, ?> map) throws Exception {
            PageListActionResponseBodyList self = new PageListActionResponseBodyList();
            return TeaModel.build(map, self);
        }

        public PageListActionResponseBodyList setActionCode(String actionCode) {
            this.actionCode = actionCode;
            return this;
        }
        public String getActionCode() {
            return this.actionCode;
        }

        public PageListActionResponseBodyList setActionContent(java.util.List<PageListActionResponseBodyListActionContent> actionContent) {
            this.actionContent = actionContent;
            return this;
        }
        public java.util.List<PageListActionResponseBodyListActionContent> getActionContent() {
            return this.actionContent;
        }

        public PageListActionResponseBodyList setOperator(String operator) {
            this.operator = operator;
            return this;
        }
        public String getOperator() {
            return this.operator;
        }

        public PageListActionResponseBodyList setOperatorId(String operatorId) {
            this.operatorId = operatorId;
            return this;
        }
        public String getOperatorId() {
            return this.operatorId;
        }

        public PageListActionResponseBodyList setOperatorRole(String operatorRole) {
            this.operatorRole = operatorRole;
            return this;
        }
        public String getOperatorRole() {
            return this.operatorRole;
        }

    }

}
