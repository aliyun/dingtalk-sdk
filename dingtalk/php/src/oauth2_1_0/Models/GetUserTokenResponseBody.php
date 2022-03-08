<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Voauth2_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetUserTokenResponseBody extends Model
{
    /**
     * @description accessToken
     *
     * @var string
     */
    public $accessToken;

    /**
     * @description 所选企业corpId
     *
     * @var string
     */
    public $corpId;

    /**
     * @description 超时时间
     *
     * @var int
     */
    public $expireIn;

    /**
     * @description refreshToken
     *
     * @var string
     */
    public $refreshToken;
    protected $_name = [
        'accessToken'  => 'accessToken',
        'corpId'       => 'corpId',
        'expireIn'     => 'expireIn',
        'refreshToken' => 'refreshToken',
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
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->expireIn) {
            $res['expireIn'] = $this->expireIn;
        }
        if (null !== $this->refreshToken) {
            $res['refreshToken'] = $this->refreshToken;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetUserTokenResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['accessToken'])) {
            $model->accessToken = $map['accessToken'];
        }
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['expireIn'])) {
            $model->expireIn = $map['expireIn'];
        }
        if (isset($map['refreshToken'])) {
            $model->refreshToken = $map['refreshToken'];
        }

        return $model;
    }
}
