// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalksearch_1_0.models;

import com.aliyun.tea.*;

public class GetSearchItemResponseBody extends TeaModel {
    // 数据项的脚注
    @NameInMap("footer")
    public String footer;

    // 创建时间
    @NameInMap("gmtCreate")
    public String gmtCreate;

    // 修改时间
    @NameInMap("gmtModified")
    public String gmtModified;

    // 数据项的头像
    @NameInMap("icon")
    public String icon;

    // 数据项的id,tabId和orgId相同的情况下，itemId唯一标识一条数据项
    @NameInMap("itemId")
    public String itemId;

    // 数据项的摘要
    @NameInMap("summary")
    public String summary;

    // 数据项的标题
    @NameInMap("title")
    public String title;

    // 数据项的跳转url地址
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

    public GetSearchItemResponseBody setSummary(String summary) {
        this.summary = summary;
        return this;
    }
    public String getSummary() {
        return this.summary;
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
