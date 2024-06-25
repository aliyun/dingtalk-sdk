// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrooms_1_0.models;

import com.aliyun.tea.*;

public class CreateMeetingRoomControlPanelRequest extends TeaModel {
    @NameInMap("extra")
    public CreateMeetingRoomControlPanelRequestExtra extra;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("roomConfig")
    public java.util.List<CreateMeetingRoomControlPanelRequestRoomConfig> roomConfig;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>25SDWxxxxxx</p>
     */
    @NameInMap("roomId")
    public String roomId;

    /**
     * <strong>example:</strong>
     * <p>0</p>
     */
    @NameInMap("status")
    public Integer status;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>2iPOLbpUNMLzB5LuwggiiqiPwiEiE</p>
     */
    @NameInMap("unionId")
    public String unionId;

    public static CreateMeetingRoomControlPanelRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateMeetingRoomControlPanelRequest self = new CreateMeetingRoomControlPanelRequest();
        return TeaModel.build(map, self);
    }

    public CreateMeetingRoomControlPanelRequest setExtra(CreateMeetingRoomControlPanelRequestExtra extra) {
        this.extra = extra;
        return this;
    }
    public CreateMeetingRoomControlPanelRequestExtra getExtra() {
        return this.extra;
    }

    public CreateMeetingRoomControlPanelRequest setRoomConfig(java.util.List<CreateMeetingRoomControlPanelRequestRoomConfig> roomConfig) {
        this.roomConfig = roomConfig;
        return this;
    }
    public java.util.List<CreateMeetingRoomControlPanelRequestRoomConfig> getRoomConfig() {
        return this.roomConfig;
    }

    public CreateMeetingRoomControlPanelRequest setRoomId(String roomId) {
        this.roomId = roomId;
        return this;
    }
    public String getRoomId() {
        return this.roomId;
    }

    public CreateMeetingRoomControlPanelRequest setStatus(Integer status) {
        this.status = status;
        return this;
    }
    public Integer getStatus() {
        return this.status;
    }

    public CreateMeetingRoomControlPanelRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

    public static class CreateMeetingRoomControlPanelRequestExtra extends TeaModel {
        @NameInMap("param")
        public java.util.Map<String, String> param;

        public static CreateMeetingRoomControlPanelRequestExtra build(java.util.Map<String, ?> map) throws Exception {
            CreateMeetingRoomControlPanelRequestExtra self = new CreateMeetingRoomControlPanelRequestExtra();
            return TeaModel.build(map, self);
        }

        public CreateMeetingRoomControlPanelRequestExtra setParam(java.util.Map<String, String> param) {
            this.param = param;
            return this;
        }
        public java.util.Map<String, String> getParam() {
            return this.param;
        }

    }

    public static class CreateMeetingRoomControlPanelRequestRoomConfig extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>name</p>
         */
        @NameInMap("enName")
        public String enName;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p><a href="http://www.xxx.com">www.xxx.com</a></p>
         */
        @NameInMap("icon")
        public String icon;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>栗子xx</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>30</p>
         */
        @NameInMap("showTime")
        public Integer showTime;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>0</p>
         */
        @NameInMap("sort")
        public Integer sort;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p><a href="https://www.taoxxx.com">https://www.taoxxx.com</a></p>
         */
        @NameInMap("url")
        public String url;

        public static CreateMeetingRoomControlPanelRequestRoomConfig build(java.util.Map<String, ?> map) throws Exception {
            CreateMeetingRoomControlPanelRequestRoomConfig self = new CreateMeetingRoomControlPanelRequestRoomConfig();
            return TeaModel.build(map, self);
        }

        public CreateMeetingRoomControlPanelRequestRoomConfig setEnName(String enName) {
            this.enName = enName;
            return this;
        }
        public String getEnName() {
            return this.enName;
        }

        public CreateMeetingRoomControlPanelRequestRoomConfig setIcon(String icon) {
            this.icon = icon;
            return this;
        }
        public String getIcon() {
            return this.icon;
        }

        public CreateMeetingRoomControlPanelRequestRoomConfig setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public CreateMeetingRoomControlPanelRequestRoomConfig setShowTime(Integer showTime) {
            this.showTime = showTime;
            return this;
        }
        public Integer getShowTime() {
            return this.showTime;
        }

        public CreateMeetingRoomControlPanelRequestRoomConfig setSort(Integer sort) {
            this.sort = sort;
            return this;
        }
        public Integer getSort() {
            return this.sort;
        }

        public CreateMeetingRoomControlPanelRequestRoomConfig setUrl(String url) {
            this.url = url;
            return this;
        }
        public String getUrl() {
            return this.url;
        }

    }

}
