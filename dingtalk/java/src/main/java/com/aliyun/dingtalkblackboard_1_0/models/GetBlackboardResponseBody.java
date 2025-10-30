// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkblackboard_1_0.models;

import com.aliyun.tea.*;

public class GetBlackboardResponseBody extends TeaModel {
    @NameInMap("attachments")
    public java.util.List<GetBlackboardResponseBodyAttachments> attachments;

    /**
     * <strong>example:</strong>
     * <p>example_category_id</p>
     */
    @NameInMap("categoryId")
    public String categoryId;

    /**
     * <strong>example:</strong>
     * <p>分类示例</p>
     */
    @NameInMap("categoryName")
    public String categoryName;

    /**
     * <strong>example:</strong>
     * <p>公告内容示例</p>
     */
    @NameInMap("content")
    public String content;

    /**
     * <strong>example:</strong>
     * <p><a href="https://down.dingtalk.com/ddmedia/xxxx.png?ddFrom=blackboard.pic">https://down.dingtalk.com/ddmedia/xxxx.png?ddFrom=blackboard.pic</a></p>
     */
    @NameInMap("coverPicUrl")
    public String coverPicUrl;

    @NameInMap("depNameList")
    public java.util.List<String> depNameList;

    @NameInMap("deptList")
    public java.util.List<GetBlackboardResponseBodyDeptList> deptList;

    /**
     * <p>Use the UTC time format: yyyy-MM-ddTHH:mmZ</p>
     */
    @NameInMap("gmtCreate")
    public String gmtCreate;

    /**
     * <p>Use the UTC time format: yyyy-MM-ddTHH:mmZ</p>
     * 
     * <strong>example:</strong>
     * <p>2025-01-01 00:00:00</p>
     */
    @NameInMap("gmtModified")
    public String gmtModified;

    /**
     * <strong>example:</strong>
     * <p>fbeaxxxxxxxxxxxxxxxxxxxxxxxxe292</p>
     */
    @NameInMap("id")
    public String id;

    /**
     * <strong>example:</strong>
     * <p>0</p>
     */
    @NameInMap("isPushTop")
    public Long isPushTop;

    /**
     * <strong>example:</strong>
     * <p>0</p>
     */
    @NameInMap("privateLevel")
    public Long privateLevel;

    /**
     * <strong>example:</strong>
     * <p>1</p>
     */
    @NameInMap("readCount")
    public Long readCount;

    /**
     * <strong>example:</strong>
     * <p>manager01</p>
     */
    @NameInMap("senderStaffId")
    public String senderStaffId;

    /**
     * <strong>example:</strong>
     * <p>公告标题实例</p>
     */
    @NameInMap("title")
    public String title;

    /**
     * <strong>example:</strong>
     * <p>1</p>
     */
    @NameInMap("unReadCount")
    public Long unReadCount;

    @NameInMap("userList")
    public java.util.List<GetBlackboardResponseBodyUserList> userList;

    @NameInMap("userNameList")
    public java.util.List<String> userNameList;

