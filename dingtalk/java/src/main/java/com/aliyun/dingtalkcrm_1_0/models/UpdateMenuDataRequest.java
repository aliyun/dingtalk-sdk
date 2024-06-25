// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class UpdateMenuDataRequest extends TeaModel {
    @NameInMap("attr")
    public java.util.Map<String, ?> attr;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>89ez9DwVWQVgkhwndJNt1ZY</p>
     */
    @NameInMap("bizTraceId")
    public String bizTraceId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>sale</p>
     */
    @NameInMap("module")
    public String module;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("navData")
    public UpdateMenuDataRequestNavData navData;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>add</p>
     */
    @NameInMap("operateType")
    public String operateType;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>16044739461008808646</p>
     */
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
        /**
         * <strong>example:</strong>
         * <p>oem</p>
         */
        @NameInMap("productMode")
        public String productMode;

        /**
         * <strong>example:</strong>
         * <p>tj</p>
         */
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
        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>1</p>
         */
        @NameInMap("displayStatus")
        public String displayStatus;

        /**
         * <strong>example:</strong>
         * <p>icon-biaodan_baogao</p>
         */
        @NameInMap("icon")
        public String icon;

        /**
         * <strong>example:</strong>
         * <p>#CCEEFF</p>
         */
        @NameInMap("iconBgColor")
        public String iconBgColor;

        /**
         * <strong>example:</strong>
         * <p>#007FFF</p>
         */
        @NameInMap("iconColor")
        public String iconColor;

        /**
         * <strong>example:</strong>
         * <p>same_page</p>
         */
        @NameInMap("integrationProtocol")
        public String integrationProtocol;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>库存账单</p>
         */
        @NameInMap("mobileNavName")
        public String mobileNavName;

        /**
         * <strong>example:</strong>
         * <p><a href="https://tj-ali-crm-test.tangees.com/tungee/crm/mobile/?corpid=dinge18b222ec5637b04ffe93478753d9884#/form/PROC-ECC13160-7AFF-4D5B-8E73-E5B98BB9A59B?%E5%BA%93%E5%AD%98%E6%B5%81%E6%B0%B4&psi_stock_flow&fromPage=home">https://tj-ali-crm-test.tangees.com/tungee/crm/mobile/?corpid=dinge18b222ec5637b04ffe93478753d9884#/form/PROC-ECC13160-7AFF-4D5B-8E73-E5B98BB9A59B?库存流水&amp;psi_stock_flow&amp;fromPage=home</a></p>
         */
        @NameInMap("mobileUrl")
        public String mobileUrl;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>lowcode_customize_form</p>
         */
        @NameInMap("navCode")
        public String navCode;

        @NameInMap("navExtInfo")
        public UpdateMenuDataRequestNavDataNavExtInfo navExtInfo;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>lowcode_customize_form:PROC-0279E824-ED47-4E75-86F2-11B665F3704D</p>
         */
        @NameInMap("navId")
        public String navId;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>库存流水</p>
         */
        @NameInMap("navName")
        public String navName;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>PUBLISHED</p>
         */
        @NameInMap("navStatus")
        public String navStatus;

        /**
         * <strong>example:</strong>
         * <p>item</p>
         */
        @NameInMap("navType")
        public String navType;

        /**
         * <strong>example:</strong>
         * <p>crm_product</p>
         */
        @NameInMap("parentNavId")
        public String parentNavId;

        /**
         * <strong>example:</strong>
         * <p>tj</p>
         */
        @NameInMap("provider")
        public String provider;

        @NameInMap("sortNum")
        public Integer sortNum;

        /**
         * <strong>example:</strong>
         * <p>/form/PROC-ECC13160-7AFF-4D5B-8E73-E5B98BB9A59B?bizType=psi_stock_flow&amp;formName=库存流水</p>
         */
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
