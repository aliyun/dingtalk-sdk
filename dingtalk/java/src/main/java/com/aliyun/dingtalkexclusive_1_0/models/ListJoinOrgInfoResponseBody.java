// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class ListJoinOrgInfoResponseBody extends TeaModel {
    @NameInMap("orgInfoList")
    public java.util.List<ListJoinOrgInfoResponseBodyOrgInfoList> orgInfoList;

    public static ListJoinOrgInfoResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ListJoinOrgInfoResponseBody self = new ListJoinOrgInfoResponseBody();
        return TeaModel.build(map, self);
    }

    public ListJoinOrgInfoResponseBody setOrgInfoList(java.util.List<ListJoinOrgInfoResponseBodyOrgInfoList> orgInfoList) {
        this.orgInfoList = orgInfoList;
        return this;
    }
    public java.util.List<ListJoinOrgInfoResponseBodyOrgInfoList> getOrgInfoList() {
        return this.orgInfoList;
    }

    public static class ListJoinOrgInfoResponseBodyOrgInfoList extends TeaModel {
        @NameInMap("corpId")
        public String corpId;

        @NameInMap("domain")
        public String domain;

        @NameInMap("orgFullName")
        public String orgFullName;

        @NameInMap("orgName")
        public Long orgName;

        public static ListJoinOrgInfoResponseBodyOrgInfoList build(java.util.Map<String, ?> map) throws Exception {
            ListJoinOrgInfoResponseBodyOrgInfoList self = new ListJoinOrgInfoResponseBodyOrgInfoList();
            return TeaModel.build(map, self);
        }

        public ListJoinOrgInfoResponseBodyOrgInfoList setCorpId(String corpId) {
            this.corpId = corpId;
            return this;
        }
        public String getCorpId() {
            return this.corpId;
        }

        public ListJoinOrgInfoResponseBodyOrgInfoList setDomain(String domain) {
            this.domain = domain;
            return this;
        }
        public String getDomain() {
            return this.domain;
        }

        public ListJoinOrgInfoResponseBodyOrgInfoList setOrgFullName(String orgFullName) {
            this.orgFullName = orgFullName;
            return this;
        }
        public String getOrgFullName() {
            return this.orgFullName;
        }

        public ListJoinOrgInfoResponseBodyOrgInfoList setOrgName(Long orgName) {
            this.orgName = orgName;
            return this;
        }
        public Long getOrgName() {
            return this.orgName;
        }

    }

}
