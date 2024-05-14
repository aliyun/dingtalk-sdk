// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalksearch_1_0.models;

import com.aliyun.tea.*;

public class GetSearchItemResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("footer")
    public String footer;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("gmtCreate")
    public String gmtCreate;

    /**
     * <p>This parameter is required.</p>
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
     */
    @NameInMap("itemId")
    public String itemId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("mobileUrl")
    public String mobileUrl;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("pcUrl")
    public String pcUrl;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("summary")
    public String summary;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("tabId")
    public Integer tabId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("title")
    public String title;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("url")
    public String url;

    public static GetSearchItemResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetSearchItemResponseBody self = new GetSearchItemResponseBody();
        return TeaModel.build(map, self);
    }

    public GetSearchItemResponseBody setFooter(String footer) {
        this.footer = footer;
        return this;
    }
    public String getFooter() {
        return this.footer;
    }

    public GetSearchItemResponseBody setGmtCreate(String gmtCreate) {
        this.gmtCreate = gmtCreate;
        return this;
    }
    public String getGmtCreate() {
        return this.gmtCreate;
    }

    public GetSearchItemResponseBody setGmtModified(String gmtModified) {
        this.gmtModified = gmtModified;
        return this;
    }
    public String getGmtModified() {
        return this.gmtModified;
    }

    public GetSearchItemResponseBody setIcon(String icon) {
        this.icon = icon;
        return this;
    }
    public String getIcon() {
        return this.icon;
    }

    public GetSearchItemResponseBody setItemId(String itemId) {
        this.itemId = itemId;
        return this;
    }
    public String getItemId() {
        return this.itemId;
    }

    public GetSearchItemResponseBody setMobileUrl(String mobileUrl) {
        this.mobileUrl = mobileUrl;
        return this;
    }
    public String getMobileUrl() {
        return this.mobileUrl;
    }

    public GetSearchItemResponseBody setPcUrl(String pcUrl) {
        this.pcUrl = pcUrl;
        return this;
    }
    public String getPcUrl() {
        return this.pcUrl;
    }

    public GetSearchItemResponseBody setSummary(String summary) {
        this.summary = summary;
        return this;
    }
    public String getSummary() {
        return this.summary;
    }

    public GetSearchItemResponseBody setTabId(Integer tabId) {
        this.tabId = tabId;
        return this;
    }
    public Integer getTabId() {
        return this.tabId;
    }

    public GetSearchItemResponseBody setTitle(String title) {
        this.title = title;
        return this;
    }
    public String getTitle() {
        return this.title;
    }

    public GetSearchItemResponseBody setUrl(String url) {
        this.url = url;
        return this;
    }
    public String getUrl() {
        return this.url;
    }

}
