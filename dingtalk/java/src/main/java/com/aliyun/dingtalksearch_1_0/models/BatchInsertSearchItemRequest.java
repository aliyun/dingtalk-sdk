// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalksearch_1_0.models;

import com.aliyun.tea.*;

public class BatchInsertSearchItemRequest extends TeaModel {
    @NameInMap("searchItemModels")
    public java.util.List<BatchInsertSearchItemRequestSearchItemModels> searchItemModels;

    public static BatchInsertSearchItemRequest build(java.util.Map<String, ?> map) throws Exception {
        BatchInsertSearchItemRequest self = new BatchInsertSearchItemRequest();
        return TeaModel.build(map, self);
    }

    public BatchInsertSearchItemRequest setSearchItemModels(java.util.List<BatchInsertSearchItemRequestSearchItemModels> searchItemModels) {
        this.searchItemModels = searchItemModels;
        return this;
    }
    public java.util.List<BatchInsertSearchItemRequestSearchItemModels> getSearchItemModels() {
        return this.searchItemModels;
    }

    public static class BatchInsertSearchItemRequestSearchItemModels extends TeaModel {
        /**
         * <p>数据项的脚注，长度不能超过64</p>
         */
        @NameInMap("footer")
        public String footer;

        /**
         * <p>数据项的头像，长度不能超过512</p>
         */
        @NameInMap("icon")
        public String icon;

        /**
         * <p>数据项的id，tabId和orgId相同的情况下，itemId唯一标识一条数据项，长度不能超过128</p>
         */
        @NameInMap("itemId")
        public String itemId;

        /**
         * <p>数据项的移动端跳转url地址，若同时配置默认url和mobileUrl，移动端跳转链接优先使用mobileUrl</p>
         */
        @NameInMap("mobileUrl")
        public String mobileUrl;

        /**
         * <p>数据项的PC端跳转url地址，若同时配置默认url和pcUrl，PC端跳转链接优先使用pcUrl</p>
         */
        @NameInMap("pcUrl")
        public String pcUrl;

        /**
         * <p>数据项的摘要，长度不能超过64</p>
         */
        @NameInMap("summary")
        public String summary;

        /**
         * <p>数据项的标题，长度不能超过16</p>
         */
        @NameInMap("title")
        public String title;

        /**
         * <p>数据项的默认url地址，若mobileUrl或pcUrl没有配置，则使用该url地址，默认url和mobileUrl、pcUrl至少配置其中一个</p>
         */
        @NameInMap("url")
        public String url;

        public static BatchInsertSearchItemRequestSearchItemModels build(java.util.Map<String, ?> map) throws Exception {
            BatchInsertSearchItemRequestSearchItemModels self = new BatchInsertSearchItemRequestSearchItemModels();
            return TeaModel.build(map, self);
        }

        public BatchInsertSearchItemRequestSearchItemModels setFooter(String footer) {
            this.footer = footer;
            return this;
        }
        public String getFooter() {
            return this.footer;
        }

        public BatchInsertSearchItemRequestSearchItemModels setIcon(String icon) {
            this.icon = icon;
            return this;
        }
        public String getIcon() {
            return this.icon;
        }

        public BatchInsertSearchItemRequestSearchItemModels setItemId(String itemId) {
            this.itemId = itemId;
            return this;
        }
        public String getItemId() {
            return this.itemId;
        }

        public BatchInsertSearchItemRequestSearchItemModels setMobileUrl(String mobileUrl) {
            this.mobileUrl = mobileUrl;
            return this;
        }
        public String getMobileUrl() {
            return this.mobileUrl;
        }

        public BatchInsertSearchItemRequestSearchItemModels setPcUrl(String pcUrl) {
            this.pcUrl = pcUrl;
            return this;
        }
        public String getPcUrl() {
            return this.pcUrl;
        }

        public BatchInsertSearchItemRequestSearchItemModels setSummary(String summary) {
            this.summary = summary;
            return this;
        }
        public String getSummary() {
            return this.summary;
        }

        public BatchInsertSearchItemRequestSearchItemModels setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

        public BatchInsertSearchItemRequestSearchItemModels setUrl(String url) {
            this.url = url;
            return this;
        }
        public String getUrl() {
            return this.url;
        }

    }

}
