// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrobot_1_0.models;

import com.aliyun.tea.*;

public class SetRobotPluginRequest extends TeaModel {
    @NameInMap("pluginInfoList")
    public java.util.List<SetRobotPluginRequestPluginInfoList> pluginInfoList;

    /**
     * <p>钉钉开放平台后台机器人的robotCode</p>
     */
    @NameInMap("robotCode")
    public String robotCode;

    public static SetRobotPluginRequest build(java.util.Map<String, ?> map) throws Exception {
        SetRobotPluginRequest self = new SetRobotPluginRequest();
        return TeaModel.build(map, self);
    }

    public SetRobotPluginRequest setPluginInfoList(java.util.List<SetRobotPluginRequestPluginInfoList> pluginInfoList) {
        this.pluginInfoList = pluginInfoList;
        return this;
    }
    public java.util.List<SetRobotPluginRequestPluginInfoList> getPluginInfoList() {
        return this.pluginInfoList;
    }

    public SetRobotPluginRequest setRobotCode(String robotCode) {
        this.robotCode = robotCode;
        return this;
    }
    public String getRobotCode() {
        return this.robotCode;
    }

    public static class SetRobotPluginRequestPluginInfoList extends TeaModel {
        /**
         * <p>快捷入口的图标id</p>
         */
        @NameInMap("icon")
        public String icon;

        /**
         * <p>手机端快捷入口跳转链接</p>
         */
        @NameInMap("mobileUrl")
        public String mobileUrl;

        /**
         * <p>快捷入口的名称</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <p>pc端会话快捷入口跳转链接</p>
         */
        @NameInMap("pcUrl")
        public String pcUrl;

        public static SetRobotPluginRequestPluginInfoList build(java.util.Map<String, ?> map) throws Exception {
            SetRobotPluginRequestPluginInfoList self = new SetRobotPluginRequestPluginInfoList();
            return TeaModel.build(map, self);
        }

        public SetRobotPluginRequestPluginInfoList setIcon(String icon) {
            this.icon = icon;
            return this;
        }
        public String getIcon() {
            return this.icon;
        }

        public SetRobotPluginRequestPluginInfoList setMobileUrl(String mobileUrl) {
            this.mobileUrl = mobileUrl;
            return this;
        }
        public String getMobileUrl() {
            return this.mobileUrl;
        }

        public SetRobotPluginRequestPluginInfoList setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public SetRobotPluginRequestPluginInfoList setPcUrl(String pcUrl) {
            this.pcUrl = pcUrl;
            return this;
        }
        public String getPcUrl() {
            return this.pcUrl;
        }

    }

}
