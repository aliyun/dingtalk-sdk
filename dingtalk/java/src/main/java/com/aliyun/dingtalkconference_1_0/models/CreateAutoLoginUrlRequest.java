// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconference_1_0.models;

import com.aliyun.tea.*;

public class CreateAutoLoginUrlRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p><a href="https://meeting.dingtalk.com/j/xxxx">https://meeting.dingtalk.com/j/xxxx</a></p>
     */
    @NameInMap("meetingUrl")
    public String meetingUrl;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>qzR1iSMDvzR9iPXXXXXXXXXXXXXX</p>
     */
    @NameInMap("unionId")
    public String unionId;

    public static CreateAutoLoginUrlRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateAutoLoginUrlRequest self = new CreateAutoLoginUrlRequest();
        return TeaModel.build(map, self);
    }

    public CreateAutoLoginUrlRequest setMeetingUrl(String meetingUrl) {
        this.meetingUrl = meetingUrl;
        return this;
    }
    public String getMeetingUrl() {
        return this.meetingUrl;
    }

    public CreateAutoLoginUrlRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

}
