// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalksearch_1_0.models;

import com.aliyun.tea.*;

public class GetSearchItemsByKeyWordResponseBody extends TeaModel {
    @NameInMap("nextToken")
    public String nextToken;

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
        @NameInMap("footer")
        public String footer;

        @NameInMap("gmtCreate")
        public String gmtCreate;

        @NameInMap("gmtModified")
        public String gmtModified;

        @NameInMap("icon")
        public String icon;

        @NameInMap("itemId")
        public String itemId;

        @NameInMap("mobileUrl")
        public String mobileUrl;

        @NameInMap("pcUrl")
        public String pcUrl;

        @NameInMap("summary")
        public String summary;

        @NameInMap("tabId")
        public Integer tabId;

        @NameInMap("title")
        public String title;

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
