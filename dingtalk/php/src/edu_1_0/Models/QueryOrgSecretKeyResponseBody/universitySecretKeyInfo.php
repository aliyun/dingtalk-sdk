<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryOrgSecretKeyResponseBody;

use AlibabaCloud\Tea\Model;

class universitySecretKeyInfo extends Model
{
    /**
     * @description 秘钥key
     *
     * @var string
     */
    public $secretKey;
    protected $_name = [
        'secretKey' => 'secretKey',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->secretKey) {
            $res['secretKey'] = $this->secretKey;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return universitySecretKeyInfo
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['secretKey'])) {
            $model->secretKey = $map['secretKey'];
        }

        return $model;
    }
}
