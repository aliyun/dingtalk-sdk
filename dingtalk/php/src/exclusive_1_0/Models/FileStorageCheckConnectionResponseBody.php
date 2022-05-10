<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models;

use AlibabaCloud\Tea\Model;

class FileStorageCheckConnectionResponseBody extends Model
{
    /**
     * @description 密匙ID
     *
     * @var string
     */
    public $accessKeyId;

    /**
     * @description 检测oss状态 0正常1异常
     *
     * @var int
     */
    public $checkState;

    /**
     * @description OSS链接
     *
     * @var string
     */
    public $oss;
    protected $_name = [
        'accessKeyId' => 'accessKeyId',
        'checkState'  => 'checkState',
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
        if (null !== $this->checkState) {
            $res['checkState'] = $this->checkState;
        }
        if (null !== $this->oss) {
            $res['oss'] = $this->oss;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return FileStorageCheckConnectionResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['accessKeyId'])) {
            $model->accessKeyId = $map['accessKeyId'];
        }
        if (isset($map['checkState'])) {
            $model->checkState = $map['checkState'];
        }
        if (isset($map['oss'])) {
            $model->oss = $map['oss'];
        }

        return $model;
    }
}
