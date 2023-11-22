// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class MasterDatasQueryResponseBody extends TeaModel {
    @NameInMap("hasMore")
    public Boolean hasMore;

    @NameInMap("nextToken")
    public Long nextToken;

    @NameInMap("result")
    public java.util.List<MasterDatasQueryResponseBodyResult> result;

    @NameInMap("success")
    public Boolean success;

    @NameInMap("total")
    public Long total;

    public static MasterDatasQueryResponseBody build(java.util.Map<String, ?> map) throws Exception {
        MasterDatasQueryResponseBody self = new MasterDatasQueryResponseBody();
        return TeaModel.build(map, self);
    }

    public MasterDatasQueryResponseBody setHasMore(Boolean hasMore) {
        this.hasMore = hasMore;
        return this;
    }
    public Boolean getHasMore() {
        return this.hasMore;
    }

    public MasterDatasQueryResponseBody setNextToken(Long nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public Long getNextToken() {
        return this.nextToken;
    }

    public MasterDatasQueryResponseBody setResult(java.util.List<MasterDatasQueryResponseBodyResult> result) {
        this.result = result;
        return this;
    }
    public java.util.List<MasterDatasQueryResponseBodyResult> getResult() {
        return this.result;
    }

    public MasterDatasQueryResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public MasterDatasQueryResponseBody setTotal(Long total) {
        this.total = total;
        return this;
    }
    public Long getTotal() {
        return this.total;
    }

    public static class MasterDatasQueryResponseBodyResultViewEntityFieldVOListFieldDataVO extends TeaModel {
        @NameInMap("key")
        public String key;

        @NameInMap("value")
        public String value;

        public static MasterDatasQueryResponseBodyResultViewEntityFieldVOListFieldDataVO build(java.util.Map<String, ?> map) throws Exception {
            MasterDatasQueryResponseBodyResultViewEntityFieldVOListFieldDataVO self = new MasterDatasQueryResponseBodyResultViewEntityFieldVOListFieldDataVO();
            return TeaModel.build(map, self);
        }

        public MasterDatasQueryResponseBodyResultViewEntityFieldVOListFieldDataVO setKey(String key) {
            this.key = key;
            return this;
        }
        public String getKey() {
            return this.key;
        }

        public MasterDatasQueryResponseBodyResultViewEntityFieldVOListFieldDataVO setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

    }

    public static class MasterDatasQueryResponseBodyResultViewEntityFieldVOList extends TeaModel {
        @NameInMap("fieldCode")
        public String fieldCode;

        @NameInMap("fieldDataVO")
        public MasterDatasQueryResponseBodyResultViewEntityFieldVOListFieldDataVO fieldDataVO;

        @NameInMap("fieldName")
        public String fieldName;

        @NameInMap("fieldType")
        public String fieldType;

        public static MasterDatasQueryResponseBodyResultViewEntityFieldVOList build(java.util.Map<String, ?> map) throws Exception {
            MasterDatasQueryResponseBodyResultViewEntityFieldVOList self = new MasterDatasQueryResponseBodyResultViewEntityFieldVOList();
            return TeaModel.build(map, self);
        }

        public MasterDatasQueryResponseBodyResultViewEntityFieldVOList setFieldCode(String fieldCode) {
            this.fieldCode = fieldCode;
            return this;
        }
        public String getFieldCode() {
            return this.fieldCode;
        }

        public MasterDatasQueryResponseBodyResultViewEntityFieldVOList setFieldDataVO(MasterDatasQueryResponseBodyResultViewEntityFieldVOListFieldDataVO fieldDataVO) {
            this.fieldDataVO = fieldDataVO;
            return this;
        }
        public MasterDatasQueryResponseBodyResultViewEntityFieldVOListFieldDataVO getFieldDataVO() {
            return this.fieldDataVO;
        }

        public MasterDatasQueryResponseBodyResultViewEntityFieldVOList setFieldName(String fieldName) {
            this.fieldName = fieldName;
            return this;
        }
        public String getFieldName() {
            return this.fieldName;
        }

        public MasterDatasQueryResponseBodyResultViewEntityFieldVOList setFieldType(String fieldType) {
            this.fieldType = fieldType;
            return this;
        }
        public String getFieldType() {
            return this.fieldType;
        }

    }

    public static class MasterDatasQueryResponseBodyResult extends TeaModel {
        @NameInMap("outerId")
        public String outerId;

        @NameInMap("relationId")
        public String relationId;

        @NameInMap("scopeCode")
        public String scopeCode;

        @NameInMap("viewEntityCode")
        public String viewEntityCode;

        @NameInMap("viewEntityFieldVOList")
        public java.util.List<MasterDatasQueryResponseBodyResultViewEntityFieldVOList> viewEntityFieldVOList;

        public static MasterDatasQueryResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            MasterDatasQueryResponseBodyResult self = new MasterDatasQueryResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public MasterDatasQueryResponseBodyResult setOuterId(String outerId) {
            this.outerId = outerId;
            return this;
        }
        public String getOuterId() {
            return this.outerId;
        }

        public MasterDatasQueryResponseBodyResult setRelationId(String relationId) {
            this.relationId = relationId;
            return this;
        }
        public String getRelationId() {
            return this.relationId;
        }

        public MasterDatasQueryResponseBodyResult setScopeCode(String scopeCode) {
            this.scopeCode = scopeCode;
            return this;
        }
        public String getScopeCode() {
            return this.scopeCode;
        }

        public MasterDatasQueryResponseBodyResult setViewEntityCode(String viewEntityCode) {
            this.viewEntityCode = viewEntityCode;
            return this;
        }
        public String getViewEntityCode() {
            return this.viewEntityCode;
        }

        public MasterDatasQueryResponseBodyResult setViewEntityFieldVOList(java.util.List<MasterDatasQueryResponseBodyResultViewEntityFieldVOList> viewEntityFieldVOList) {
            this.viewEntityFieldVOList = viewEntityFieldVOList;
            return this;
        }
        public java.util.List<MasterDatasQueryResponseBodyResultViewEntityFieldVOList> getViewEntityFieldVOList() {
            return this.viewEntityFieldVOList;
        }

    }

}
