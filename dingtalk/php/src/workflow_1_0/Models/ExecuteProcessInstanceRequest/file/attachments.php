<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\ExecuteProcessInstanceRequest\file;

use AlibabaCloud\Tea\Model;

class attachments extends Model
{
    /**
     * @description 文件ID。
     *
     * @var string
     */
    public $fileId;

    /**
     * @description 文件名称。
     *
     * @var string
     */
    public $fileName;

    /**
     * @description 文件大小。
     *
     * @var string
     */
    public $fileSize;

    /**
     * @description 文件类型。
     *
     * @var string
     */
    public $fileType;

    /**
     * @description 钉盘空间ID。
     *
     * @var string
     */
    public $spaceId;
    protected $_name = [
        'fileId'   => 'fileId',
        'fileName' => 'fileName',
        'fileSize' => 'fileSize',
        'fileType' => 'fileType',
        'spaceId'  => 'spaceId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->fileId) {
            $res['fileId'] = $this->fileId;
        }
        if (null !== $this->fileName) {
            $res['fileName'] = $this->fileName;
        }
        if (null !== $this->fileSize) {
            $res['fileSize'] = $this->fileSize;
        }
        if (null !== $this->fileType) {
            $res['fileType'] = $this->fileType;
        }
        if (null !== $this->spaceId) {
            $res['spaceId'] = $this->spaceId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return attachments
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['fileId'])) {
            $model->fileId = $map['fileId'];
        }
        if (isset($map['fileName'])) {
            $model->fileName = $map['fileName'];
        }
        if (isset($map['fileSize'])) {
            $model->fileSize = $map['fileSize'];
        }
        if (isset($map['fileType'])) {
            $model->fileType = $map['fileType'];
        }
        if (isset($map['spaceId'])) {
            $model->spaceId = $map['spaceId'];
        }

        return $model;
    }
}
