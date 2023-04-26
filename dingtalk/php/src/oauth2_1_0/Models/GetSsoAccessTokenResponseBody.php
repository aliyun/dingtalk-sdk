<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Voauth2_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetSsoAccessTokenResponseBody extends Model
{
    /**
     * @example 1234
     *
     * @var string
     */
    public $accessToken;

    /**
     * @example 3600
     *
     * @var int
     */
    public $expireIn;
    protected $_name = [
        'accessToken' => 'accessToken',
        'expireIn'    => 'expireIn',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->accessToken) {
            $res['accessToken'] = $this->accessToken;
        }
        if (null !== $this->expireIn) {
            $res['expireIn'] = $this->expireIn;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetSsoAccessTokenResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['accessToken'])) {
            $model->accessToken = $map['accessToken'];
        }
        if (isset($map['expireIn'])) {
            $model->expireIn = $map['expireIn'];
        }

        return $model;
    }
}
