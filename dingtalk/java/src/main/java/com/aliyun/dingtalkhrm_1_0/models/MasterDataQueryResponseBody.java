// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class MasterDataQueryResponseBody extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>true</p>
     */
    @NameInMap("hasMore")
    public Boolean hasMore;

    /**
     * <strong>example:</strong>
     * <p>0</p>
     */
    @NameInMap("nextToken")
    public Long nextToken;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("result")
    public java.util.List<MasterDataQueryResponseBodyResult> result;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>true</p>
     */
    @NameInMap("success")
    public Boolean success;

    /**
     * <strong>example:</strong>
     * <p>100</p>
     */
    @NameInMap("total")
    public Long total;

    public static MasterDataQueryResponseBody build(java.util.Map<String, ?> map) throws Exception {
        MasterDataQueryResponseBody self = new MasterDataQueryResponseBody();
        return TeaModel.build(map, self);
    }

    public MasterDataQueryResponseBody setHasMore(Boolean hasMore) {
        this.hasMore = hasMore;
        return this;
    }
    public Boolean getHasMore() {
        return this.hasMore;
    }

    public MasterDataQueryResponseBody setNextToken(Long nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public Long getNextToken() {
        return this.nextToken;
    }

    public MasterDataQueryResponseBody setResult(java.util.List<MasterDataQueryResponseBodyResult> result) {
        this.result = result;
        return this;
    }
    public java.util.List<MasterDataQueryResponseBodyResult> getResult() {
        return this.result;
    }

    public MasterDataQueryResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public MasterDataQueryResponseBody setTotal(Long total) {
        this.total = total;
        return this;
    }
    public Long getTotal() {
        return this.total;
    }

    public static class MasterDataQueryResponseBodyResultViewEntityFieldVOListFieldDataVO extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>100</p>
         */
        @NameInMap("key")
        public String key;

        /**
         * <strong>example:</strong>
         * <p>100</p>
         */
        @NameInMap("value")
        public String value;

        public static MasterDataQueryResponseBodyResultViewEntityFieldVOListFieldDataVO build(java.util.Map<String, ?> map) throws Exception {
            MasterDataQueryResponseBodyResultViewEntityFieldVOListFieldDataVO self = new MasterDataQueryResponseBodyResultViewEntityFieldVOListFieldDataVO();
            return TeaModel.build(map, self);
        }

        public MasterDataQueryResponseBodyResultViewEntityFieldVOListFieldDataVO setKey(String key) {
            this.key = key;
            return this;
        }
        public String getKey() {
            return this.key;
        }

        public MasterDataQueryResponseBodyResultViewEntityFieldVOListFieldDataVO setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

    }

    public static class MasterDataQueryResponseBodyResultViewEntityFieldVOList extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>performanceValue</p>
         */
        @NameInMap("fieldCode")
        public String fieldCode;

        @NameInMap("fieldDataVO")
        public MasterDataQueryResponseBodyResultViewEntityFieldVOListFieldDataVO fieldDataVO;

        /**
         * <strong>example:</strong>
         * <p>绩效等级</p>
         */
        @NameInMap("fieldName")
        public String fieldName;

        /**
         * <strong>example:</strong>
         * <p>1</p>
         */
        @NameInMap("fieldType")
        public String fieldType;

        public static MasterDataQueryResponseBodyResultViewEntityFieldVOList build(java.util.Map<String, ?> map) throws Exception {
            MasterDataQueryResponseBodyResultViewEntityFieldVOList self = new MasterDataQueryResponseBodyResultViewEntityFieldVOList();
            return TeaModel.build(map, self);
        }

        public MasterDataQueryResponseBodyResultViewEntityFieldVOList setFieldCode(String fieldCode) {
            this.fieldCode = fieldCode;
            return this;
        }
        public String getFieldCode() {
            return this.fieldCode;
        }

        public MasterDataQueryResponseBodyResultViewEntityFieldVOList setFieldDataVO(MasterDataQueryResponseBodyResultViewEntityFieldVOListFieldDataVO fieldDataVO) {
            this.fieldDataVO = fieldDataVO;
            return this;
        }
        public MasterDataQueryResponseBodyResultViewEntityFieldVOListFieldDataVO getFieldDataVO() {
            return this.fieldDataVO;
        }

        public MasterDataQueryResponseBodyResultViewEntityFieldVOList setFieldName(String fieldName) {
            this.fieldName = fieldName;
            return this;
        }
        public String getFieldName() {
            return this.fieldName;
        }

        public MasterDataQueryResponseBodyResultViewEntityFieldVOList setFieldType(String fieldType) {
            this.fieldType = fieldType;
            return this;
        }
        public String getFieldType() {
            return this.fieldType;
        }

    }

    public static class MasterDataQueryResponseBodyResult extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>uk123123</p>
         */
        @NameInMap("outerId")
        public String outerId;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>admind123</p>
         */
        @NameInMap("relationId")
        public String relationId;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>PERFORMANCE</p>
         */
        @NameInMap("scopeCode")
        public String scopeCode;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>base</p>
         */
        @NameInMap("viewEntityCode")
        public String viewEntityCode;

        @NameInMap("viewEntityFieldVOList")
        public java.util.List<MasterDataQueryResponseBodyResultViewEntityFieldVOList> viewEntityFieldVOList;

        public static MasterDataQueryResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            MasterDataQueryResponseBodyResult self = new MasterDataQueryResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public MasterDataQueryResponseBodyResult setOuterId(String outerId) {
            this.outerId = outerId;
            return this;
        }
        public String getOuterId() {
            return this.outerId;
        }

        public MasterDataQueryResponseBodyResult setRelationId(String relationId) {
            this.relationId = relationId;
            return this;
        }
        public String getRelationId() {
            return this.relationId;
        }

        public MasterDataQueryResponseBodyResult setScopeCode(String scopeCode) {
            this.scopeCode = scopeCode;
            return this;
        }
        public String getScopeCode() {
            return this.scopeCode;
        }

        public MasterDataQueryResponseBodyResult setViewEntityCode(String viewEntityCode) {
            this.viewEntityCode = viewEntityCode;
            return this;
        }
        public String getViewEntityCode() {
            return this.viewEntityCode;
        }

        public MasterDataQueryResponseBodyResult setViewEntityFieldVOList(java.util.List<MasterDataQueryResponseBodyResultViewEntityFieldVOList> viewEntityFieldVOList) {
            this.viewEntityFieldVOList = viewEntityFieldVOList;
            return this;
        }
        public java.util.List<MasterDataQueryResponseBodyResultViewEntityFieldVOList> getViewEntityFieldVOList() {
            return this.viewEntityFieldVOList;
        }

    }

}
