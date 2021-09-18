<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models;

use AlibabaCloud\Tea\Model;

class AddCustomSpaceRequest extends Model
{
    /**
     * @description 空间标识
     *
     * @var string
     */
    public $identifier;

    /**
     * @description 业务类型
     *
     * @var string
     */
    public $bizType;

    /**
     * @description 授权模式
     *
     * @var string
     */
    public $permissionMode;

    /**
     * @description 用户id
     *
     * @var string
     */
    public $unionId;
    protected $_name = [
        'identifier'     => 'identifier',
        'bizType'        => 'bizType',
        'permissionMode' => 'permissionMode',
        'unionId'        => 'unionId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->identifier) {
            $res['identifier'] = $this->identifier;
        }
        if (null !== $this->bizType) {
            $res['bizType'] = $this->bizType;
        }
        if (null !== $this->permissionMode) {
            $res['permissionMode'] = $this->permissionMode;
        }
        if (null !== $this->unionId) {
            $res['unionId'] = $this->unionId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return AddCustomSpaceRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['identifier'])) {
            $model->identifier = $map['identifier'];
        }
        if (isset($map['bizType'])) {
            $model->bizType = $map['bizType'];
        }
        if (isset($map['permissionMode'])) {
            $model->permissionMode = $map['permissionMode'];
        }
        if (isset($map['unionId'])) {
            $model->unionId = $map['unionId'];
        }

        return $model;
    }
}
