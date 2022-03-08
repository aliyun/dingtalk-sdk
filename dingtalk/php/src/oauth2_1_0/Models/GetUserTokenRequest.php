<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Voauth2_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetUserTokenRequest extends Model
{
    /**
     * @description 应用id
     *
     * @var string
     */
    public $clientId;

    /**
     * @description 应用密码
     *
     * @var string
     */
    public $clientSecret;

    /**
     * @description OAuth 2.0 临时授权码
     *
     * @var string
     */
    public $code;

    /**
     * @description 分为authorization_code和refresh_token。使用授权码换token，传authorization_code；使用刷新token换用户token，传refresh_token
     *
     * @var string
     */
    public $grantType;

    /**
     * @description OAuth 2.0 刷新令牌
     *
     * @var string
     */
    public $refreshToken;
    protected $_name = [
        'clientId'     => 'clientId',
        'clientSecret' => 'clientSecret',
        'code'         => 'code',
        'grantType'    => 'grantType',
        'refreshToken' => 'refreshToken',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->clientId) {
            $res['clientId'] = $this->clientId;
        }
        if (null !== $this->clientSecret) {
            $res['clientSecret'] = $this->clientSecret;
        }
        if (null !== $this->code) {
            $res['code'] = $this->code;
        }
        if (null !== $this->grantType) {
            $res['grantType'] = $this->grantType;
        }
        if (null !== $this->refreshToken) {
            $res['refreshToken'] = $this->refreshToken;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetUserTokenRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['clientId'])) {
            $model->clientId = $map['clientId'];
        }
        if (isset($map['clientSecret'])) {
            $model->clientSecret = $map['clientSecret'];
        }
        if (isset($map['code'])) {
            $model->code = $map['code'];
        }
        if (isset($map['grantType'])) {
            $model->grantType = $map['grantType'];
        }
        if (isset($map['refreshToken'])) {
            $model->refreshToken = $map['refreshToken'];
        }

        return $model;
    }
}
