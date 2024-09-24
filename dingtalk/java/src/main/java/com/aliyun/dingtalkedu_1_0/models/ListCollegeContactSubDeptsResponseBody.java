// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class ListCollegeContactSubDeptsResponseBody extends TeaModel {
    @NameInMap("result")
    public java.util.List<ListCollegeContactSubDeptsResponseBodyResult> result;

    @NameInMap("success")
    public Boolean success;

    public static ListCollegeContactSubDeptsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ListCollegeContactSubDeptsResponseBody self = new ListCollegeContactSubDeptsResponseBody();
        return TeaModel.build(map, self);
    }

    public ListCollegeContactSubDeptsResponseBody setResult(java.util.List<ListCollegeContactSubDeptsResponseBodyResult> result) {
        this.result = result;
        return this;
    }
    public java.util.List<ListCollegeContactSubDeptsResponseBodyResult> getResult() {
        return this.result;
    }

    public ListCollegeContactSubDeptsResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class ListCollegeContactSubDeptsResponseBodyResult extends TeaModel {
        @NameInMap("autoAddUser")
        public Boolean autoAddUser;

        @NameInMap("createDeptGroup")
        public Boolean createDeptGroup;

        /**
         * <strong>example:</strong>
         * <p>dept456</p>
         */
        @NameInMap("deptCode")
        public String deptCode;

        /**
         * <strong>example:</strong>
         * <p>456</p>
         */
        @NameInMap("deptId")
        public Long deptId;

        /**
         * <strong>example:</strong>
         * <p>contact_class_dept</p>
         */
        @NameInMap("deptType")
        public String deptType;

        /**
         * <strong>example:</strong>
         * <p>{}</p>
         */
        @NameInMap("extension")
        public String extension;

        @NameInMap("fromUnionOrg")
        public Boolean fromUnionOrg;

        /**
         * <strong>example:</strong>
         * <p>软件工程</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <strong>example:</strong>
         * <p>200</p>
         */
        @NameInMap("parentId")
        public Long parentId;

        /**
         * <strong>example:</strong>
         * <p>软件工程标识</p>
         */
        @NameInMap("sourceIdentifier")
        public String sourceIdentifier;

        /**
         * <strong>example:</strong>
         * <p>200</p>
         */
        @NameInMap("struId")
        public Long struId;

        /**
         * <strong>example:</strong>
         * <p>campus</p>
         */
        @NameInMap("tags")
        public String tags;

        public static ListCollegeContactSubDeptsResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            ListCollegeContactSubDeptsResponseBodyResult self = new ListCollegeContactSubDeptsResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public ListCollegeContactSubDeptsResponseBodyResult setAutoAddUser(Boolean autoAddUser) {
            this.autoAddUser = autoAddUser;
            return this;
        }
        public Boolean getAutoAddUser() {
            return this.autoAddUser;
        }

        public ListCollegeContactSubDeptsResponseBodyResult setCreateDeptGroup(Boolean createDeptGroup) {
            this.createDeptGroup = createDeptGroup;
            return this;
        }
        public Boolean getCreateDeptGroup() {
            return this.createDeptGroup;
        }

        public ListCollegeContactSubDeptsResponseBodyResult setDeptCode(String deptCode) {
            this.deptCode = deptCode;
            return this;
        }
        public String getDeptCode() {
            return this.deptCode;
        }

        public ListCollegeContactSubDeptsResponseBodyResult setDeptId(Long deptId) {
            this.deptId = deptId;
            return this;
        }
        public Long getDeptId() {
            return this.deptId;
        }

        public ListCollegeContactSubDeptsResponseBodyResult setDeptType(String deptType) {
            this.deptType = deptType;
            return this;
        }
        public String getDeptType() {
            return this.deptType;
        }

        public ListCollegeContactSubDeptsResponseBodyResult setExtension(String extension) {
            this.extension = extension;
            return this;
        }
        public String getExtension() {
            return this.extension;
        }

        public ListCollegeContactSubDeptsResponseBodyResult setFromUnionOrg(Boolean fromUnionOrg) {
            this.fromUnionOrg = fromUnionOrg;
            return this;
        }
        public Boolean getFromUnionOrg() {
            return this.fromUnionOrg;
        }

        public ListCollegeContactSubDeptsResponseBodyResult setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public ListCollegeContactSubDeptsResponseBodyResult setParentId(Long parentId) {
            this.parentId = parentId;
            return this;
        }
        public Long getParentId() {
            return this.parentId;
        }

        public ListCollegeContactSubDeptsResponseBodyResult setSourceIdentifier(String sourceIdentifier) {
            this.sourceIdentifier = sourceIdentifier;
            return this;
        }
        public String getSourceIdentifier() {
            return this.sourceIdentifier;
        }

        public ListCollegeContactSubDeptsResponseBodyResult setStruId(Long struId) {
            this.struId = struId;
            return this;
        }
        public Long getStruId() {
            return this.struId;
        }

        public ListCollegeContactSubDeptsResponseBodyResult setTags(String tags) {
            this.tags = tags;
            return this;
        }
        public String getTags() {
            return this.tags;
        }

    }

}
