<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vats_1_0\Models;

use AlibabaCloud\Tea\Model;

class AddFileResponseBody extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 111111
     *
     * @var string
     */
    public $fileId;

    /**
     * @description This parameter is required.
     *
     * @example 张三的简历
     *
     * @var string
     */
    public $fileName;

    /**
     * @description This parameter is required.
     *
     * @example 123456
     *
     * @var int
     */
    public $spaceId;
    protected $_name = [
        'fileId'   => 'fileId',
        'fileName' => 'fileName',
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
        if (null !== $this->spaceId) {
            $res['spaceId'] = $this->spaceId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return AddFileResponseBody
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
        if (isset($map['spaceId'])) {
            $model->spaceId = $map['spaceId'];
        }

        return $model;
    }
}
