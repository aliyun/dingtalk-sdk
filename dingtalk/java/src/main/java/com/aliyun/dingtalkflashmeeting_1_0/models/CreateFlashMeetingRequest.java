// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkflashmeeting_1_0.models;

import com.aliyun.tea.*;

public class CreateFlashMeetingRequest extends TeaModel {
    /**
     * <p>创建人union id</p>
     */
    @NameInMap("creator")
    public String creator;

    /**
     * <p>日程id</p>
     */
    @NameInMap("eventId")
    public String eventId;

    /**
     * <p>钉闪会名称</p>
     */
    @NameInMap("title")
    public String title;

    public static CreateFlashMeetingRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateFlashMeetingRequest self = new CreateFlashMeetingRequest();
        return TeaModel.build(map, self);
    }

    public CreateFlashMeetingRequest setCreator(String creator) {
        this.creator = creator;
        return this;
    }
    public String getCreator() {
        return this.creator;
    }

    public CreateFlashMeetingRequest setEventId(String eventId) {
        this.eventId = eventId;
        return this;
    }
    public String getEventId() {
        return this.eventId;
    }

    public CreateFlashMeetingRequest setTitle(String title) {
        this.title = title;
        return this;
    }
    public String getTitle() {
        return this.title;
    }

}
