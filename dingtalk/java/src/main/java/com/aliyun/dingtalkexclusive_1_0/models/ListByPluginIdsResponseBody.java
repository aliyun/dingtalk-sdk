// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class ListByPluginIdsResponseBody extends TeaModel {
    @NameInMap("pluginInfoList")
    public java.util.List<ListByPluginIdsResponseBodyPluginInfoList> pluginInfoList;

    public static ListByPluginIdsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ListByPluginIdsResponseBody self = new ListByPluginIdsResponseBody();
        return TeaModel.build(map, self);
    }

    public ListByPluginIdsResponseBody setPluginInfoList(java.util.List<ListByPluginIdsResponseBodyPluginInfoList> pluginInfoList) {
        this.pluginInfoList = pluginInfoList;
        return this;
    }
    public java.util.List<ListByPluginIdsResponseBodyPluginInfoList> getPluginInfoList() {
        return this.pluginInfoList;
    }

    public static class ListByPluginIdsResponseBodyPluginInfoList extends TeaModel {
        @NameInMap("appId")
        public String appId;

        @NameInMap("createAt")
        public Long createAt;

        @NameInMap("desc")
        public String desc;

        @NameInMap("icons")
        public String icons;

        @NameInMap("modifiedAt")
        public Long modifiedAt;

        @NameInMap("name")
        public String name;

        @NameInMap("pcUrl")
        public String pcUrl;

        @NameInMap("pluginId")
        public String pluginId;

        @NameInMap("status")
        public Integer status;

        @NameInMap("url")
        public String url;

        public static ListByPluginIdsResponseBodyPluginInfoList build(java.util.Map<String, ?> map) throws Exception {
            ListByPluginIdsResponseBodyPluginInfoList self = new ListByPluginIdsResponseBodyPluginInfoList();
            return TeaModel.build(map, self);
        }

        public ListByPluginIdsResponseBodyPluginInfoList setAppId(String appId) {
            this.appId = appId;
            return this;
        }
        public String getAppId() {
            return this.appId;
        }

        public ListByPluginIdsResponseBodyPluginInfoList setCreateAt(Long createAt) {
            this.createAt = createAt;
            return this;
        }
        public Long getCreateAt() {
            return this.createAt;
        }

        public ListByPluginIdsResponseBodyPluginInfoList setDesc(String desc) {
            this.desc = desc;
            return this;
        }
        public String getDesc() {
            return this.desc;
        }

        public ListByPluginIdsResponseBodyPluginInfoList setIcons(String icons) {
            this.icons = icons;
            return this;
        }
        public String getIcons() {
            return this.icons;
        }

        public ListByPluginIdsResponseBodyPluginInfoList setModifiedAt(Long modifiedAt) {
            this.modifiedAt = modifiedAt;
            return this;
        }
        public Long getModifiedAt() {
            return this.modifiedAt;
        }

        public ListByPluginIdsResponseBodyPluginInfoList setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public ListByPluginIdsResponseBodyPluginInfoList setPcUrl(String pcUrl) {
            this.pcUrl = pcUrl;
            return this;
        }
        public String getPcUrl() {
            return this.pcUrl;
        }

        public ListByPluginIdsResponseBodyPluginInfoList setPluginId(String pluginId) {
            this.pluginId = pluginId;
            return this;
        }
        public String getPluginId() {
            return this.pluginId;
        }

        public ListByPluginIdsResponseBodyPluginInfoList setStatus(Integer status) {
            this.status = status;
            return this;
        }
        public Integer getStatus() {
            return this.status;
        }

        public ListByPluginIdsResponseBodyPluginInfoList setUrl(String url) {
            this.url = url;
            return this;
        }
        public String getUrl() {
            return this.url;
        }

    }

}
