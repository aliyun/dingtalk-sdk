// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class UpdateMenuDataRequest extends TeaModel {
    @NameInMap("attr")
    public java.util.Map<String, ?> attr;

    @NameInMap("bizTraceId")
    public String bizTraceId;

    @NameInMap("module")
    public String module;

    @NameInMap("navData")
    public UpdateMenuDataRequestNavData navData;

    @NameInMap("operateType")
    public String operateType;

    @NameInMap("operatorUserId")
    public String operatorUserId;

    public static UpdateMenuDataRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateMenuDataRequest self = new UpdateMenuDataRequest();
        return TeaModel.build(map, self);
    }

    public UpdateMenuDataRequest setAttr(java.util.Map<String, ?> attr) {
        this.attr = attr;
        return this;
    }
    public java.util.Map<String, ?> getAttr() {
        return this.attr;
    }

    public UpdateMenuDataRequest setBizTraceId(String bizTraceId) {
        this.bizTraceId = bizTraceId;
        return this;
    }
    public String getBizTraceId() {
        return this.bizTraceId;
    }

    public UpdateMenuDataRequest setModule(String module) {
        this.module = module;
        return this;
    }
    public String getModule() {
        return this.module;
    }

    public UpdateMenuDataRequest setNavData(UpdateMenuDataRequestNavData navData) {
        this.navData = navData;
        return this;
    }
    public UpdateMenuDataRequestNavData getNavData() {
        return this.navData;
    }

    public UpdateMenuDataRequest setOperateType(String operateType) {
        this.operateType = operateType;
        return this;
    }
    public String getOperateType() {
        return this.operateType;
    }

    public UpdateMenuDataRequest setOperatorUserId(String operatorUserId) {
        this.operatorUserId = operatorUserId;
        return this;
    }
    public String getOperatorUserId() {
        return this.operatorUserId;
    }

    public static class UpdateMenuDataRequestNavDataNavExtInfo extends TeaModel {
        @NameInMap("productMode")
        public String productMode;

        @NameInMap("provider")
        public String provider;

        public static UpdateMenuDataRequestNavDataNavExtInfo build(java.util.Map<String, ?> map) throws Exception {
            UpdateMenuDataRequestNavDataNavExtInfo self = new UpdateMenuDataRequestNavDataNavExtInfo();
            return TeaModel.build(map, self);
        }

        public UpdateMenuDataRequestNavDataNavExtInfo setProductMode(String productMode) {
            this.productMode = productMode;
            return this;
        }
        public String getProductMode() {
            return this.productMode;
        }

        public UpdateMenuDataRequestNavDataNavExtInfo setProvider(String provider) {
            this.provider = provider;
            return this;
        }
        public String getProvider() {
            return this.provider;
        }

    }

    public static class UpdateMenuDataRequestNavData extends TeaModel {
        @NameInMap("displayStatus")
        public String displayStatus;

        @NameInMap("icon")
        public String icon;

        @NameInMap("iconBgColor")
        public String iconBgColor;

        @NameInMap("iconColor")
        public String iconColor;

        @NameInMap("integrationProtocol")
        public String integrationProtocol;

        @NameInMap("mobileNavName")
        public String mobileNavName;

        @NameInMap("mobileUrl")
        public String mobileUrl;

        @NameInMap("navCode")
        public String navCode;

        @NameInMap("navExtInfo")
        public UpdateMenuDataRequestNavDataNavExtInfo navExtInfo;

        @NameInMap("navId")
        public String navId;

        @NameInMap("navName")
        public String navName;

        @NameInMap("navStatus")
        public String navStatus;

        @NameInMap("navType")
        public String navType;

        @NameInMap("parentNavId")
        public String parentNavId;

        @NameInMap("provider")
        public String provider;

        @NameInMap("sortNum")
        public Integer sortNum;

        @NameInMap("url")
        public String url;

        public static UpdateMenuDataRequestNavData build(java.util.Map<String, ?> map) throws Exception {
            UpdateMenuDataRequestNavData self = new UpdateMenuDataRequestNavData();
            return TeaModel.build(map, self);
        }

        public UpdateMenuDataRequestNavData setDisplayStatus(String displayStatus) {
            this.displayStatus = displayStatus;
            return this;
        }
        public String getDisplayStatus() {
            return this.displayStatus;
        }

        public UpdateMenuDataRequestNavData setIcon(String icon) {
            this.icon = icon;
            return this;
        }
        public String getIcon() {
            return this.icon;
        }

        public UpdateMenuDataRequestNavData setIconBgColor(String iconBgColor) {
            this.iconBgColor = iconBgColor;
            return this;
        }
        public String getIconBgColor() {
            return this.iconBgColor;
        }

        public UpdateMenuDataRequestNavData setIconColor(String iconColor) {
            this.iconColor = iconColor;
            return this;
        }
        public String getIconColor() {
            return this.iconColor;
        }

        public UpdateMenuDataRequestNavData setIntegrationProtocol(String integrationProtocol) {
            this.integrationProtocol = integrationProtocol;
            return this;
        }
        public String getIntegrationProtocol() {
            return this.integrationProtocol;
        }

        public UpdateMenuDataRequestNavData setMobileNavName(String mobileNavName) {
            this.mobileNavName = mobileNavName;
            return this;
        }
        public String getMobileNavName() {
            return this.mobileNavName;
        }

        public UpdateMenuDataRequestNavData setMobileUrl(String mobileUrl) {
            this.mobileUrl = mobileUrl;
            return this;
        }
        public String getMobileUrl() {
            return this.mobileUrl;
        }

        public UpdateMenuDataRequestNavData setNavCode(String navCode) {
            this.navCode = navCode;
            return this;
        }
        public String getNavCode() {
            return this.navCode;
        }

        public UpdateMenuDataRequestNavData setNavExtInfo(UpdateMenuDataRequestNavDataNavExtInfo navExtInfo) {
            this.navExtInfo = navExtInfo;
            return this;
        }
        public UpdateMenuDataRequestNavDataNavExtInfo getNavExtInfo() {
            return this.navExtInfo;
        }

        public UpdateMenuDataRequestNavData setNavId(String navId) {
            this.navId = navId;
            return this;
        }
        public String getNavId() {
            return this.navId;
        }

        public UpdateMenuDataRequestNavData setNavName(String navName) {
            this.navName = navName;
            return this;
        }
        public String getNavName() {
            return this.navName;
        }

        public UpdateMenuDataRequestNavData setNavStatus(String navStatus) {
            this.navStatus = navStatus;
            return this;
        }
        public String getNavStatus() {
            return this.navStatus;
        }

        public UpdateMenuDataRequestNavData setNavType(String navType) {
            this.navType = navType;
            return this;
        }
        public String getNavType() {
            return this.navType;
        }

        public UpdateMenuDataRequestNavData setParentNavId(String parentNavId) {
            this.parentNavId = parentNavId;
            return this;
        }
        public String getParentNavId() {
            return this.parentNavId;
        }

        public UpdateMenuDataRequestNavData setProvider(String provider) {
            this.provider = provider;
            return this;
        }
        public String getProvider() {
            return this.provider;
        }

        public UpdateMenuDataRequestNavData setSortNum(Integer sortNum) {
            this.sortNum = sortNum;
            return this;
        }
        public Integer getSortNum() {
            return this.sortNum;
        }

        public UpdateMenuDataRequestNavData setUrl(String url) {
            this.url = url;
            return this;
        }
        public String getUrl() {
            return this.url;
        }

    }

}
