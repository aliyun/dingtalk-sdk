<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Voauth2_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Voauth2_1_0\Models\GetAuthInfoResponseBody\authAppInfo;
use AlibabaCloud\SDK\Dingtalk\Voauth2_1_0\Models\GetAuthInfoResponseBody\authCorpInfo;
use AlibabaCloud\SDK\Dingtalk\Voauth2_1_0\Models\GetAuthInfoResponseBody\authUserInfo;
use AlibabaCloud\Tea\Model;

class GetAuthInfoResponseBody extends Model
{
    /**
     * @description 授权应用信息
     *
     * @var authAppInfo
     */
    public $authAppInfo;

    /**
     * @description 应用企业信息
     *
     * @var authCorpInfo
     */
    public $authCorpInfo;

    /**
     * @description 授权用户信息
     *
     * @var authUserInfo
     */
    public $authUserInfo;
    protected $_name = [
        'authAppInfo'  => 'authAppInfo',
        'authCorpInfo' => 'authCorpInfo',
        'authUserInfo' => 'authUserInfo',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->authAppInfo) {
            $res['authAppInfo'] = null !== $this->authAppInfo ? $this->authAppInfo->toMap() : null;
        }
        if (null !== $this->authCorpInfo) {
            $res['authCorpInfo'] = null !== $this->authCorpInfo ? $this->authCorpInfo->toMap() : null;
        }
        if (null !== $this->authUserInfo) {
            $res['authUserInfo'] = null !== $this->authUserInfo ? $this->authUserInfo->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetAuthInfoResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['authAppInfo'])) {
            $model->authAppInfo = authAppInfo::fromMap($map['authAppInfo']);
        }
        if (isset($map['authCorpInfo'])) {
            $model->authCorpInfo = authCorpInfo::fromMap($map['authCorpInfo']);
        }
        if (isset($map['authUserInfo'])) {
            $model->authUserInfo = authUserInfo::fromMap($map['authUserInfo']);
        }

        return $model;
    }
}
