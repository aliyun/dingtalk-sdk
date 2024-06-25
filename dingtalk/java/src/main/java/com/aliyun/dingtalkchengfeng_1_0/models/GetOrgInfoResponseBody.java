// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkchengfeng_1_0.models;

import com.aliyun.tea.*;

public class GetOrgInfoResponseBody extends TeaModel {
    @NameInMap("content")
    public GetOrgInfoResponseBodyContent content;

    @NameInMap("requestId")
    public String requestId;

    public static GetOrgInfoResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetOrgInfoResponseBody self = new GetOrgInfoResponseBody();
        return TeaModel.build(map, self);
    }

    public GetOrgInfoResponseBody setContent(GetOrgInfoResponseBodyContent content) {
        this.content = content;
        return this;
    }
    public GetOrgInfoResponseBodyContent getContent() {
        return this.content;
    }

    public GetOrgInfoResponseBody setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public static class GetOrgInfoResponseBodyContent extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>123</p>
         */
        @NameInMap("deptCode")
        public String deptCode;

        /**
         * <strong>example:</strong>
         * <p>开发技术部</p>
         */
        @NameInMap("deptName")
        public String deptName;

        /**
         * <strong>example:</strong>
         * <p>10</p>
         */
        @NameInMap("deptNum")
        public String deptNum;

        /**
         * <strong>example:</strong>
         * <p>1</p>
         */
        @NameInMap("level")
        public String level;

        /**
         * <strong>example:</strong>
         * <p>/1/123</p>
         */
        @NameInMap("organizationCodePath")
        public String organizationCodePath;

        /**
         * <strong>example:</strong>
         * <p>/开发技术部</p>
         */
        @NameInMap("organizationPath")
        public String organizationPath;

        /**
         * <strong>example:</strong>
         * <p>1</p>
         */
        @NameInMap("parentDeptCode")
        public String parentDeptCode;

        /**
         * <strong>example:</strong>
         * <p>开发部</p>
         */
        @NameInMap("shortName")
        public String shortName;

        /**
         * <strong>example:</strong>
         * <p>1678886770065</p>
         */
        @NameInMap("startDate")
        public String startDate;

        /**
         * <strong>example:</strong>
         * <p>1678886770065</p>
         */
        @NameInMap("stopDate")
        public String stopDate;

        public static GetOrgInfoResponseBodyContent build(java.util.Map<String, ?> map) throws Exception {
            GetOrgInfoResponseBodyContent self = new GetOrgInfoResponseBodyContent();
            return TeaModel.build(map, self);
        }

        public GetOrgInfoResponseBodyContent setDeptCode(String deptCode) {
            this.deptCode = deptCode;
            return this;
        }
        public String getDeptCode() {
            return this.deptCode;
        }

        public GetOrgInfoResponseBodyContent setDeptName(String deptName) {
            this.deptName = deptName;
            return this;
        }
        public String getDeptName() {
            return this.deptName;
        }

        public GetOrgInfoResponseBodyContent setDeptNum(String deptNum) {
            this.deptNum = deptNum;
            return this;
        }
        public String getDeptNum() {
            return this.deptNum;
        }

        public GetOrgInfoResponseBodyContent setLevel(String level) {
            this.level = level;
            return this;
        }
        public String getLevel() {
            return this.level;
        }

        public GetOrgInfoResponseBodyContent setOrganizationCodePath(String organizationCodePath) {
            this.organizationCodePath = organizationCodePath;
            return this;
        }
        public String getOrganizationCodePath() {
            return this.organizationCodePath;
        }

        public GetOrgInfoResponseBodyContent setOrganizationPath(String organizationPath) {
            this.organizationPath = organizationPath;
            return this;
        }
        public String getOrganizationPath() {
            return this.organizationPath;
        }

        public GetOrgInfoResponseBodyContent setParentDeptCode(String parentDeptCode) {
            this.parentDeptCode = parentDeptCode;
            return this;
        }
        public String getParentDeptCode() {
            return this.parentDeptCode;
        }

        public GetOrgInfoResponseBodyContent setShortName(String shortName) {
            this.shortName = shortName;
            return this;
        }
        public String getShortName() {
            return this.shortName;
        }

        public GetOrgInfoResponseBodyContent setStartDate(String startDate) {
            this.startDate = startDate;
            return this;
        }
        public String getStartDate() {
            return this.startDate;
        }

        public GetOrgInfoResponseBodyContent setStopDate(String stopDate) {
            this.stopDate = stopDate;
            return this;
        }
        public String getStopDate() {
            return this.stopDate;
        }

    }

}
