// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrobot_1_0.models;

import com.aliyun.tea.*;

public class SetRobotPluginRequest extends TeaModel {
    @NameInMap("pluginInfoList")
    public java.util.List<SetRobotPluginRequestPluginInfoList> pluginInfoList;

    /**
     * <strong>example:</strong>
     * <p>dingncjdnfpkN7dsh</p>
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
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>@lALPDtXaDkO3j7hgYA</p>
         */
        @NameInMap("icon")
        public String icon;

        /**
         * <strong>example:</strong>
         * <p><a href="https://www.dingtalk.com">https://www.dingtalk.com</a></p>
         */
        @NameInMap("mobileUrl")
        public String mobileUrl;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>快捷入口名字</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <strong>example:</strong>
         * <p><a href="https://www.dingtalk.com">https://www.dingtalk.com</a></p>
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
