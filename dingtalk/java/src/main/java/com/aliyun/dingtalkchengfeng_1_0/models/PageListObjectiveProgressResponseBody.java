// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkchengfeng_1_0.models;

import com.aliyun.tea.*;

public class PageListObjectiveProgressResponseBody extends TeaModel {
    @NameInMap("content")
    public PageListObjectiveProgressResponseBodyContent content;

    /**
     * <p>Id of the request</p>
     */
    @NameInMap("requestId")
    public String requestId;

    @NameInMap("success")
    public Boolean success;

    public static PageListObjectiveProgressResponseBody build(java.util.Map<String, ?> map) throws Exception {
        PageListObjectiveProgressResponseBody self = new PageListObjectiveProgressResponseBody();
        return TeaModel.build(map, self);
    }

    public PageListObjectiveProgressResponseBody setContent(PageListObjectiveProgressResponseBodyContent content) {
        this.content = content;
        return this;
    }
    public PageListObjectiveProgressResponseBodyContent getContent() {
        return this.content;
    }

    public PageListObjectiveProgressResponseBody setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public PageListObjectiveProgressResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class PageListObjectiveProgressResponseBodyContent extends TeaModel {
        @NameInMap("count")
        public Integer count;

        @NameInMap("progressList")
        public java.util.List<OpenProgressDTO> progressList;

        public static PageListObjectiveProgressResponseBodyContent build(java.util.Map<String, ?> map) throws Exception {
            PageListObjectiveProgressResponseBodyContent self = new PageListObjectiveProgressResponseBodyContent();
            return TeaModel.build(map, self);
        }

        public PageListObjectiveProgressResponseBodyContent setCount(Integer count) {
            this.count = count;
            return this;
        }
        public Integer getCount() {
            return this.count;
        }

        public PageListObjectiveProgressResponseBodyContent setProgressList(java.util.List<OpenProgressDTO> progressList) {
            this.progressList = progressList;
            return this;
        }
        public java.util.List<OpenProgressDTO> getProgressList() {
            return this.progressList;
        }

    }

}
