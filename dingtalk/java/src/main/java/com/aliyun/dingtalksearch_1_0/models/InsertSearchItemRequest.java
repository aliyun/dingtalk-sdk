// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalksearch_1_0.models;

import com.aliyun.tea.*;

public class InsertSearchItemRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>四大名著</p>
     */
    @NameInMap("footer")
    public String footer;

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
     * <strong>example:</strong>
     * <p><a href="http://www.baidu.com">www.baidu.com</a></p>
     */
    @NameInMap("mobileUrl")
    public String mobileUrl;

    /**
     * <strong>example:</strong>
     * <p><a href="http://www.baidu.com">www.baidu.com</a></p>
     */
    @NameInMap("pcUrl")
    public String pcUrl;

    /**
     * <strong>example:</strong>
     * <p>中国古代章回体长篇小说</p>
     */
    @NameInMap("summary")
    public String summary;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>红楼梦</p>
     */
    @NameInMap("title")
    public String title;

    /**
     * <strong>example:</strong>
     * <p><a href="http://www.baidu.com">www.baidu.com</a></p>
     */
    @NameInMap("url")
    public String url;

    public static InsertSearchItemRequest build(java.util.Map<String, ?> map) throws Exception {
        InsertSearchItemRequest self = new InsertSearchItemRequest();
        return TeaModel.build(map, self);
    }

    public InsertSearchItemRequest setFooter(String footer) {
        this.footer = footer;
        return this;
    }
    public String getFooter() {
        return this.footer;
    }

    public InsertSearchItemRequest setIcon(String icon) {
        this.icon = icon;
        return this;
    }
    public String getIcon() {
        return this.icon;
    }

    public InsertSearchItemRequest setItemId(String itemId) {
        this.itemId = itemId;
        return this;
    }
    public String getItemId() {
        return this.itemId;
    }

    public InsertSearchItemRequest setMobileUrl(String mobileUrl) {
        this.mobileUrl = mobileUrl;
        return this;
    }
    public String getMobileUrl() {
        return this.mobileUrl;
    }

    public InsertSearchItemRequest setPcUrl(String pcUrl) {
        this.pcUrl = pcUrl;
        return this;
    }
    public String getPcUrl() {
        return this.pcUrl;
    }

    public InsertSearchItemRequest setSummary(String summary) {
        this.summary = summary;
        return this;
    }
    public String getSummary() {
        return this.summary;
    }

    public InsertSearchItemRequest setTitle(String title) {
        this.title = title;
        return this;
    }
    public String getTitle() {
        return this.title;
    }

    public InsertSearchItemRequest setUrl(String url) {
        this.url = url;
        return this;
    }
    public String getUrl() {
        return this.url;
    }

}
