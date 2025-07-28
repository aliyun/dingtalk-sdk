<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vats_1_0\Models\UpdateApplicationRegFormRequest;

use AlibabaCloud\Tea\Model;

class dingPanFile extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example "123456"
     *
     * @var string
     */
    public $fileId;

    /**
     * @description This parameter is required.
     *
     * @example "张三的应聘登记表（开发工程师）"
     *
     * @var string
     */
    public $fileName;

    /**
     * @example 1024
     *
     * @var int
     */
    public $fileSize;

    /**
     * @description This parameter is required.
     *
     * @example pdf
     *
     * @var string
     */
    public $fileType;

    /**
     * @description This parameter is required.
     *
     * @example 223344
     *
     * @var int
     */
    public $spaceId;
    protected $_name = [
        'fileId' => 'fileId',
        'fileName' => 'fileName',
        'fileSize' => 'fileSize',
        'fileType' => 'fileType',
        'spaceId' => 'spaceId',
    ];

    public function validate() {}

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
     * @return dingPanFile
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
