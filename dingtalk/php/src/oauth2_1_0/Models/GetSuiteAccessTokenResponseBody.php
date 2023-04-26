<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Voauth2_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetSuiteAccessTokenResponseBody extends Model
{
    /**
     * @var string
     */
    public $accessToken;

    /**
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
     * @return GetSuiteAccessTokenResponseBody
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
