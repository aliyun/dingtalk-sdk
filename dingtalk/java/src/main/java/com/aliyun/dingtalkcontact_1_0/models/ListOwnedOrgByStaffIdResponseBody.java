// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class ListOwnedOrgByStaffIdResponseBody extends TeaModel {
    @NameInMap("orgList")
    public java.util.List<ListOwnedOrgByStaffIdResponseBodyOrgList> orgList;

    public static ListOwnedOrgByStaffIdResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ListOwnedOrgByStaffIdResponseBody self = new ListOwnedOrgByStaffIdResponseBody();
        return TeaModel.build(map, self);
    }

    public ListOwnedOrgByStaffIdResponseBody setOrgList(java.util.List<ListOwnedOrgByStaffIdResponseBodyOrgList> orgList) {
        this.orgList = orgList;
        return this;
    }
    public java.util.List<ListOwnedOrgByStaffIdResponseBodyOrgList> getOrgList() {
        return this.orgList;
    }

    public static class ListOwnedOrgByStaffIdResponseBodyOrgList extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("corpId")
        public String corpId;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("corpName")
        public String corpName;

        public static ListOwnedOrgByStaffIdResponseBodyOrgList build(java.util.Map<String, ?> map) throws Exception {
            ListOwnedOrgByStaffIdResponseBodyOrgList self = new ListOwnedOrgByStaffIdResponseBodyOrgList();
            return TeaModel.build(map, self);
        }

        public ListOwnedOrgByStaffIdResponseBodyOrgList setCorpId(String corpId) {
            this.corpId = corpId;
            return this;
        }
        public String getCorpId() {
            return this.corpId;
        }

        public ListOwnedOrgByStaffIdResponseBodyOrgList setCorpName(String corpName) {
            this.corpName = corpName;
            return this;
        }
        public String getCorpName() {
            return this.corpName;
        }

    }

}
