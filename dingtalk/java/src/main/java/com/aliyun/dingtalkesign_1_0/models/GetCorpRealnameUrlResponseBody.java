// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkesign_1_0.models;

import com.aliyun.tea.*;

public class GetCorpRealnameUrlResponseBody extends TeaModel {
    @NameInMap("code")
    public Integer code;

    @NameInMap("message")
    public String message;

    @NameInMap("data")
    public GetCorpRealnameUrlResponseBodyData data;

    public static GetCorpRealnameUrlResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetCorpRealnameUrlResponseBody self = new GetCorpRealnameUrlResponseBody();
        return TeaModel.build(map, self);
    }

    public GetCorpRealnameUrlResponseBody setCode(Integer code) {
        this.code = code;
        return this;
    }
    public Integer getCode() {
        return this.code;
    }

    public GetCorpRealnameUrlResponseBody setMessage(String message) {
        this.message = message;
        return this;
    }
    public String getMessage() {
        return this.message;
    }

    public GetCorpRealnameUrlResponseBody setData(GetCorpRealnameUrlResponseBodyData data) {
        this.data = data;
        return this;
    }
    public GetCorpRealnameUrlResponseBodyData getData() {
        return this.data;
    }

    public static class GetCorpRealnameUrlResponseBodyData extends TeaModel {
        @NameInMap("taskId")
        public String taskId;

        @NameInMap("pcUrl")
        public String pcUrl;

        @NameInMap("mobileUrl")
        public String mobileUrl;

        public static GetCorpRealnameUrlResponseBodyData build(java.util.Map<String, ?> map) throws Exception {
            GetCorpRealnameUrlResponseBodyData self = new GetCorpRealnameUrlResponseBodyData();
            return TeaModel.build(map, self);
        }

        public GetCorpRealnameUrlResponseBodyData setTaskId(String taskId) {
            this.taskId = taskId;
            return this;
        }
        public String getTaskId() {
            return this.taskId;
        }

        public GetCorpRealnameUrlResponseBodyData setPcUrl(String pcUrl) {
            this.pcUrl = pcUrl;
            return this;
        }
        public String getPcUrl() {
            return this.pcUrl;
        }

        public GetCorpRealnameUrlResponseBodyData setMobileUrl(String mobileUrl) {
            this.mobileUrl = mobileUrl;
            return this;
        }
        public String getMobileUrl() {
            return this.mobileUrl;
        }

    }

}
