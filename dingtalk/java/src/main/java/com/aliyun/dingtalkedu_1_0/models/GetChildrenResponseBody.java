// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class GetChildrenResponseBody extends TeaModel {
    @NameInMap("result")
    public java.util.List<GetChildrenResponseBodyResult> result;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("success")
    public Boolean success;

    public static GetChildrenResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetChildrenResponseBody self = new GetChildrenResponseBody();
        return TeaModel.build(map, self);
    }

    public GetChildrenResponseBody setResult(java.util.List<GetChildrenResponseBodyResult> result) {
        this.result = result;
        return this;
    }
    public java.util.List<GetChildrenResponseBodyResult> getResult() {
        return this.result;
    }

    public GetChildrenResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class GetChildrenResponseBodyResultBindStudents extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>1</p>
         */
        @NameInMap("gradeLevel")
        public Integer gradeLevel;

        /**
         * <strong>example:</strong>
         * <p>dinge066bea21c63b79b35c2f4657eb6378f</p>
         */
        @NameInMap("identityId")
        public String identityId;

        /**
         * <strong>example:</strong>
         * <p>primary_school</p>
         */
        @NameInMap("periodCode")
        public String periodCode;

        public static GetChildrenResponseBodyResultBindStudents build(java.util.Map<String, ?> map) throws Exception {
            GetChildrenResponseBodyResultBindStudents self = new GetChildrenResponseBodyResultBindStudents();
            return TeaModel.build(map, self);
        }

        public GetChildrenResponseBodyResultBindStudents setGradeLevel(Integer gradeLevel) {
            this.gradeLevel = gradeLevel;
            return this;
        }
        public Integer getGradeLevel() {
            return this.gradeLevel;
        }

        public GetChildrenResponseBodyResultBindStudents setIdentityId(String identityId) {
            this.identityId = identityId;
            return this;
        }
        public String getIdentityId() {
            return this.identityId;
        }

        public GetChildrenResponseBodyResultBindStudents setPeriodCode(String periodCode) {
            this.periodCode = periodCode;
            return this;
        }
        public String getPeriodCode() {
            return this.periodCode;
        }

    }

    public static class GetChildrenResponseBodyResult extends TeaModel {
        @NameInMap("bindStudents")
        public java.util.List<GetChildrenResponseBodyResultBindStudents> bindStudents;

        /**
         * <strong>example:</strong>
         * <p>杭州市</p>
         */
        @NameInMap("city")
        public String city;

        /**
         * <strong>example:</strong>
         * <p>西湖区</p>
         */
        @NameInMap("district")
        public String district;

        /**
         * <strong>example:</strong>
         * <p>1</p>
         */
        @NameInMap("gradeLevel")
        public Integer gradeLevel;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>张三</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <strong>example:</strong>
         * <p>primary_school</p>
         */
        @NameInMap("periodCode")
        public String periodCode;

        /**
         * <strong>example:</strong>
         * <p>浙江省</p>
         */
        @NameInMap("province")
        public String province;

        /**
         * <strong>example:</strong>
         * <p>330106</p>
         */
        @NameInMap("regionId")
        public String regionId;

        public static GetChildrenResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            GetChildrenResponseBodyResult self = new GetChildrenResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public GetChildrenResponseBodyResult setBindStudents(java.util.List<GetChildrenResponseBodyResultBindStudents> bindStudents) {
            this.bindStudents = bindStudents;
            return this;
        }
        public java.util.List<GetChildrenResponseBodyResultBindStudents> getBindStudents() {
            return this.bindStudents;
        }

        public GetChildrenResponseBodyResult setCity(String city) {
            this.city = city;
            return this;
        }
        public String getCity() {
            return this.city;
        }

        public GetChildrenResponseBodyResult setDistrict(String district) {
            this.district = district;
            return this;
        }
        public String getDistrict() {
            return this.district;
        }

        public GetChildrenResponseBodyResult setGradeLevel(Integer gradeLevel) {
            this.gradeLevel = gradeLevel;
            return this;
        }
        public Integer getGradeLevel() {
            return this.gradeLevel;
        }

        public GetChildrenResponseBodyResult setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public GetChildrenResponseBodyResult setPeriodCode(String periodCode) {
            this.periodCode = periodCode;
            return this;
        }
        public String getPeriodCode() {
            return this.periodCode;
        }

        public GetChildrenResponseBodyResult setProvince(String province) {
            this.province = province;
            return this;
        }
        public String getProvince() {
            return this.province;
        }

        public GetChildrenResponseBodyResult setRegionId(String regionId) {
            this.regionId = regionId;
            return this;
        }
        public String getRegionId() {
            return this.regionId;
        }

    }

}
