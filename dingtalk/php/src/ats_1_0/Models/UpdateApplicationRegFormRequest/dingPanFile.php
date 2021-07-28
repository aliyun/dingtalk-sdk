<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vats_1_0\Models\UpdateApplicationRegFormRequest;

use AlibabaCloud\Tea\Model;

class dingPanFile extends Model
{
    /**
     * @description 钉盘空间标识
     *
     * @var int
     */
    public $spaceId;

    /**
     * @description 钉盘文件标识
     *
     * @var string
     */
    public $fileId;

    /**
     * @description 文件名
     *
     * @var string
     */
    public $fileName;

    /**
     * @description 文件大小（单位：字节）
     *
     * @var int
     */
    public $fileSize;

    /**
     * @description 文件类型（支持：pdf，doc，docx，ppt，pptx，jpg等）
     *
     * @var string
     */
    public $fileType;
    protected $_name = [
        'spaceId'  => 'spaceId',
        'fileId'   => 'fileId',
        'fileName' => 'fileName',
        'fileSize' => 'fileSize',
        'fileType' => 'fileType',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->spaceId) {
            $res['spaceId'] = $this->spaceId;
        }
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

        return $res;
    }

    /**
     * @param array $map
     *
     * @return dingPanFile
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['spaceId'])) {
            $model->spaceId = $map['spaceId'];
        }
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

        return $model;
    }
}
