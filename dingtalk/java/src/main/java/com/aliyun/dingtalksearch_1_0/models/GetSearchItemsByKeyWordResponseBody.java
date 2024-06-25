// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalksearch_1_0.models;

import com.aliyun.tea.*;

public class GetSearchItemsByKeyWordResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("nextToken")
    public String nextToken;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>20</p>
     */
    @NameInMap("totalCount")
    public Integer totalCount;

    /**
     * <p>This parameter is required.</p>
     */
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
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>四大名著</p>
         */
        @NameInMap("footer")
        public String footer;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>2021-09-17T19:43Z</p>
         */
        @NameInMap("gmtCreate")
        public String gmtCreate;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>2021-09-17T19:43Z</p>
         */
        @NameInMap("gmtModified")
        public String gmtModified;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("icon")
        public String icon;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>1111</p>
         */
        @NameInMap("itemId")
        public String itemId;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p><a href="http://www.baidu.com">www.baidu.com</a></p>
         */
        @NameInMap("mobileUrl")
        public String mobileUrl;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p><a href="http://www.baidu.com">www.baidu.com</a></p>
         */
        @NameInMap("pcUrl")
        public String pcUrl;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>中国古代章回体长篇小说</p>
         */
        @NameInMap("summary")
        public String summary;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>3333</p>
         */
        @NameInMap("tabId")
        public Integer tabId;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>红楼梦</p>
         */
        @NameInMap("title")
        public String title;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p><a href="http://www.baidu.com">www.baidu.com</a></p>
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
