<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vnotable_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetImportEncryptPublicKeyRequest extends Model
{
    /**
     * @var string
     */
    public $keyVersion;

    /**
     * @description This parameter is required.
     *
     * @example union_id
     *
     * @var string
     */
    public $operatorId;
    protected $_name = [
        'keyVersion' => 'keyVersion',
        'operatorId' => 'operatorId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->keyVersion) {
            $res['keyVersion'] = $this->keyVersion;
        }
        if (null !== $this->operatorId) {
            $res['operatorId'] = $this->operatorId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetImportEncryptPublicKeyRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['keyVersion'])) {
            $model->keyVersion = $map['keyVersion'];
        }
        if (isset($map['operatorId'])) {
            $model->operatorId = $map['operatorId'];
        }

        return $model;
    }
}
