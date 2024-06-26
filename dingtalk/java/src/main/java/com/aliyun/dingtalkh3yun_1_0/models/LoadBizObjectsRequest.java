// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkh3yun_1_0.models;

import com.aliyun.tea.*;

public class LoadBizObjectsRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>{     &quot;Type&quot;: &quot;Item&quot;,     &quot;Name&quot;: &quot;F0000010&quot;,     &quot;Operator&quot;: 2,     &quot;Value&quot;: &quot;0000007&quot; }</p>
     */
    @NameInMap("matcherJson")
    public String matcherJson;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>1</p>
     */
    @NameInMap("pageNumber")
    public Integer pageNumber;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>10</p>
     */
    @NameInMap("pageSize")
    public Integer pageSize;

    @NameInMap("returnFields")
    public java.util.List<String> returnFields;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>D0001839bbbbe346bbf496498bb76c44c7eb972</p>
     */
    @NameInMap("schemaCode")
    public String schemaCode;

    @NameInMap("sortByFields")
    public java.util.List<LoadBizObjectsRequestSortByFields> sortByFields;

    public static LoadBizObjectsRequest build(java.util.Map<String, ?> map) throws Exception {
        LoadBizObjectsRequest self = new LoadBizObjectsRequest();
        return TeaModel.build(map, self);
    }

    public LoadBizObjectsRequest setMatcherJson(String matcherJson) {
        this.matcherJson = matcherJson;
        return this;
    }
    public String getMatcherJson() {
        return this.matcherJson;
    }

    public LoadBizObjectsRequest setPageNumber(Integer pageNumber) {
        this.pageNumber = pageNumber;
        return this;
    }
    public Integer getPageNumber() {
        return this.pageNumber;
    }

    public LoadBizObjectsRequest setPageSize(Integer pageSize) {
        this.pageSize = pageSize;
        return this;
    }
    public Integer getPageSize() {
        return this.pageSize;
    }

    public LoadBizObjectsRequest setReturnFields(java.util.List<String> returnFields) {
        this.returnFields = returnFields;
        return this;
    }
    public java.util.List<String> getReturnFields() {
        return this.returnFields;
    }

    public LoadBizObjectsRequest setSchemaCode(String schemaCode) {
        this.schemaCode = schemaCode;
        return this;
    }
    public String getSchemaCode() {
        return this.schemaCode;
    }

    public LoadBizObjectsRequest setSortByFields(java.util.List<LoadBizObjectsRequestSortByFields> sortByFields) {
        this.sortByFields = sortByFields;
        return this;
    }
    public java.util.List<LoadBizObjectsRequestSortByFields> getSortByFields() {
        return this.sortByFields;
    }

    public static class LoadBizObjectsRequestSortByFields extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>Ascending</p>
         */
        @NameInMap("direction")
        public String direction;

        /**
         * <strong>example:</strong>
         * <p>Age</p>
         */
        @NameInMap("fieldName")
        public String fieldName;

        public static LoadBizObjectsRequestSortByFields build(java.util.Map<String, ?> map) throws Exception {
            LoadBizObjectsRequestSortByFields self = new LoadBizObjectsRequestSortByFields();
            return TeaModel.build(map, self);
        }

        public LoadBizObjectsRequestSortByFields setDirection(String direction) {
            this.direction = direction;
            return this;
        }
        public String getDirection() {
            return this.direction;
        }

        public LoadBizObjectsRequestSortByFields setFieldName(String fieldName) {
            this.fieldName = fieldName;
            return this;
        }
        public String getFieldName() {
            return this.fieldName;
        }

    }

}