    public static GetBlackboardResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetBlackboardResponseBody self = new GetBlackboardResponseBody();
        return TeaModel.build(map, self);
    }

    public GetBlackboardResponseBody setAttachments(java.util.List<GetBlackboardResponseBodyAttachments> attachments) {
        this.attachments = attachments;
        return this;
    }
    public java.util.List<GetBlackboardResponseBodyAttachments> getAttachments() {
        return this.attachments;
    }

    public GetBlackboardResponseBody setCategoryId(String categoryId) {
        this.categoryId = categoryId;
        return this;
    }
    public String getCategoryId() {
        return this.categoryId;
    }

    public GetBlackboardResponseBody setCategoryName(String categoryName) {
        this.categoryName = categoryName;
        return this;
    }
    public String getCategoryName() {
        return this.categoryName;
    }

    public GetBlackboardResponseBody setContent(String content) {
        this.content = content;
        return this;
    }
    public String getContent() {
        return this.content;
    }

    public GetBlackboardResponseBody setCoverPicUrl(String coverPicUrl) {
        this.coverPicUrl = coverPicUrl;
        return this;
    }
    public String getCoverPicUrl() {
        return this.coverPicUrl;
    }

    public GetBlackboardResponseBody setDepNameList(java.util.List<String> depNameList) {
        this.depNameList = depNameList;
        return this;
    }
    public java.util.List<String> getDepNameList() {
        return this.depNameList;
    }

    public GetBlackboardResponseBody setDeptList(java.util.List<GetBlackboardResponseBodyDeptList> deptList) {
        this.deptList = deptList;
        return this;
    }
    public java.util.List<GetBlackboardResponseBodyDeptList> getDeptList() {
        return this.deptList;
    }

    public GetBlackboardResponseBody setGmtCreate(String gmtCreate) {
        this.gmtCreate = gmtCreate;
        return this;
    }
    public String getGmtCreate() {
        return this.gmtCreate;
    }

    public GetBlackboardResponseBody setGmtModified(String gmtModified) {
        this.gmtModified = gmtModified;
        return this;
    }
    public String getGmtModified() {
        return this.gmtModified;
    }

    public GetBlackboardResponseBody setId(String id) {
        this.id = id;
        return this;
    }
    public String getId() {
        return this.id;
    }

    public GetBlackboardResponseBody setIsPushTop(Long isPushTop) {
        this.isPushTop = isPushTop;
        return this;
    }
    public Long getIsPushTop() {
        return this.isPushTop;
    }

    public GetBlackboardResponseBody setPrivateLevel(Long privateLevel) {
        this.privateLevel = privateLevel;
        return this;
    }
    public Long getPrivateLevel() {
        return this.privateLevel;
    }

    public GetBlackboardResponseBody setReadCount(Long readCount) {
        this.readCount = readCount;
        return this;
    }
    public Long getReadCount() {
        return this.readCount;
    }

    public GetBlackboardResponseBody setSenderStaffId(String senderStaffId) {
        this.senderStaffId = senderStaffId;
        return this;
    }
    public String getSenderStaffId() {
        return this.senderStaffId;
    }

    public GetBlackboardResponseBody setTitle(String title) {
        this.title = title;
        return this;
    }
    public String getTitle() {
        return this.title;
    }

    public GetBlackboardResponseBody setUnReadCount(Long unReadCount) {
        this.unReadCount = unReadCount;
        return this;
    }
    public Long getUnReadCount() {
        return this.unReadCount;
    }

    public GetBlackboardResponseBody setUserList(java.util.List<GetBlackboardResponseBodyUserList> userList) {
        this.userList = userList;
        return this;
    }
    public java.util.List<GetBlackboardResponseBodyUserList> getUserList() {
        return this.userList;
    }

    public GetBlackboardResponseBody setUserNameList(java.util.List<String> userNameList) {
        this.userNameList = userNameList;
        return this;
    }
    public java.util.List<String> getUserNameList() {
        return this.userNameList;
    }

    public static class GetBlackboardResponseBodyAttachments extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>xxxx</p>
         */
        @NameInMap("dentryId")
        public String dentryId;

        /**
         * <strong>example:</strong>
         * <p>附件.pdf</p>
         */
        @NameInMap("fileName")
        public String fileName;

        /**
         * <strong>example:</strong>
         * <p>pdf</p>
         */
        @NameInMap("fileType")
        public String fileType;

        /**
         * <strong>example:</strong>
         * <p>xxxx</p>
         */
        @NameInMap("spaceId")
        public String spaceId;

        public static GetBlackboardResponseBodyAttachments build(java.util.Map<String, ?> map) throws Exception {
            GetBlackboardResponseBodyAttachments self = new GetBlackboardResponseBodyAttachments();
            return TeaModel.build(map, self);
        }

        public GetBlackboardResponseBodyAttachments setDentryId(String dentryId) {
            this.dentryId = dentryId;
            return this;
        }
        public String getDentryId() {
            return this.dentryId;
        }

        public GetBlackboardResponseBodyAttachments setFileName(String fileName) {
            this.fileName = fileName;
            return this;
        }
        public String getFileName() {
            return this.fileName;
        }

        public GetBlackboardResponseBodyAttachments setFileType(String fileType) {
            this.fileType = fileType;
            return this;
        }
        public String getFileType() {
            return this.fileType;
        }

        public GetBlackboardResponseBodyAttachments setSpaceId(String spaceId) {
            this.spaceId = spaceId;
            return this;
        }
        public String getSpaceId() {
            return this.spaceId;
        }

    }

    public static class GetBlackboardResponseBodyDeptList extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>example_dept_id</p>
         */
        @NameInMap("deptId")
        public String deptId;

        /**
         * <strong>example:</strong>
         * <p>xxxx部门</p>
         */
        @NameInMap("name")
        public String name;

        public static GetBlackboardResponseBodyDeptList build(java.util.Map<String, ?> map) throws Exception {
            GetBlackboardResponseBodyDeptList self = new GetBlackboardResponseBodyDeptList();
            return TeaModel.build(map, self);
        }

        public GetBlackboardResponseBodyDeptList setDeptId(String deptId) {
            this.deptId = deptId;
            return this;
        }
        public String getDeptId() {
            return this.deptId;
        }

        public GetBlackboardResponseBodyDeptList setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

    }

    public static class GetBlackboardResponseBodyUserList extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>dingxxxx</p>
         */
        @NameInMap("corpId")
        public String corpId;

        /**
         * <strong>example:</strong>
         * <p>示例员工名称</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <strong>example:</strong>
         * <p>manager01</p>
         */
        @NameInMap("staffId")
        public String staffId;

        public static GetBlackboardResponseBodyUserList build(java.util.Map<String, ?> map) throws Exception {
            GetBlackboardResponseBodyUserList self = new GetBlackboardResponseBodyUserList();
            return TeaModel.build(map, self);
        }

        public GetBlackboardResponseBodyUserList setCorpId(String corpId) {
            this.corpId = corpId;
            return this;
        }
        public String getCorpId() {
            return this.corpId;
        }

        public GetBlackboardResponseBodyUserList setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public GetBlackboardResponseBodyUserList setStaffId(String staffId) {
            this.staffId = staffId;
            return this;
        }
        public String getStaffId() {
            return this.staffId;
        }

    }

}
