<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models;

use AlibabaCloud\Tea\Model;

class InitMultipartFileUploadResponseBody extends Model
{
    /**
     * @description 文件存储类型
     * UNKNOWN: 未知驱动
     * @var string
     */
    public $storageDriver;

    /**
     * @description 上传唯一标识
     *
     * @var string
     */
    public $uploadKey;
    protected $_name = [
        'storageDriver' => 'storageDriver',
        'uploadKey'     => 'uploadKey',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->storageDriver) {
            $res['storageDriver'] = $this->storageDriver;
        }
        if (null !== $this->uploadKey) {
            $res['uploadKey'] = $this->uploadKey;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return InitMultipartFileUploadResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['storageDriver'])) {
            $model->storageDriver = $map['storageDriver'];
        }
        if (isset($map['uploadKey'])) {
            $model->uploadKey = $map['uploadKey'];
        }

        return $model;
    }
}
