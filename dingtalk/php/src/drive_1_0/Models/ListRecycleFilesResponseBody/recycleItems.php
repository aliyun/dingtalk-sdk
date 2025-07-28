<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\ListRecycleFilesResponseBody;

use AlibabaCloud\Tea\Model;

class recycleItems extends Model
{
    /**
     * @var string
     */
    public $contentType;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $deleteStaffId;

    /**
     * @description This parameter is required.
     *
     * Use the UTC time format: yyyy-MM-ddTHH:mmZ
     *
     * @var string
     */
    public $deleteTime;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $fileName;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $filePath;

    /**
     * @description This parameter is required.
     *
     * @var int
     */
    public $fileSize;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $fileType;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $recycleItemId;
    protected $_name = [
        'contentType' => 'contentType',
        'deleteStaffId' => 'deleteStaffId',
        'deleteTime' => 'deleteTime',
        'fileName' => 'fileName',
        'filePath' => 'filePath',
        'fileSize' => 'fileSize',
        'fileType' => 'fileType',
        'recycleItemId' => 'recycleItemId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->contentType) {
            $res['contentType'] = $this->contentType;
        }
        if (null !== $this->deleteStaffId) {
            $res['deleteStaffId'] = $this->deleteStaffId;
        }
        if (null !== $this->deleteTime) {
            $res['deleteTime'] = $this->deleteTime;
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
        if (null !== $this->fileType) {
            $res['fileType'] = $this->fileType;
        }
        if (null !== $this->recycleItemId) {
            $res['recycleItemId'] = $this->recycleItemId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return recycleItems
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['contentType'])) {
            $model->contentType = $map['contentType'];
        }
        if (isset($map['deleteStaffId'])) {
            $model->deleteStaffId = $map['deleteStaffId'];
        }
        if (isset($map['deleteTime'])) {
            $model->deleteTime = $map['deleteTime'];
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
        if (isset($map['fileType'])) {
            $model->fileType = $map['fileType'];
        }
        if (isset($map['recycleItemId'])) {
            $model->recycleItemId = $map['recycleItemId'];
        }

        return $model;
    }
}
