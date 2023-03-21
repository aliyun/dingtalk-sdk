<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vlink_1_0\Models;

use AlibabaCloud\Tea\Model;

class ApplyFollowerAuthInfoRequest extends Model
{
    /**
     * @description 应用授权Key,可通过服务窗开放互联功能获取。此参数与fieldScope参数二选一。
     *
     * @var string
     */
    public $appAuthKey;

    /**
     * @description 申请的授权数据，多个数据时使用,分隔。此参数与appAuthKey参数二选一。
     * 暂时仅支持申请手机号码授权：Contact.User.mobile
     * @var string
     */
    public $fieldScope;

    /**
     * @description 服务窗机器人消息sessionId。
     * 开发者需要接入服务窗自建机器人后通过回调消息获取到的sessionId。
     * @var string
     */
    public $sessionId;

    /**
     * @description 服务窗关注用户userId。
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'appAuthKey' => 'appAuthKey',
        'fieldScope' => 'fieldScope',
        'sessionId'  => 'sessionId',
        'userId'     => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->appAuthKey) {
            $res['appAuthKey'] = $this->appAuthKey;
        }
        if (null !== $this->fieldScope) {
            $res['fieldScope'] = $this->fieldScope;
        }
        if (null !== $this->sessionId) {
            $res['sessionId'] = $this->sessionId;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ApplyFollowerAuthInfoRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['appAuthKey'])) {
            $model->appAuthKey = $map['appAuthKey'];
        }
        if (isset($map['fieldScope'])) {
            $model->fieldScope = $map['fieldScope'];
        }
        if (isset($map['sessionId'])) {
            $model->sessionId = $map['sessionId'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
