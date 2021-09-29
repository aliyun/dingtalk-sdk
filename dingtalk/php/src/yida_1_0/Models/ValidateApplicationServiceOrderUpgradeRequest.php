<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models;

use AlibabaCloud\Tea\Model;

class ValidateApplicationServiceOrderUpgradeRequest extends Model
{
    /**
     * @description accessKey
     *
     * @var string
     */
    public $accessKey;
    protected $_name = [
        'accessKey' => 'accessKey',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->accessKey) {
            $res['accessKey'] = $this->accessKey;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ValidateApplicationServiceOrderUpgradeRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['accessKey'])) {
            $model->accessKey = $map['accessKey'];
        }

        return $model;
    }
}
