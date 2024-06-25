// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class QueryGroupInfoResponseBody extends TeaModel {
    @NameInMap("content")
    public QueryGroupInfoResponseBodyContent content;

    public static QueryGroupInfoResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryGroupInfoResponseBody self = new QueryGroupInfoResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryGroupInfoResponseBody setContent(QueryGroupInfoResponseBodyContent content) {
        this.content = content;
        return this;
    }
    public QueryGroupInfoResponseBodyContent getContent() {
        return this.content;
    }

    public static class QueryGroupInfoResponseBodyContentExtendInfos extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>28765</p>
         */
        @NameInMap("deptCode")
        public String deptCode;

        /**
         * <strong>example:</strong>
         * <p>科室、医生都不一样</p>
         */
        @NameInMap("deptExtendDisplayName")
        public String deptExtendDisplayName;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>科室、医生都不一样</p>
         */
        @NameInMap("deptExtendKey")
        public String deptExtendKey;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>科室、医生都不一样</p>
         */
        @NameInMap("deptExtendValue")
        public String deptExtendValue;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>2021-08-24 20:30:31</p>
         */
        @NameInMap("gmtCreateStr")
        public String gmtCreateStr;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>2021-08-24 20:30:31</p>
         */
        @NameInMap("gmtModifiedStr")
        public String gmtModifiedStr;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>10000</p>
         */
        @NameInMap("id")
        public Long id;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>0</p>
         */
        @NameInMap("status")
        public Integer status;

        public static QueryGroupInfoResponseBodyContentExtendInfos build(java.util.Map<String, ?> map) throws Exception {
            QueryGroupInfoResponseBodyContentExtendInfos self = new QueryGroupInfoResponseBodyContentExtendInfos();
            return TeaModel.build(map, self);
        }

        public QueryGroupInfoResponseBodyContentExtendInfos setDeptCode(String deptCode) {
            this.deptCode = deptCode;
            return this;
        }
        public String getDeptCode() {
            return this.deptCode;
        }

        public QueryGroupInfoResponseBodyContentExtendInfos setDeptExtendDisplayName(String deptExtendDisplayName) {
            this.deptExtendDisplayName = deptExtendDisplayName;
            return this;
        }
        public String getDeptExtendDisplayName() {
            return this.deptExtendDisplayName;
        }

        public QueryGroupInfoResponseBodyContentExtendInfos setDeptExtendKey(String deptExtendKey) {
            this.deptExtendKey = deptExtendKey;
            return this;
        }
        public String getDeptExtendKey() {
            return this.deptExtendKey;
        }

        public QueryGroupInfoResponseBodyContentExtendInfos setDeptExtendValue(String deptExtendValue) {
            this.deptExtendValue = deptExtendValue;
            return this;
        }
        public String getDeptExtendValue() {
            return this.deptExtendValue;
        }

        public QueryGroupInfoResponseBodyContentExtendInfos setGmtCreateStr(String gmtCreateStr) {
            this.gmtCreateStr = gmtCreateStr;
            return this;
        }
        public String getGmtCreateStr() {
            return this.gmtCreateStr;
        }

        public QueryGroupInfoResponseBodyContentExtendInfos setGmtModifiedStr(String gmtModifiedStr) {
            this.gmtModifiedStr = gmtModifiedStr;
            return this;
        }
        public String getGmtModifiedStr() {
            return this.gmtModifiedStr;
        }

        public QueryGroupInfoResponseBodyContentExtendInfos setId(Long id) {
            this.id = id;
            return this;
        }
        public Long getId() {
            return this.id;
        }

        public QueryGroupInfoResponseBodyContentExtendInfos setStatus(Integer status) {
            this.status = status;
            return this;
        }
        public Integer getStatus() {
            return this.status;
        }

    }

    public static class QueryGroupInfoResponseBodyContentGroupLeader extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>3212</p>
         */
        @NameInMap("jobNumber")
        public String jobNumber;

        /**
         * <strong>example:</strong>
         * <p>张三</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <strong>example:</strong>
         * <p>1234</p>
         */
        @NameInMap("userId")
        public String userId;

        public static QueryGroupInfoResponseBodyContentGroupLeader build(java.util.Map<String, ?> map) throws Exception {
            QueryGroupInfoResponseBodyContentGroupLeader self = new QueryGroupInfoResponseBodyContentGroupLeader();
            return TeaModel.build(map, self);
        }

        public QueryGroupInfoResponseBodyContentGroupLeader setJobNumber(String jobNumber) {
            this.jobNumber = jobNumber;
            return this;
        }
        public String getJobNumber() {
            return this.jobNumber;
        }

        public QueryGroupInfoResponseBodyContentGroupLeader setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public QueryGroupInfoResponseBodyContentGroupLeader setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

    public static class QueryGroupInfoResponseBodyContentGroup extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>321222</p>
         */
        @NameInMap("deptId")
        public Long deptId;

        /**
         * <strong>example:</strong>
         * <p>1</p>
         */
        @NameInMap("deptStatus")
        public Integer deptStatus;

        /**
         * <strong>example:</strong>
         * <p>2021-08-24 20:30:31</p>
         */
        @NameInMap("gmtCreateStr")
        public String gmtCreateStr;

        /**
         * <strong>example:</strong>
         * <p>2021-08-24 20:30:31</p>
         */
        @NameInMap("gmtModifiedStr")
        public String gmtModifiedStr;

        /**
         * <strong>example:</strong>
         * <p>3212</p>
         */
        @NameInMap("id")
        public Long id;

        @NameInMap("leader")
        public QueryGroupInfoResponseBodyContentGroupLeader leader;

        /**
         * <strong>example:</strong>
         * <p>张三组</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <strong>example:</strong>
         * <p>1</p>
         */
        @NameInMap("parentDeptCode")
        public String parentDeptCode;

        /**
         * <strong>example:</strong>
         * <p>备注</p>
         */
        @NameInMap("remark")
        public String remark;

        public static QueryGroupInfoResponseBodyContentGroup build(java.util.Map<String, ?> map) throws Exception {
            QueryGroupInfoResponseBodyContentGroup self = new QueryGroupInfoResponseBodyContentGroup();
            return TeaModel.build(map, self);
        }

        public QueryGroupInfoResponseBodyContentGroup setDeptId(Long deptId) {
            this.deptId = deptId;
            return this;
        }
        public Long getDeptId() {
            return this.deptId;
        }

        public QueryGroupInfoResponseBodyContentGroup setDeptStatus(Integer deptStatus) {
            this.deptStatus = deptStatus;
            return this;
        }
        public Integer getDeptStatus() {
            return this.deptStatus;
        }

        public QueryGroupInfoResponseBodyContentGroup setGmtCreateStr(String gmtCreateStr) {
            this.gmtCreateStr = gmtCreateStr;
            return this;
        }
        public String getGmtCreateStr() {
            return this.gmtCreateStr;
        }

        public QueryGroupInfoResponseBodyContentGroup setGmtModifiedStr(String gmtModifiedStr) {
            this.gmtModifiedStr = gmtModifiedStr;
            return this;
        }
        public String getGmtModifiedStr() {
            return this.gmtModifiedStr;
        }

        public QueryGroupInfoResponseBodyContentGroup setId(Long id) {
            this.id = id;
            return this;
        }
        public Long getId() {
            return this.id;
        }

        public QueryGroupInfoResponseBodyContentGroup setLeader(QueryGroupInfoResponseBodyContentGroupLeader leader) {
            this.leader = leader;
            return this;
        }
        public QueryGroupInfoResponseBodyContentGroupLeader getLeader() {
            return this.leader;
        }

        public QueryGroupInfoResponseBodyContentGroup setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public QueryGroupInfoResponseBodyContentGroup setParentDeptCode(String parentDeptCode) {
            this.parentDeptCode = parentDeptCode;
            return this;
        }
        public String getParentDeptCode() {
            return this.parentDeptCode;
        }

        public QueryGroupInfoResponseBodyContentGroup setRemark(String remark) {
            this.remark = remark;
            return this;
        }
        public String getRemark() {
            return this.remark;
        }

    }

    public static class QueryGroupInfoResponseBodyContent extends TeaModel {
        @NameInMap("extendInfos")
        public java.util.List<QueryGroupInfoResponseBodyContentExtendInfos> extendInfos;

        @NameInMap("group")
        public QueryGroupInfoResponseBodyContentGroup group;

        public static QueryGroupInfoResponseBodyContent build(java.util.Map<String, ?> map) throws Exception {
            QueryGroupInfoResponseBodyContent self = new QueryGroupInfoResponseBodyContent();
            return TeaModel.build(map, self);
        }

        public QueryGroupInfoResponseBodyContent setExtendInfos(java.util.List<QueryGroupInfoResponseBodyContentExtendInfos> extendInfos) {
            this.extendInfos = extendInfos;
            return this;
        }
        public java.util.List<QueryGroupInfoResponseBodyContentExtendInfos> getExtendInfos() {
            return this.extendInfos;
        }

        public QueryGroupInfoResponseBodyContent setGroup(QueryGroupInfoResponseBodyContentGroup group) {
            this.group = group;
            return this;
        }
        public QueryGroupInfoResponseBodyContentGroup getGroup() {
            return this.group;
        }

    }

}
