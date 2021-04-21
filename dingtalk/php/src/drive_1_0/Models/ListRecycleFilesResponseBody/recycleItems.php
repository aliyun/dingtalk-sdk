<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\ListRecycleFilesResponseBody;

use AlibabaCloud\Tea\Model;

class recycleItems extends Model
{
    /**
     * @description 回收站item id
     *
     * @var string
     */
    public $recycleItemId;

    /**
     * @description 删除者id
     *
     * @var int
     */
    public $deleteUid;

    /**
     * @description 删除时间
     *
     * @var string
     */
    public $deleteTime;

    /**
     * @description 文件大小
     *
     * @var int
     */
    public $fileSize;

    /**
     * @description 文件类型
     *
     * @var string
     */
    public $fileType;

    /**
     * @description 文件内容类型
     *
     * @var string
     */
    public $contentType;

    /**
     * @description 文件名称
     *
     * @var string
     */
    public $fileName;

    /**
     * @description 文件路径
     *
     * @var string
     */
    public $filePath;
    protected $_name = [
        'recycleItemId' => 'recycleItemId',
        'deleteUid'     => 'deleteUid',
        'deleteTime'    => 'deleteTime',
        'fileSize'      => 'fileSize',
        'fileType'      => 'fileType',
        'contentType'   => 'contentType',
        'fileName'      => 'fileName',
        'filePath'      => 'filePath',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->recycleItemId) {
            $res['recycleItemId'] = $this->recycleItemId;
        }
        if (null !== $this->deleteUid) {
            $res['deleteUid'] = $this->deleteUid;
        }
        if (null !== $this->deleteTime) {
            $res['deleteTime'] = $this->deleteTime;
        }
        if (null !== $this->fileSize) {
            $res['fileSize'] = $this->fileSize;
        }
        if (null !== $this->fileType) {
            $res['fileType'] = $this->fileType;
        }
        if (null !== $this->contentType) {
            $res['contentType'] = $this->contentType;
        }
        if (null !== $this->fileName) {
            $res['fileName'] = $this->fileName;
        }
        if (null !== $this->filePath) {
            $res['filePath'] = $this->filePath;
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
        if (isset($map['recycleItemId'])) {
            $model->recycleItemId = $map['recycleItemId'];
        }
        if (isset($map['deleteUid'])) {
            $model->deleteUid = $map['deleteUid'];
        }
        if (isset($map['deleteTime'])) {
            $model->deleteTime = $map['deleteTime'];
        }
        if (isset($map['fileSize'])) {
            $model->fileSize = $map['fileSize'];
        }
        if (isset($map['fileType'])) {
            $model->fileType = $map['fileType'];
        }
        if (isset($map['contentType'])) {
            $model->contentType = $map['contentType'];
        }
        if (isset($map['fileName'])) {
            $model->fileName = $map['fileName'];
        }
        if (isset($map['filePath'])) {
            $model->filePath = $map['filePath'];
        }

        return $model;
    }
}
