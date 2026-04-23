// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkminutes_1_0.models;

import com.aliyun.tea.*;

public class SetInProgressCustomTabsRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("customTabList")
    public java.util.List<SetInProgressCustomTabsRequestCustomTabList> customTabList;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>lJcRnm39OsU4jlFVmRGXXXXX</p>
     */
    @NameInMap("unionId")
    public String unionId;

    public static SetInProgressCustomTabsRequest build(java.util.Map<String, ?> map) throws Exception {
        SetInProgressCustomTabsRequest self = new SetInProgressCustomTabsRequest();
        return TeaModel.build(map, self);
    }

    public SetInProgressCustomTabsRequest setCustomTabList(java.util.List<SetInProgressCustomTabsRequestCustomTabList> customTabList) {
        this.customTabList = customTabList;
        return this;
    }
    public java.util.List<SetInProgressCustomTabsRequestCustomTabList> getCustomTabList() {
        return this.customTabList;
    }

    public SetInProgressCustomTabsRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

    public static class SetInProgressCustomTabsRequestCustomTabList extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>data_analysis</p>
         */
        @NameInMap("bizType")
        public String bizType;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>zh_CN</p>
         */
        @NameInMap("defaultLocale")
        public String defaultLocale;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("nameI18nMap")
        public java.util.Map<String, ?> nameI18nMap;

        /**
         * <strong>example:</strong>
         * <p><a href="https://example.com/app/minutes/analysis_pc">https://example.com/app/minutes/analysis_pc</a></p>
         */
        @NameInMap("pcUrl")
        public String pcUrl;

        /**
         * <strong>example:</strong>
         * <p>tab_1</p>
         */
        @NameInMap("tabId")
        public String tabId;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p><a href="https://example.com/app/minutes/analysis_h5">https://example.com/app/minutes/analysis_h5</a></p>
         */
        @NameInMap("url")
        public String url;

        public static SetInProgressCustomTabsRequestCustomTabList build(java.util.Map<String, ?> map) throws Exception {
            SetInProgressCustomTabsRequestCustomTabList self = new SetInProgressCustomTabsRequestCustomTabList();
            return TeaModel.build(map, self);
        }

        public SetInProgressCustomTabsRequestCustomTabList setBizType(String bizType) {
            this.bizType = bizType;
            return this;
        }
        public String getBizType() {
            return this.bizType;
        }

        public SetInProgressCustomTabsRequestCustomTabList setDefaultLocale(String defaultLocale) {
            this.defaultLocale = defaultLocale;
            return this;
        }
        public String getDefaultLocale() {
            return this.defaultLocale;
        }

        public SetInProgressCustomTabsRequestCustomTabList setNameI18nMap(java.util.Map<String, ?> nameI18nMap) {
            this.nameI18nMap = nameI18nMap;
            return this;
        }
        public java.util.Map<String, ?> getNameI18nMap() {
            return this.nameI18nMap;
        }

        public SetInProgressCustomTabsRequestCustomTabList setPcUrl(String pcUrl) {
            this.pcUrl = pcUrl;
            return this;
        }
        public String getPcUrl() {
            return this.pcUrl;
        }

        public SetInProgressCustomTabsRequestCustomTabList setTabId(String tabId) {
            this.tabId = tabId;
            return this;
        }
        public String getTabId() {
            return this.tabId;
        }

        public SetInProgressCustomTabsRequestCustomTabList setUrl(String url) {
            this.url = url;
            return this;
        }
        public String getUrl() {
            return this.url;
        }

    }

}
