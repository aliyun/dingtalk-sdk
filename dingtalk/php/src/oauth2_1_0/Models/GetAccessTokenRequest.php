<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Voauth2_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetAccessTokenRequest extends Model
{
    /**
     * @description 应用id
     *
     * @var string
     */
    public $appKey;

    /**
     * @description 应用密码
     *
     * @var string
     */
    public $appSecret;
    protected $_name = [
        'appKey'    => 'appKey',
        'appSecret' => 'appSecret',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->appKey) {
            $res['appKey'] = $this->appKey;
        }
        if (null !== $this->appSecret) {
            $res['appSecret'] = $this->appSecret;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetAccessTokenRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['appKey'])) {
            $model->appKey = $map['appKey'];
        }
        if (isset($map['appSecret'])) {
            $model->appSecret = $map['appSecret'];
        }

        return $model;
    }
}
