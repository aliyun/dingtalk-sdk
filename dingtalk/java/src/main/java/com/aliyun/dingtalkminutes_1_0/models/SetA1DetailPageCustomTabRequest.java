// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkminutes_1_0.models;

import com.aliyun.tea.*;

public class SetA1DetailPageCustomTabRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("customTabList")
    public java.util.List<SetA1DetailPageCustomTabRequestCustomTabList> customTabList;

    /**
     * <p>true时保留已有A1分析Tab并替换其它自定义Tab；false或不传时直接使用本次列表覆盖</p>
     */
    @NameInMap("preserveA1AnalyzeTab")
    public Boolean preserveA1AnalyzeTab;

    public static SetA1DetailPageCustomTabRequest build(java.util.Map<String, ?> map) throws Exception {
        SetA1DetailPageCustomTabRequest self = new SetA1DetailPageCustomTabRequest();
        return TeaModel.build(map, self);
    }

    public SetA1DetailPageCustomTabRequest setCustomTabList(java.util.List<SetA1DetailPageCustomTabRequestCustomTabList> customTabList) {
        this.customTabList = customTabList;
        return this;
    }
    public java.util.List<SetA1DetailPageCustomTabRequestCustomTabList> getCustomTabList() {
        return this.customTabList;
    }

    public SetA1DetailPageCustomTabRequest setPreserveA1AnalyzeTab(Boolean preserveA1AnalyzeTab) {
        this.preserveA1AnalyzeTab = preserveA1AnalyzeTab;
        return this;
    }
    public Boolean getPreserveA1AnalyzeTab() {
        return this.preserveA1AnalyzeTab;
    }

    public static class SetA1DetailPageCustomTabRequestCustomTabList extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>analyze</p>
         */
        @NameInMap("bizType")
        public String bizType;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>cn_ZH</p>
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
         * <p><a href="https://example.com/pc/tab">https://example.com/pc/tab</a></p>
         */
        @NameInMap("pcUrl")
        public String pcUrl;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p><a href="https://example.com/tab">https://example.com/tab</a></p>
         */
        @NameInMap("url")
        public String url;

        public static SetA1DetailPageCustomTabRequestCustomTabList build(java.util.Map<String, ?> map) throws Exception {
            SetA1DetailPageCustomTabRequestCustomTabList self = new SetA1DetailPageCustomTabRequestCustomTabList();
            return TeaModel.build(map, self);
        }

        public SetA1DetailPageCustomTabRequestCustomTabList setBizType(String bizType) {
            this.bizType = bizType;
            return this;
        }
        public String getBizType() {
            return this.bizType;
        }

        public SetA1DetailPageCustomTabRequestCustomTabList setDefaultLocale(String defaultLocale) {
            this.defaultLocale = defaultLocale;
            return this;
        }
        public String getDefaultLocale() {
            return this.defaultLocale;
        }

        public SetA1DetailPageCustomTabRequestCustomTabList setNameI18nMap(java.util.Map<String, ?> nameI18nMap) {
            this.nameI18nMap = nameI18nMap;
            return this;
        }
        public java.util.Map<String, ?> getNameI18nMap() {
            return this.nameI18nMap;
        }

        public SetA1DetailPageCustomTabRequestCustomTabList setPcUrl(String pcUrl) {
            this.pcUrl = pcUrl;
            return this;
        }
        public String getPcUrl() {
            return this.pcUrl;
        }

        public SetA1DetailPageCustomTabRequestCustomTabList setUrl(String url) {
            this.url = url;
            return this;
        }
        public String getUrl() {
            return this.url;
        }

    }

}
