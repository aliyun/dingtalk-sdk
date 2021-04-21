<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models;

use AlibabaCloud\Tea\Model;

class RenameFileResponseBody extends Model
{
    /**
     * @description 空间id
     *
     * @var string
     */
    public $spaceId;

    /**
     * @description 文件id
     *
     * @var string
     */
    public $fileId;

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

    /**
     * @description 文件类型
     *
     * @var string
     */
    public $fileType;

    /**
     * @description 文件后缀
     *
     * @var string
     */
    public $fileExtension;
    protected $_name = [
        'spaceId'       => 'spaceId',
        'fileId'        => 'fileId',
        'fileName'      => 'fileName',
        'filePath'      => 'filePath',
        'fileType'      => 'fileType',
        'fileExtension' => 'fileExtension',
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
        if (null !== $this->filePath) {
            $res['filePath'] = $this->filePath;
        }
        if (null !== $this->fileType) {
            $res['fileType'] = $this->fileType;
        }
        if (null !== $this->fileExtension) {
            $res['fileExtension'] = $this->fileExtension;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return RenameFileResponseBody
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
        if (isset($map['filePath'])) {
            $model->filePath = $map['filePath'];
        }
        if (isset($map['fileType'])) {
            $model->fileType = $map['fileType'];
        }
        if (isset($map['fileExtension'])) {
            $model->fileExtension = $map['fileExtension'];
        }

        return $model;
    }
}
