// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkamdp_1_0.models;

import com.aliyun.tea.*;

public class AmdpOrganizationDataPushRequest extends TeaModel {
    @NameInMap("param")
    public java.util.List<AmdpOrganizationDataPushRequestParam> param;

    public static AmdpOrganizationDataPushRequest build(java.util.Map<String, ?> map) throws Exception {
        AmdpOrganizationDataPushRequest self = new AmdpOrganizationDataPushRequest();
        return TeaModel.build(map, self);
    }

    public AmdpOrganizationDataPushRequest setParam(java.util.List<AmdpOrganizationDataPushRequestParam> param) {
        this.param = param;
        return this;
    }
    public java.util.List<AmdpOrganizationDataPushRequestParam> getParam() {
        return this.param;
    }

    public static class AmdpOrganizationDataPushRequestParam extends TeaModel {
        @NameInMap("deptId")
        public String deptId;

        @NameInMap("deptManagerIdList")
        public java.util.List<String> deptManagerIdList;

        @NameInMap("dingTalkDeptId")
        public String dingTalkDeptId;

        @NameInMap("dingTalkParentId")
        public String dingTalkParentId;

        @NameInMap("isDelete")
        public String isDelete;

        @NameInMap("name")
        public String name;

        @NameInMap("parentId")
        public String parentId;

        public static AmdpOrganizationDataPushRequestParam build(java.util.Map<String, ?> map) throws Exception {
            AmdpOrganizationDataPushRequestParam self = new AmdpOrganizationDataPushRequestParam();
            return TeaModel.build(map, self);
        }

        public AmdpOrganizationDataPushRequestParam setDeptId(String deptId) {
            this.deptId = deptId;
            return this;
        }
        public String getDeptId() {
            return this.deptId;
        }

        public AmdpOrganizationDataPushRequestParam setDeptManagerIdList(java.util.List<String> deptManagerIdList) {
            this.deptManagerIdList = deptManagerIdList;
            return this;
        }
        public java.util.List<String> getDeptManagerIdList() {
            return this.deptManagerIdList;
        }

        public AmdpOrganizationDataPushRequestParam setDingTalkDeptId(String dingTalkDeptId) {
            this.dingTalkDeptId = dingTalkDeptId;
            return this;
        }
        public String getDingTalkDeptId() {
            return this.dingTalkDeptId;
        }

        public AmdpOrganizationDataPushRequestParam setDingTalkParentId(String dingTalkParentId) {
            this.dingTalkParentId = dingTalkParentId;
            return this;
        }
        public String getDingTalkParentId() {
            return this.dingTalkParentId;
        }

        public AmdpOrganizationDataPushRequestParam setIsDelete(String isDelete) {
            this.isDelete = isDelete;
            return this;
        }
        public String getIsDelete() {
            return this.isDelete;
        }

        public AmdpOrganizationDataPushRequestParam setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public AmdpOrganizationDataPushRequestParam setParentId(String parentId) {
            this.parentId = parentId;
            return this;
        }
        public String getParentId() {
            return this.parentId;
        }

    }

}
