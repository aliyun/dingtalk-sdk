<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\UpdateCrmPersonalCustomerRequest\permission;
use AlibabaCloud\Tea\Model;

class UpdateCrmPersonalCustomerRequest extends Model
{
    /**
     * @var string
     */
    public $instanceId;

    /**
     * @var string
     */
    public $modifierUserId;

    /**
     * @var string
     */
    public $modifierNick;

    /**
     * @var mixed[]
     */
    public $data;

    /**
     * @var mixed[]
     */
    public $extendData;

    /**
     * @var permission
     */
    public $permission;
    protected $_name = [
        'instanceId'     => 'instanceId',
        'modifierUserId' => 'modifierUserId',
        'modifierNick'   => 'modifierNick',
        'data'           => 'data',
        'extendData'     => 'extendData',
        'permission'     => 'permission',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->instanceId) {
            $res['instanceId'] = $this->instanceId;
        }
        if (null !== $this->modifierUserId) {
            $res['modifierUserId'] = $this->modifierUserId;
        }
        if (null !== $this->modifierNick) {
            $res['modifierNick'] = $this->modifierNick;
        }
        if (null !== $this->data) {
            $res['data'] = $this->data;
        }
        if (null !== $this->extendData) {
            $res['extendData'] = $this->extendData;
        }
        if (null !== $this->permission) {
            $res['permission'] = null !== $this->permission ? $this->permission->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UpdateCrmPersonalCustomerRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['instanceId'])) {
            $model->instanceId = $map['instanceId'];
        }
        if (isset($map['modifierUserId'])) {
            $model->modifierUserId = $map['modifierUserId'];
        }
        if (isset($map['modifierNick'])) {
            $model->modifierNick = $map['modifierNick'];
        }
        if (isset($map['data'])) {
            $model->data = $map['data'];
        }
        if (isset($map['extendData'])) {
            $model->extendData = $map['extendData'];
        }
        if (isset($map['permission'])) {
            $model->permission = permission::fromMap($map['permission']);
        }

        return $model;
    }
}
