<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models;

use AlibabaCloud\Tea\Model;

class FileStorageUpdateStorageResponseBody extends Model
{
    /**
     * @description 密匙ID
     *
     * @var string
     */
    public $accessKeyId;

    /**
     * @description OSS链接
     *
     * @var string
     */
    public $oss;
    protected $_name = [
        'accessKeyId' => 'accessKeyId',
        'oss'         => 'oss',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->accessKeyId) {
            $res['accessKeyId'] = $this->accessKeyId;
        }
        if (null !== $this->oss) {
            $res['oss'] = $this->oss;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return FileStorageUpdateStorageResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['accessKeyId'])) {
            $model->accessKeyId = $map['accessKeyId'];
        }
        if (isset($map['oss'])) {
            $model->oss = $map['oss'];
        }

        return $model;
    }
}
