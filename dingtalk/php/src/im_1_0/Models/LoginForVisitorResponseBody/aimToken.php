<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\LoginForVisitorResponseBody;

use AlibabaCloud\Tea\Model;

class aimToken extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example abc123xyz
     *
     * @var string
     */
    public $accessToken;

    /**
     * @description This parameter is required.
     *
     * @example 86400
     *
     * @var int
     */
    public $accessTokenExpiredTime;

    /**
     * @description This parameter is required.
     *
     * @example 1717027200000
     *
     * @var int
     */
    public $buildTime;

    /**
     * @description This parameter is required.
     *
     * @example refreshtoken_789
     *
     * @var string
     */
    public $refreshToken;
    protected $_name = [
        'accessToken' => 'accessToken',
        'accessTokenExpiredTime' => 'accessTokenExpiredTime',
        'buildTime' => 'buildTime',
        'refreshToken' => 'refreshToken',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->accessToken) {
            $res['accessToken'] = $this->accessToken;
        }
        if (null !== $this->accessTokenExpiredTime) {
            $res['accessTokenExpiredTime'] = $this->accessTokenExpiredTime;
        }
        if (null !== $this->buildTime) {
            $res['buildTime'] = $this->buildTime;
        }
        if (null !== $this->refreshToken) {
            $res['refreshToken'] = $this->refreshToken;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return aimToken
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['accessToken'])) {
            $model->accessToken = $map['accessToken'];
        }
        if (isset($map['accessTokenExpiredTime'])) {
            $model->accessTokenExpiredTime = $map['accessTokenExpiredTime'];
        }
        if (isset($map['buildTime'])) {
            $model->buildTime = $map['buildTime'];
        }
        if (isset($map['refreshToken'])) {
            $model->refreshToken = $map['refreshToken'];
        }

        return $model;
    }
}
