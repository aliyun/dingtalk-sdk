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
        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>ding32xxxxxxxxe0105d</p>
         */
        @NameInMap("corpId")
        public String corpId;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>testCode</p>
         */
        @NameInMap("domain")
        public String domain;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>钉钉(中国)信息技术有限公司</p>
         */
        @NameInMap("orgFullName")
        public String orgFullName;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>钉钉</p>
         */
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
