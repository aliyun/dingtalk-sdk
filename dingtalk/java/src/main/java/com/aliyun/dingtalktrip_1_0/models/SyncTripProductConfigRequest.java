// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktrip_1_0.models;

import com.aliyun.tea.*;

public class SyncTripProductConfigRequest extends TeaModel {
    @NameInMap("targetCorpId")
    public String targetCorpId;

    @NameInMap("tripProductConfigList")
    public java.util.List<SyncTripProductConfigRequestTripProductConfigList> tripProductConfigList;

    public static SyncTripProductConfigRequest build(java.util.Map<String, ?> map) throws Exception {
        SyncTripProductConfigRequest self = new SyncTripProductConfigRequest();
        return TeaModel.build(map, self);
    }

    public SyncTripProductConfigRequest setTargetCorpId(String targetCorpId) {
        this.targetCorpId = targetCorpId;
        return this;
    }
    public String getTargetCorpId() {
        return this.targetCorpId;
    }

    public SyncTripProductConfigRequest setTripProductConfigList(java.util.List<SyncTripProductConfigRequestTripProductConfigList> tripProductConfigList) {
        this.tripProductConfigList = tripProductConfigList;
        return this;
    }
    public java.util.List<SyncTripProductConfigRequestTripProductConfigList> getTripProductConfigList() {
        return this.tripProductConfigList;
    }

    public static class SyncTripProductConfigRequestTripProductConfigListTmcInfos extends TeaModel {
        @NameInMap("categoryType")
        public String categoryType;

        @NameInMap("gmtOrgPay")
        public String gmtOrgPay;

        @NameInMap("payType")
        public String payType;

        @NameInMap("tmcCorpId")
        public String tmcCorpId;

        public static SyncTripProductConfigRequestTripProductConfigListTmcInfos build(java.util.Map<String, ?> map) throws Exception {
            SyncTripProductConfigRequestTripProductConfigListTmcInfos self = new SyncTripProductConfigRequestTripProductConfigListTmcInfos();
            return TeaModel.build(map, self);
        }

        public SyncTripProductConfigRequestTripProductConfigListTmcInfos setCategoryType(String categoryType) {
            this.categoryType = categoryType;
            return this;
        }
        public String getCategoryType() {
            return this.categoryType;
        }

        public SyncTripProductConfigRequestTripProductConfigListTmcInfos setGmtOrgPay(String gmtOrgPay) {
            this.gmtOrgPay = gmtOrgPay;
            return this;
        }
        public String getGmtOrgPay() {
            return this.gmtOrgPay;
        }

        public SyncTripProductConfigRequestTripProductConfigListTmcInfos setPayType(String payType) {
            this.payType = payType;
            return this;
        }
        public String getPayType() {
            return this.payType;
        }

        public SyncTripProductConfigRequestTripProductConfigListTmcInfos setTmcCorpId(String tmcCorpId) {
            this.tmcCorpId = tmcCorpId;
            return this;
        }
        public String getTmcCorpId() {
            return this.tmcCorpId;
        }

    }

    public static class SyncTripProductConfigRequestTripProductConfigList extends TeaModel {
        @NameInMap("allVisible")
        public Boolean allVisible;

        @NameInMap("deptVisibleScopes")
        public java.util.List<String> deptVisibleScopes;

        @NameInMap("openStatus")
        public Boolean openStatus;

        @NameInMap("productType")
        public String productType;

        @NameInMap("roleVisibleScopes")
        public java.util.List<String> roleVisibleScopes;

        @NameInMap("staffVisibleScopes")
        public java.util.List<String> staffVisibleScopes;

        @NameInMap("tmcInfos")
        public java.util.List<SyncTripProductConfigRequestTripProductConfigListTmcInfos> tmcInfos;

        public static SyncTripProductConfigRequestTripProductConfigList build(java.util.Map<String, ?> map) throws Exception {
            SyncTripProductConfigRequestTripProductConfigList self = new SyncTripProductConfigRequestTripProductConfigList();
            return TeaModel.build(map, self);
        }

        public SyncTripProductConfigRequestTripProductConfigList setAllVisible(Boolean allVisible) {
            this.allVisible = allVisible;
            return this;
        }
        public Boolean getAllVisible() {
            return this.allVisible;
        }

        public SyncTripProductConfigRequestTripProductConfigList setDeptVisibleScopes(java.util.List<String> deptVisibleScopes) {
            this.deptVisibleScopes = deptVisibleScopes;
            return this;
        }
        public java.util.List<String> getDeptVisibleScopes() {
            return this.deptVisibleScopes;
        }

        public SyncTripProductConfigRequestTripProductConfigList setOpenStatus(Boolean openStatus) {
            this.openStatus = openStatus;
            return this;
        }
        public Boolean getOpenStatus() {
            return this.openStatus;
        }

        public SyncTripProductConfigRequestTripProductConfigList setProductType(String productType) {
            this.productType = productType;
            return this;
        }
        public String getProductType() {
            return this.productType;
        }

        public SyncTripProductConfigRequestTripProductConfigList setRoleVisibleScopes(java.util.List<String> roleVisibleScopes) {
            this.roleVisibleScopes = roleVisibleScopes;
            return this;
        }
        public java.util.List<String> getRoleVisibleScopes() {
            return this.roleVisibleScopes;
        }

        public SyncTripProductConfigRequestTripProductConfigList setStaffVisibleScopes(java.util.List<String> staffVisibleScopes) {
            this.staffVisibleScopes = staffVisibleScopes;
            return this;
        }
        public java.util.List<String> getStaffVisibleScopes() {
            return this.staffVisibleScopes;
        }

        public SyncTripProductConfigRequestTripProductConfigList setTmcInfos(java.util.List<SyncTripProductConfigRequestTripProductConfigListTmcInfos> tmcInfos) {
            this.tmcInfos = tmcInfos;
            return this;
        }
        public java.util.List<SyncTripProductConfigRequestTripProductConfigListTmcInfos> getTmcInfos() {
            return this.tmcInfos;
        }

    }

}
