// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcalendar_1_0.models;

import com.aliyun.tea.*;

public class ListOrgPluginsResponseBody extends TeaModel {
    @NameInMap("plugins")
    public java.util.List<ListOrgPluginsResponseBodyPlugins> plugins;

    public static ListOrgPluginsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ListOrgPluginsResponseBody self = new ListOrgPluginsResponseBody();
        return TeaModel.build(map, self);
    }

    public ListOrgPluginsResponseBody setPlugins(java.util.List<ListOrgPluginsResponseBodyPlugins> plugins) {
        this.plugins = plugins;
        return this;
    }
    public java.util.List<ListOrgPluginsResponseBodyPlugins> getPlugins() {
        return this.plugins;
    }

    public static class ListOrgPluginsResponseBodyPluginsSubscribers extends TeaModel {
        @NameInMap("deptIds")
        public java.util.List<String> deptIds;

        @NameInMap("unionIds")
        public java.util.List<String> unionIds;

        public static ListOrgPluginsResponseBodyPluginsSubscribers build(java.util.Map<String, ?> map) throws Exception {
            ListOrgPluginsResponseBodyPluginsSubscribers self = new ListOrgPluginsResponseBodyPluginsSubscribers();
            return TeaModel.build(map, self);
        }

        public ListOrgPluginsResponseBodyPluginsSubscribers setDeptIds(java.util.List<String> deptIds) {
            this.deptIds = deptIds;
            return this;
        }
        public java.util.List<String> getDeptIds() {
            return this.deptIds;
        }

        public ListOrgPluginsResponseBodyPluginsSubscribers setUnionIds(java.util.List<String> unionIds) {
            this.unionIds = unionIds;
            return this;
        }
        public java.util.List<String> getUnionIds() {
            return this.unionIds;
        }

    }

    public static class ListOrgPluginsResponseBodyPlugins extends TeaModel {
        @NameInMap("logo")
        public String logo;

        @NameInMap("name")
        public String name;

        @NameInMap("pluginClassification")
        public String pluginClassification;

        @NameInMap("pluginId")
        public String pluginId;

        @NameInMap("subscribers")
        public ListOrgPluginsResponseBodyPluginsSubscribers subscribers;

        public static ListOrgPluginsResponseBodyPlugins build(java.util.Map<String, ?> map) throws Exception {
            ListOrgPluginsResponseBodyPlugins self = new ListOrgPluginsResponseBodyPlugins();
            return TeaModel.build(map, self);
        }

        public ListOrgPluginsResponseBodyPlugins setLogo(String logo) {
            this.logo = logo;
            return this;
        }
        public String getLogo() {
            return this.logo;
        }

        public ListOrgPluginsResponseBodyPlugins setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public ListOrgPluginsResponseBodyPlugins setPluginClassification(String pluginClassification) {
            this.pluginClassification = pluginClassification;
            return this;
        }
        public String getPluginClassification() {
            return this.pluginClassification;
        }

        public ListOrgPluginsResponseBodyPlugins setPluginId(String pluginId) {
            this.pluginId = pluginId;
            return this;
        }
        public String getPluginId() {
            return this.pluginId;
        }

        public ListOrgPluginsResponseBodyPlugins setSubscribers(ListOrgPluginsResponseBodyPluginsSubscribers subscribers) {
            this.subscribers = subscribers;
            return this;
        }
        public ListOrgPluginsResponseBodyPluginsSubscribers getSubscribers() {
            return this.subscribers;
        }

    }

}
