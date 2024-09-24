<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models;

use AlibabaCloud\Tea\Model;

class EditSecurityConfigMemberRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example ctrl.xxx
     *
     * @var string
     */
    public $configKey;

    /**
     * @description This parameter is required.
     *
     * @example add
     *
     * @var string
     */
    public $operateType;

    /**
     * @description This parameter is required.
     *
     * @example staffxxx
     *
     * @var string
     */
    public $operateUserId;

    /**
     * @description This parameter is required.
     *
     * @var string[]
     */
    public $userIds;
    protected $_name = [
        'configKey'     => 'configKey',
        'operateType'   => 'operateType',
        'operateUserId' => 'operateUserId',
        'userIds'       => 'userIds',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->configKey) {
            $res['configKey'] = $this->configKey;
        }
        if (null !== $this->operateType) {
            $res['operateType'] = $this->operateType;
        }
        if (null !== $this->operateUserId) {
            $res['operateUserId'] = $this->operateUserId;
        }
        if (null !== $this->userIds) {
            $res['userIds'] = $this->userIds;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return EditSecurityConfigMemberRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['configKey'])) {
            $model->configKey = $map['configKey'];
        }
        if (isset($map['operateType'])) {
            $model->operateType = $map['operateType'];
        }
        if (isset($map['operateUserId'])) {
            $model->operateUserId = $map['operateUserId'];
        }
        if (isset($map['userIds'])) {
            if (!empty($map['userIds'])) {
                $model->userIds = $map['userIds'];
            }
        }

        return $model;
    }
}
