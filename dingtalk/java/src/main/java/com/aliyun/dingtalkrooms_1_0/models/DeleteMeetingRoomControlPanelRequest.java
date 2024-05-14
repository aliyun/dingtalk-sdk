// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrooms_1_0.models;

import com.aliyun.tea.*;

public class DeleteMeetingRoomControlPanelRequest extends TeaModel {
    @NameInMap("body")
    public DeleteMeetingRoomControlPanelRequestBody body;

    public static DeleteMeetingRoomControlPanelRequest build(java.util.Map<String, ?> map) throws Exception {
        DeleteMeetingRoomControlPanelRequest self = new DeleteMeetingRoomControlPanelRequest();
        return TeaModel.build(map, self);
    }

    public DeleteMeetingRoomControlPanelRequest setBody(DeleteMeetingRoomControlPanelRequestBody body) {
        this.body = body;
        return this;
    }
    public DeleteMeetingRoomControlPanelRequestBody getBody() {
        return this.body;
    }

    public static class DeleteMeetingRoomControlPanelRequestBody extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("roomIds")
        public java.util.List<String> roomIds;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("unionId")
        public String unionId;

        public static DeleteMeetingRoomControlPanelRequestBody build(java.util.Map<String, ?> map) throws Exception {
            DeleteMeetingRoomControlPanelRequestBody self = new DeleteMeetingRoomControlPanelRequestBody();
            return TeaModel.build(map, self);
        }

        public DeleteMeetingRoomControlPanelRequestBody setRoomIds(java.util.List<String> roomIds) {
            this.roomIds = roomIds;
            return this;
        }
        public java.util.List<String> getRoomIds() {
            return this.roomIds;
        }

        public DeleteMeetingRoomControlPanelRequestBody setUnionId(String unionId) {
            this.unionId = unionId;
            return this;
        }
        public String getUnionId() {
            return this.unionId;
        }

    }

}
