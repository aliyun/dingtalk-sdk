// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class MasterDatasGetResponseBody extends TeaModel {
    @NameInMap("result")
    public MasterDatasGetResponseBodyResult result;

    public static MasterDatasGetResponseBody build(java.util.Map<String, ?> map) throws Exception {
        MasterDatasGetResponseBody self = new MasterDatasGetResponseBody();
        return TeaModel.build(map, self);
    }

    public MasterDatasGetResponseBody setResult(MasterDatasGetResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public MasterDatasGetResponseBodyResult getResult() {
        return this.result;
    }

    public static class MasterDatasGetResponseBodyResultViewEntityFieldVOListFieldDataVO extends TeaModel {
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

        public static MasterDatasGetResponseBodyResultViewEntityFieldVOListFieldDataVO build(java.util.Map<String, ?> map) throws Exception {
            MasterDatasGetResponseBodyResultViewEntityFieldVOListFieldDataVO self = new MasterDatasGetResponseBodyResultViewEntityFieldVOListFieldDataVO();
            return TeaModel.build(map, self);
        }

        public MasterDatasGetResponseBodyResultViewEntityFieldVOListFieldDataVO setKey(String key) {
            this.key = key;
            return this;
        }
        public String getKey() {
            return this.key;
        }

        public MasterDatasGetResponseBodyResultViewEntityFieldVOListFieldDataVO setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

    }

    public static class MasterDatasGetResponseBodyResultViewEntityFieldVOList extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>performanceValue</p>
         */
        @NameInMap("fieldCode")
        public String fieldCode;

        @NameInMap("fieldDataVO")
        public MasterDatasGetResponseBodyResultViewEntityFieldVOListFieldDataVO fieldDataVO;

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

        public static MasterDatasGetResponseBodyResultViewEntityFieldVOList build(java.util.Map<String, ?> map) throws Exception {
            MasterDatasGetResponseBodyResultViewEntityFieldVOList self = new MasterDatasGetResponseBodyResultViewEntityFieldVOList();
            return TeaModel.build(map, self);
        }

        public MasterDatasGetResponseBodyResultViewEntityFieldVOList setFieldCode(String fieldCode) {
            this.fieldCode = fieldCode;
            return this;
        }
        public String getFieldCode() {
            return this.fieldCode;
        }

        public MasterDatasGetResponseBodyResultViewEntityFieldVOList setFieldDataVO(MasterDatasGetResponseBodyResultViewEntityFieldVOListFieldDataVO fieldDataVO) {
            this.fieldDataVO = fieldDataVO;
            return this;
        }
        public MasterDatasGetResponseBodyResultViewEntityFieldVOListFieldDataVO getFieldDataVO() {
            return this.fieldDataVO;
        }

        public MasterDatasGetResponseBodyResultViewEntityFieldVOList setFieldName(String fieldName) {
            this.fieldName = fieldName;
            return this;
        }
        public String getFieldName() {
            return this.fieldName;
        }

        public MasterDatasGetResponseBodyResultViewEntityFieldVOList setFieldType(String fieldType) {
            this.fieldType = fieldType;
            return this;
        }
        public String getFieldType() {
            return this.fieldType;
        }

    }

    public static class MasterDatasGetResponseBodyResult extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>uk123123</p>
         */
        @NameInMap("objId")
        public String objId;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>admind123</p>
         */
        @NameInMap("relationId")
        public String relationId;

        /**
         * <strong>example:</strong>
         * <p>PERFORMANCE</p>
         */
        @NameInMap("scopeCode")
        public String scopeCode;

        /**
         * <strong>example:</strong>
         * <p>base</p>
         */
        @NameInMap("viewEntityCode")
        public String viewEntityCode;

        @NameInMap("viewEntityFieldVOList")
        public java.util.List<MasterDatasGetResponseBodyResultViewEntityFieldVOList> viewEntityFieldVOList;

        public static MasterDatasGetResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            MasterDatasGetResponseBodyResult self = new MasterDatasGetResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public MasterDatasGetResponseBodyResult setObjId(String objId) {
            this.objId = objId;
            return this;
        }
        public String getObjId() {
            return this.objId;
        }

        public MasterDatasGetResponseBodyResult setRelationId(String relationId) {
            this.relationId = relationId;
            return this;
        }
        public String getRelationId() {
            return this.relationId;
        }

        public MasterDatasGetResponseBodyResult setScopeCode(String scopeCode) {
            this.scopeCode = scopeCode;
            return this;
        }
        public String getScopeCode() {
            return this.scopeCode;
        }

        public MasterDatasGetResponseBodyResult setViewEntityCode(String viewEntityCode) {
            this.viewEntityCode = viewEntityCode;
            return this;
        }
        public String getViewEntityCode() {
            return this.viewEntityCode;
        }

        public MasterDatasGetResponseBodyResult setViewEntityFieldVOList(java.util.List<MasterDatasGetResponseBodyResultViewEntityFieldVOList> viewEntityFieldVOList) {
            this.viewEntityFieldVOList = viewEntityFieldVOList;
            return this;
        }
        public java.util.List<MasterDatasGetResponseBodyResultViewEntityFieldVOList> getViewEntityFieldVOList() {
            return this.viewEntityFieldVOList;
        }

    }

}
