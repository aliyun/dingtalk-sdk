// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkminutes_1_0.models;

import com.aliyun.tea.*;

public class ListMinutesAttachmentsResponseBody extends TeaModel {
    @NameInMap("attachments")
    public java.util.List<ListMinutesAttachmentsResponseBodyAttachments> attachments;

    @NameInMap("hasNext")
    public Boolean hasNext;

    @NameInMap("nextToken")
    public String nextToken;

    public static ListMinutesAttachmentsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ListMinutesAttachmentsResponseBody self = new ListMinutesAttachmentsResponseBody();
        return TeaModel.build(map, self);
    }

    public ListMinutesAttachmentsResponseBody setAttachments(java.util.List<ListMinutesAttachmentsResponseBodyAttachments> attachments) {
        this.attachments = attachments;
        return this;
    }
    public java.util.List<ListMinutesAttachmentsResponseBodyAttachments> getAttachments() {
        return this.attachments;
    }

    public ListMinutesAttachmentsResponseBody setHasNext(Boolean hasNext) {
        this.hasNext = hasNext;
        return this;
    }
    public Boolean getHasNext() {
        return this.hasNext;
    }

    public ListMinutesAttachmentsResponseBody setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public static class ListMinutesAttachmentsResponseBodyAttachments extends TeaModel {
        @NameInMap("content")
        public String content;

        @NameInMap("contentType")
        public Integer contentType;

        @NameInMap("downloadUrl")
        public String downloadUrl;

        @NameInMap("noteId")
        public Long noteId;

        @NameInMap("noteTime")
        public Long noteTime;

        @NameInMap("relativeTimeMs")
        public Long relativeTimeMs;

        @NameInMap("type")
        public Integer type;

        public static ListMinutesAttachmentsResponseBodyAttachments build(java.util.Map<String, ?> map) throws Exception {
            ListMinutesAttachmentsResponseBodyAttachments self = new ListMinutesAttachmentsResponseBodyAttachments();
            return TeaModel.build(map, self);
        }

        public ListMinutesAttachmentsResponseBodyAttachments setContent(String content) {
            this.content = content;
            return this;
        }
        public String getContent() {
            return this.content;
        }

        public ListMinutesAttachmentsResponseBodyAttachments setContentType(Integer contentType) {
            this.contentType = contentType;
            return this;
        }
        public Integer getContentType() {
            return this.contentType;
        }

        public ListMinutesAttachmentsResponseBodyAttachments setDownloadUrl(String downloadUrl) {
            this.downloadUrl = downloadUrl;
            return this;
        }
        public String getDownloadUrl() {
            return this.downloadUrl;
        }

        public ListMinutesAttachmentsResponseBodyAttachments setNoteId(Long noteId) {
            this.noteId = noteId;
            return this;
        }
        public Long getNoteId() {
            return this.noteId;
        }

        public ListMinutesAttachmentsResponseBodyAttachments setNoteTime(Long noteTime) {
            this.noteTime = noteTime;
            return this;
        }
        public Long getNoteTime() {
            return this.noteTime;
        }

        public ListMinutesAttachmentsResponseBodyAttachments setRelativeTimeMs(Long relativeTimeMs) {
            this.relativeTimeMs = relativeTimeMs;
            return this;
        }
        public Long getRelativeTimeMs() {
            return this.relativeTimeMs;
        }

        public ListMinutesAttachmentsResponseBodyAttachments setType(Integer type) {
            this.type = type;
            return this;
        }
        public Integer getType() {
            return this.type;
        }

    }

}
