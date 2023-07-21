<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetYongYouOpenApiTokenResponseBody extends Model
{
    /**
     * @example abc
     *
     * @var string
     */
    public $accessToken;

    /**
     * @example accounting
     *
     * @var string
     */
    public $appName;

    /**
     * @example 518400
     *
     * @var string
     */
    public $expiresIn;

    /**
     * @example 2512799
     *
     * @var string
     */
    public $refreshExpiresIn;

    /**
     * @example abc
     *
     * @var string
     */
    public $refreshToken;

    /**
     * @example auth_all
     *
     * @var string
     */
    public $scope;

    /**
     * @example abc
     *
     * @var string
     */
    public $sid;

    /**
     * @example 123615862385832922
     *
     * @var string
     */
    public $yongyouOrgId;

    /**
     * @example 391733693750254232
     *
     * @var string
     */
    public $yongyouUserId;
    protected $_name = [
        'accessToken'      => 'accessToken',
        'appName'          => 'appName',
        'expiresIn'        => 'expiresIn',
        'refreshExpiresIn' => 'refreshExpiresIn',
        'refreshToken'     => 'refreshToken',
        'scope'            => 'scope',
        'sid'              => 'sid',
        'yongyouOrgId'     => 'yongyouOrgId',
        'yongyouUserId'    => 'yongyouUserId',
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
        if (null !== $this->appName) {
            $res['appName'] = $this->appName;
        }
        if (null !== $this->expiresIn) {
            $res['expiresIn'] = $this->expiresIn;
        }
        if (null !== $this->refreshExpiresIn) {
            $res['refreshExpiresIn'] = $this->refreshExpiresIn;
        }
        if (null !== $this->refreshToken) {
            $res['refreshToken'] = $this->refreshToken;
        }
        if (null !== $this->scope) {
            $res['scope'] = $this->scope;
        }
        if (null !== $this->sid) {
            $res['sid'] = $this->sid;
        }
        if (null !== $this->yongyouOrgId) {
            $res['yongyouOrgId'] = $this->yongyouOrgId;
        }
        if (null !== $this->yongyouUserId) {
            $res['yongyouUserId'] = $this->yongyouUserId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetYongYouOpenApiTokenResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['accessToken'])) {
            $model->accessToken = $map['accessToken'];
        }
        if (isset($map['appName'])) {
            $model->appName = $map['appName'];
        }
        if (isset($map['expiresIn'])) {
            $model->expiresIn = $map['expiresIn'];
        }
        if (isset($map['refreshExpiresIn'])) {
            $model->refreshExpiresIn = $map['refreshExpiresIn'];
        }
        if (isset($map['refreshToken'])) {
            $model->refreshToken = $map['refreshToken'];
        }
        if (isset($map['scope'])) {
            $model->scope = $map['scope'];
        }
        if (isset($map['sid'])) {
            $model->sid = $map['sid'];
        }
        if (isset($map['yongyouOrgId'])) {
            $model->yongyouOrgId = $map['yongyouOrgId'];
        }
        if (isset($map['yongyouUserId'])) {
            $model->yongyouUserId = $map['yongyouUserId'];
        }

        return $model;
    }
}
