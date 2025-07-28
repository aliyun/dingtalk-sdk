<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vlink_1_0\Models;

use AlibabaCloud\Tea\Model;

class ApplyFollowerAuthInfoRequest extends Model
{
    /**
     * @var string
     */
    public $appAuthKey;

    /**
     * @example Contact.User.mobile
     *
     * @var string
     */
    public $fieldScope;

    /**
     * @description This parameter is required.
     *
     * @example sid22b31b4bf59ef2c783f7
     *
     * @var string
     */
    public $sessionId;

    /**
     * @description This parameter is required.
     *
     * @example idzb26bxl64vqx2keyi
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'appAuthKey' => 'appAuthKey',
        'fieldScope' => 'fieldScope',
        'sessionId' => 'sessionId',
        'userId' => 'userId',
    ];

    public function validate() {}

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
