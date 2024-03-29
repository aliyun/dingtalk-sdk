// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class CreateTaskObjectLinkRequest extends TeaModel {
    @NameInMap("linkedData")
    public CreateTaskObjectLinkRequestLinkedData linkedData;

    public static CreateTaskObjectLinkRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateTaskObjectLinkRequest self = new CreateTaskObjectLinkRequest();
        return TeaModel.build(map, self);
    }

    public CreateTaskObjectLinkRequest setLinkedData(CreateTaskObjectLinkRequestLinkedData linkedData) {
        this.linkedData = linkedData;
        return this;
    }
    public CreateTaskObjectLinkRequestLinkedData getLinkedData() {
        return this.linkedData;
    }

    public static class CreateTaskObjectLinkRequestLinkedData extends TeaModel {
        @NameInMap("content")
        public String content;

        @NameInMap("thumbnailUrl")
        public String thumbnailUrl;

        @NameInMap("title")
        public String title;

        @NameInMap("url")
        public String url;

        public static CreateTaskObjectLinkRequestLinkedData build(java.util.Map<String, ?> map) throws Exception {
            CreateTaskObjectLinkRequestLinkedData self = new CreateTaskObjectLinkRequestLinkedData();
            return TeaModel.build(map, self);
        }

        public CreateTaskObjectLinkRequestLinkedData setContent(String content) {
            this.content = content;
            return this;
        }
        public String getContent() {
            return this.content;
        }

        public CreateTaskObjectLinkRequestLinkedData setThumbnailUrl(String thumbnailUrl) {
            this.thumbnailUrl = thumbnailUrl;
            return this;
        }
        public String getThumbnailUrl() {
            return this.thumbnailUrl;
        }

        public CreateTaskObjectLinkRequestLinkedData setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

        public CreateTaskObjectLinkRequestLinkedData setUrl(String url) {
            this.url = url;
            return this;
        }
        public String getUrl() {
            return this.url;
        }

    }

}
