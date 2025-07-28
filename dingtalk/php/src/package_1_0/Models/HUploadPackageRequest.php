<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vpackage_1_0\Models;

use AlibabaCloud\Tea\Model;

class HUploadPackageRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 5000000002793153
     *
     * @var string
     */
    public $miniAppId;

    /**
     * @description This parameter is required.
     *
     * @example xxxx
     *
     * @var string
     */
    public $ossObjectKey;
    protected $_name = [
        'miniAppId' => 'miniAppId',
        'ossObjectKey' => 'ossObjectKey',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->miniAppId) {
            $res['miniAppId'] = $this->miniAppId;
        }
        if (null !== $this->ossObjectKey) {
            $res['ossObjectKey'] = $this->ossObjectKey;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return HUploadPackageRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['miniAppId'])) {
            $model->miniAppId = $map['miniAppId'];
        }
        if (isset($map['ossObjectKey'])) {
            $model->ossObjectKey = $map['ossObjectKey'];
        }

        return $model;
    }
}
