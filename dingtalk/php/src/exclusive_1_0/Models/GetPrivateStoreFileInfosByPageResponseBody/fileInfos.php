<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetPrivateStoreFileInfosByPageResponseBody;

use AlibabaCloud\Tea\Model;

class fileInfos extends Model
{
    /**
     * @example eg:图片、文档、文本、压缩包、视频、音频
     *
     * @var string
     */
    public $contentTypeMcms;

    /**
     * @example staff123
     *
     * @var string
     */
    public $creatorStaffId;

    /**
     * @var int
     */
    public $dentryId;

    /**
     * @var int
     */
    public $fileCreateTime;

    /**
     * @var string
     */
    public $fileName;

    /**
     * @var string
     */
    public $filePath;

    /**
     * @var int
     */
    public $fileSize;

    /**
     * @example eg:IM, 其他, 个人空间, 企业内共享
     *
     * @var string
     */
    public $sceneTypeMcms;

    /**
     * @var int
     */
    public $spaceId;

    /**
     * @var string
     */
    public $status;
    protected $_name = [
        'contentTypeMcms' => 'contentTypeMcms',
        'creatorStaffId' => 'creatorStaffId',
        'dentryId' => 'dentryId',
        'fileCreateTime' => 'fileCreateTime',
        'fileName' => 'fileName',
        'filePath' => 'filePath',
        'fileSize' => 'fileSize',
        'sceneTypeMcms' => 'sceneTypeMcms',
        'spaceId' => 'spaceId',
        'status' => 'status',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->contentTypeMcms) {
            $res['contentTypeMcms'] = $this->contentTypeMcms;
        }
        if (null !== $this->creatorStaffId) {
            $res['creatorStaffId'] = $this->creatorStaffId;
        }
        if (null !== $this->dentryId) {
            $res['dentryId'] = $this->dentryId;
        }
        if (null !== $this->fileCreateTime) {
            $res['fileCreateTime'] = $this->fileCreateTime;
        }
        if (null !== $this->fileName) {
            $res['fileName'] = $this->fileName;
        }
        if (null !== $this->filePath) {
            $res['filePath'] = $this->filePath;
        }
        if (null !== $this->fileSize) {
            $res['fileSize'] = $this->fileSize;
        }
        if (null !== $this->sceneTypeMcms) {
            $res['sceneTypeMcms'] = $this->sceneTypeMcms;
        }
        if (null !== $this->spaceId) {
            $res['spaceId'] = $this->spaceId;
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return fileInfos
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['contentTypeMcms'])) {
            $model->contentTypeMcms = $map['contentTypeMcms'];
        }
        if (isset($map['creatorStaffId'])) {
            $model->creatorStaffId = $map['creatorStaffId'];
        }
        if (isset($map['dentryId'])) {
            $model->dentryId = $map['dentryId'];
        }
        if (isset($map['fileCreateTime'])) {
            $model->fileCreateTime = $map['fileCreateTime'];
        }
        if (isset($map['fileName'])) {
            $model->fileName = $map['fileName'];
        }
        if (isset($map['filePath'])) {
            $model->filePath = $map['filePath'];
        }
        if (isset($map['fileSize'])) {
            $model->fileSize = $map['fileSize'];
        }
        if (isset($map['sceneTypeMcms'])) {
            $model->sceneTypeMcms = $map['sceneTypeMcms'];
        }
        if (isset($map['spaceId'])) {
            $model->spaceId = $map['spaceId'];
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }

        return $model;
    }
}
