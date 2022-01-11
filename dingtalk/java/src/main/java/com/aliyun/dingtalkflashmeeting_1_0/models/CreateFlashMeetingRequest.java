// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkflashmeeting_1_0.models;

import com.aliyun.tea.*;

public class CreateFlashMeetingRequest extends TeaModel {
    // 创建人union id
    @NameInMap("creator")
    public String creator;

    // 日程id
    @NameInMap("eventId")
    public String eventId;

    // 钉闪会名称
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
