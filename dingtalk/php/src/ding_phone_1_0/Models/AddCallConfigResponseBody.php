<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vding_phone_1_0\Models;

use AlibabaCloud\Tea\Model;

class AddCallConfigResponseBody extends Model
{
    /**
     * @var string
     */
    public $token;
    protected $_name = [
        'token' => 'token',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->token) {
            $res['token'] = $this->token;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return AddCallConfigResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['token'])) {
            $model->token = $map['token'];
        }

        return $model;
    }
}
