// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class GetExclusiveAccountAllOrgListResponseBody extends TeaModel {
    // 组织信息列表
    @NameInMap("orgInfoList")
    public java.util.List<GetExclusiveAccountAllOrgListResponseBodyOrgInfoList> orgInfoList;

    public static GetExclusiveAccountAllOrgListResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetExclusiveAccountAllOrgListResponseBody self = new GetExclusiveAccountAllOrgListResponseBody();
        return TeaModel.build(map, self);
    }

    public GetExclusiveAccountAllOrgListResponseBody setOrgInfoList(java.util.List<GetExclusiveAccountAllOrgListResponseBodyOrgInfoList> orgInfoList) {
        this.orgInfoList = orgInfoList;
        return this;
    }
    public java.util.List<GetExclusiveAccountAllOrgListResponseBodyOrgInfoList> getOrgInfoList() {
        return this.orgInfoList;
    }

    public static class GetExclusiveAccountAllOrgListResponseBodyOrgInfoList extends TeaModel {
        // 组织ID
        @NameInMap("corpId")
        public String corpId;

        // 是否是主组织
        @NameInMap("isMainOrg")
        public Boolean isMainOrg;

        // 组织图标地址
        @NameInMap("logoUrl")
        public String logoUrl;

        // 组织全称
        @NameInMap("orgFullName")
        public String orgFullName;

        // 组织名称
        @NameInMap("orgName")
        public String orgName;

        public static GetExclusiveAccountAllOrgListResponseBodyOrgInfoList build(java.util.Map<String, ?> map) throws Exception {
            GetExclusiveAccountAllOrgListResponseBodyOrgInfoList self = new GetExclusiveAccountAllOrgListResponseBodyOrgInfoList();
            return TeaModel.build(map, self);
        }

        public GetExclusiveAccountAllOrgListResponseBodyOrgInfoList setCorpId(String corpId) {
            this.corpId = corpId;
            return this;
        }
        public String getCorpId() {
            return this.corpId;
        }

        public GetExclusiveAccountAllOrgListResponseBodyOrgInfoList setIsMainOrg(Boolean isMainOrg) {
            this.isMainOrg = isMainOrg;
            return this;
        }
        public Boolean getIsMainOrg() {
            return this.isMainOrg;
        }

        public GetExclusiveAccountAllOrgListResponseBodyOrgInfoList setLogoUrl(String logoUrl) {
            this.logoUrl = logoUrl;
            return this;
        }
        public String getLogoUrl() {
            return this.logoUrl;
        }

        public GetExclusiveAccountAllOrgListResponseBodyOrgInfoList setOrgFullName(String orgFullName) {
            this.orgFullName = orgFullName;
            return this;
        }
        public String getOrgFullName() {
            return this.orgFullName;
        }

        public GetExclusiveAccountAllOrgListResponseBodyOrgInfoList setOrgName(String orgName) {
            this.orgName = orgName;
            return this;
        }
        public String getOrgName() {
            return this.orgName;
        }

    }

}
