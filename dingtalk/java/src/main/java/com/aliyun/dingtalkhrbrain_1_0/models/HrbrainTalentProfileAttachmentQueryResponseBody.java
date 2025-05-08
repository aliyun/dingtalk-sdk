// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrbrain_1_0.models;

import com.aliyun.tea.*;

public class HrbrainTalentProfileAttachmentQueryResponseBody extends TeaModel {
    @NameInMap("content")
    public HrbrainTalentProfileAttachmentQueryResponseBodyContent content;

    @NameInMap("requestId")
    public String requestId;

    @NameInMap("result")
    public Boolean result;

    @NameInMap("success")
    public Boolean success;

    public static HrbrainTalentProfileAttachmentQueryResponseBody build(java.util.Map<String, ?> map) throws Exception {
        HrbrainTalentProfileAttachmentQueryResponseBody self = new HrbrainTalentProfileAttachmentQueryResponseBody();
        return TeaModel.build(map, self);
    }

    public HrbrainTalentProfileAttachmentQueryResponseBody setContent(HrbrainTalentProfileAttachmentQueryResponseBodyContent content) {
        this.content = content;
        return this;
    }
    public HrbrainTalentProfileAttachmentQueryResponseBodyContent getContent() {
        return this.content;
    }

    public HrbrainTalentProfileAttachmentQueryResponseBody setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public HrbrainTalentProfileAttachmentQueryResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

    public HrbrainTalentProfileAttachmentQueryResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class HrbrainTalentProfileAttachmentQueryResponseBodyContentStaffAttachmentInfoListAttachmentInfoList extends TeaModel {
        @NameInMap("name")
        public String name;

        @NameInMap("url")
        public String url;

        public static HrbrainTalentProfileAttachmentQueryResponseBodyContentStaffAttachmentInfoListAttachmentInfoList build(java.util.Map<String, ?> map) throws Exception {
            HrbrainTalentProfileAttachmentQueryResponseBodyContentStaffAttachmentInfoListAttachmentInfoList self = new HrbrainTalentProfileAttachmentQueryResponseBodyContentStaffAttachmentInfoListAttachmentInfoList();
            return TeaModel.build(map, self);
        }

        public HrbrainTalentProfileAttachmentQueryResponseBodyContentStaffAttachmentInfoListAttachmentInfoList setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public HrbrainTalentProfileAttachmentQueryResponseBodyContentStaffAttachmentInfoListAttachmentInfoList setUrl(String url) {
            this.url = url;
            return this;
        }
        public String getUrl() {
            return this.url;
        }

    }

    public static class HrbrainTalentProfileAttachmentQueryResponseBodyContentStaffAttachmentInfoList extends TeaModel {
        @NameInMap("attachmentInfoList")
        public java.util.List<HrbrainTalentProfileAttachmentQueryResponseBodyContentStaffAttachmentInfoListAttachmentInfoList> attachmentInfoList;

        @NameInMap("workNo")
        public String workNo;

        public static HrbrainTalentProfileAttachmentQueryResponseBodyContentStaffAttachmentInfoList build(java.util.Map<String, ?> map) throws Exception {
            HrbrainTalentProfileAttachmentQueryResponseBodyContentStaffAttachmentInfoList self = new HrbrainTalentProfileAttachmentQueryResponseBodyContentStaffAttachmentInfoList();
            return TeaModel.build(map, self);
        }

        public HrbrainTalentProfileAttachmentQueryResponseBodyContentStaffAttachmentInfoList setAttachmentInfoList(java.util.List<HrbrainTalentProfileAttachmentQueryResponseBodyContentStaffAttachmentInfoListAttachmentInfoList> attachmentInfoList) {
            this.attachmentInfoList = attachmentInfoList;
            return this;
        }
        public java.util.List<HrbrainTalentProfileAttachmentQueryResponseBodyContentStaffAttachmentInfoListAttachmentInfoList> getAttachmentInfoList() {
            return this.attachmentInfoList;
        }

        public HrbrainTalentProfileAttachmentQueryResponseBodyContentStaffAttachmentInfoList setWorkNo(String workNo) {
            this.workNo = workNo;
            return this;
        }
        public String getWorkNo() {
            return this.workNo;
        }

    }

    public static class HrbrainTalentProfileAttachmentQueryResponseBodyContent extends TeaModel {
        @NameInMap("staffAttachmentInfoList")
        public java.util.List<HrbrainTalentProfileAttachmentQueryResponseBodyContentStaffAttachmentInfoList> staffAttachmentInfoList;

        public static HrbrainTalentProfileAttachmentQueryResponseBodyContent build(java.util.Map<String, ?> map) throws Exception {
            HrbrainTalentProfileAttachmentQueryResponseBodyContent self = new HrbrainTalentProfileAttachmentQueryResponseBodyContent();
            return TeaModel.build(map, self);
        }

        public HrbrainTalentProfileAttachmentQueryResponseBodyContent setStaffAttachmentInfoList(java.util.List<HrbrainTalentProfileAttachmentQueryResponseBodyContentStaffAttachmentInfoList> staffAttachmentInfoList) {
            this.staffAttachmentInfoList = staffAttachmentInfoList;
            return this;
        }
        public java.util.List<HrbrainTalentProfileAttachmentQueryResponseBodyContentStaffAttachmentInfoList> getStaffAttachmentInfoList() {
            return this.staffAttachmentInfoList;
        }

    }

}
