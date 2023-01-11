// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalksearch_1_0.models;

import com.aliyun.tea.*;

public class GetSearchItemResponseBody extends TeaModel {
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
