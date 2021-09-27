// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalksearch_1_0.models;

import com.aliyun.tea.*;

public class InsertSearchItemRequest extends TeaModel {
    // 数据项的id，tabId和orgId相同的情况下，itemId唯一标识一条数据项，长度不能超过128
    @NameInMap("itemId")
    public String itemId;

    // 数据项的标题，长度不能超过16
    @NameInMap("title")
    public String title;

    // 数据项的脚注，长度不能超过64
    @NameInMap("footer")
    public String footer;

    // 数据项的摘要，长度不能超过64
    @NameInMap("summary")
    public String summary;

    // 数据项的头像，长度不能超过512
    @NameInMap("icon")
    public String icon;

    // 数据项的跳转url地址
    @NameInMap("url")
    public String url;

    public static InsertSearchItemRequest build(java.util.Map<String, ?> map) throws Exception {
        InsertSearchItemRequest self = new InsertSearchItemRequest();
        return TeaModel.build(map, self);
    }

    public InsertSearchItemRequest setItemId(String itemId) {
        this.itemId = itemId;
        return this;
    }
    public String getItemId() {
        return this.itemId;
    }

    public InsertSearchItemRequest setTitle(String title) {
        this.title = title;
        return this;
    }
    public String getTitle() {
        return this.title;
    }

    public InsertSearchItemRequest setFooter(String footer) {
        this.footer = footer;
        return this;
    }
    public String getFooter() {
        return this.footer;
    }

    public InsertSearchItemRequest setSummary(String summary) {
        this.summary = summary;
        return this;
    }
    public String getSummary() {
        return this.summary;
    }

    public InsertSearchItemRequest setIcon(String icon) {
        this.icon = icon;
        return this;
    }
    public String getIcon() {
        return this.icon;
    }

    public InsertSearchItemRequest setUrl(String url) {
        this.url = url;
        return this;
    }
    public String getUrl() {
        return this.url;
    }

}
