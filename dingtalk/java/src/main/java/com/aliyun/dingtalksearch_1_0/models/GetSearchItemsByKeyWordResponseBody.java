// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalksearch_1_0.models;

import com.aliyun.tea.*;

public class GetSearchItemsByKeyWordResponseBody extends TeaModel {
    /**
     * <p>下一次请求的加密offset，若为空则代表item已经读取完毕</p>
     */
    @NameInMap("nextToken")
    public String nextToken;

    /**
     * <p>本次请求条件下的item总量</p>
     */
    @NameInMap("totalCount")
    public Integer totalCount;

    @NameInMap("value")
    public java.util.List<GetSearchItemsByKeyWordResponseBodyValue> value;

    public static GetSearchItemsByKeyWordResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetSearchItemsByKeyWordResponseBody self = new GetSearchItemsByKeyWordResponseBody();
        return TeaModel.build(map, self);
    }

    public GetSearchItemsByKeyWordResponseBody setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public GetSearchItemsByKeyWordResponseBody setTotalCount(Integer totalCount) {
        this.totalCount = totalCount;
        return this;
    }
    public Integer getTotalCount() {
        return this.totalCount;
    }

    public GetSearchItemsByKeyWordResponseBody setValue(java.util.List<GetSearchItemsByKeyWordResponseBodyValue> value) {
        this.value = value;
        return this;
    }
    public java.util.List<GetSearchItemsByKeyWordResponseBodyValue> getValue() {
        return this.value;
    }

    public static class GetSearchItemsByKeyWordResponseBodyValue extends TeaModel {
        /**
         * <p>数据项的脚注</p>
         */
        @NameInMap("footer")
        public String footer;

        /**
         * <p>创建时间</p>
         */
        @NameInMap("gmtCreate")
        public String gmtCreate;

        /**
         * <p>修改时间</p>
         */
        @NameInMap("gmtModified")
        public String gmtModified;

        /**
         * <p>数据项的头像</p>
         */
        @NameInMap("icon")
        public String icon;

        /**
         * <p>数据项的id,tabId和orgId相同的情况下，itemId唯一标识一条数据项</p>
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
         * <p>数据项的摘要</p>
         */
        @NameInMap("summary")
        public String summary;

        /**
         * <p>数据源id</p>
         */
        @NameInMap("tabId")
        public Integer tabId;

        /**
         * <p>数据项的标题</p>
         */
        @NameInMap("title")
        public String title;

        /**
         * <p>数据项的默认url地址，若mobileUrl或pcUrl没有配置，则使用该url地址，默认url和mobileUrl、pcUrl至少配置其中一个</p>
         */
        @NameInMap("url")
        public String url;

        public static GetSearchItemsByKeyWordResponseBodyValue build(java.util.Map<String, ?> map) throws Exception {
            GetSearchItemsByKeyWordResponseBodyValue self = new GetSearchItemsByKeyWordResponseBodyValue();
            return TeaModel.build(map, self);
        }

        public GetSearchItemsByKeyWordResponseBodyValue setFooter(String footer) {
            this.footer = footer;
            return this;
        }
        public String getFooter() {
            return this.footer;
        }

        public GetSearchItemsByKeyWordResponseBodyValue setGmtCreate(String gmtCreate) {
            this.gmtCreate = gmtCreate;
            return this;
        }
        public String getGmtCreate() {
            return this.gmtCreate;
        }

        public GetSearchItemsByKeyWordResponseBodyValue setGmtModified(String gmtModified) {
            this.gmtModified = gmtModified;
            return this;
        }
        public String getGmtModified() {
            return this.gmtModified;
        }

        public GetSearchItemsByKeyWordResponseBodyValue setIcon(String icon) {
            this.icon = icon;
            return this;
        }
        public String getIcon() {
            return this.icon;
        }

        public GetSearchItemsByKeyWordResponseBodyValue setItemId(String itemId) {
            this.itemId = itemId;
            return this;
        }
        public String getItemId() {
            return this.itemId;
        }

        public GetSearchItemsByKeyWordResponseBodyValue setMobileUrl(String mobileUrl) {
            this.mobileUrl = mobileUrl;
            return this;
        }
        public String getMobileUrl() {
            return this.mobileUrl;
        }

        public GetSearchItemsByKeyWordResponseBodyValue setPcUrl(String pcUrl) {
            this.pcUrl = pcUrl;
            return this;
        }
        public String getPcUrl() {
            return this.pcUrl;
        }

        public GetSearchItemsByKeyWordResponseBodyValue setSummary(String summary) {
            this.summary = summary;
            return this;
        }
        public String getSummary() {
            return this.summary;
        }

        public GetSearchItemsByKeyWordResponseBodyValue setTabId(Integer tabId) {
            this.tabId = tabId;
            return this;
        }
        public Integer getTabId() {
            return this.tabId;
        }

        public GetSearchItemsByKeyWordResponseBodyValue setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

        public GetSearchItemsByKeyWordResponseBodyValue setUrl(String url) {
            this.url = url;
            return this;
        }
        public String getUrl() {
            return this.url;
        }

    }

}
