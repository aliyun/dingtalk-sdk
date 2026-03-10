// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkminutes_1_0.models;

import com.aliyun.tea.*;

public class SetDetailPageCustomTabRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("customTabList")
    public java.util.List<SetDetailPageCustomTabRequestCustomTabList> customTabList;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>lJcRnm39OsU4jlFVmRGXXXXX</p>
     */
    @NameInMap("unionId")
    public String unionId;

    public static SetDetailPageCustomTabRequest build(java.util.Map<String, ?> map) throws Exception {
        SetDetailPageCustomTabRequest self = new SetDetailPageCustomTabRequest();
        return TeaModel.build(map, self);
    }

    public SetDetailPageCustomTabRequest setCustomTabList(java.util.List<SetDetailPageCustomTabRequestCustomTabList> customTabList) {
        this.customTabList = customTabList;
        return this;
    }
    public java.util.List<SetDetailPageCustomTabRequestCustomTabList> getCustomTabList() {
        return this.customTabList;
    }

    public SetDetailPageCustomTabRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

    public static class SetDetailPageCustomTabRequestCustomTabList extends TeaModel {
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

        public static SetDetailPageCustomTabRequestCustomTabList build(java.util.Map<String, ?> map) throws Exception {
            SetDetailPageCustomTabRequestCustomTabList self = new SetDetailPageCustomTabRequestCustomTabList();
            return TeaModel.build(map, self);
        }

        public SetDetailPageCustomTabRequestCustomTabList setBizType(String bizType) {
            this.bizType = bizType;
            return this;
        }
        public String getBizType() {
            return this.bizType;
        }

        public SetDetailPageCustomTabRequestCustomTabList setDefaultLocale(String defaultLocale) {
            this.defaultLocale = defaultLocale;
            return this;
        }
        public String getDefaultLocale() {
            return this.defaultLocale;
        }

        public SetDetailPageCustomTabRequestCustomTabList setNameI18nMap(java.util.Map<String, ?> nameI18nMap) {
            this.nameI18nMap = nameI18nMap;
            return this;
        }
        public java.util.Map<String, ?> getNameI18nMap() {
            return this.nameI18nMap;
        }

        public SetDetailPageCustomTabRequestCustomTabList setPcUrl(String pcUrl) {
            this.pcUrl = pcUrl;
            return this;
        }
        public String getPcUrl() {
            return this.pcUrl;
        }

        public SetDetailPageCustomTabRequestCustomTabList setUrl(String url) {
            this.url = url;
            return this;
        }
        public String getUrl() {
            return this.url;
        }

    }

}
