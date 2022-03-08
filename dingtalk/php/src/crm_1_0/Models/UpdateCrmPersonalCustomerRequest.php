<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\UpdateCrmPersonalCustomerRequest\permission;
use AlibabaCloud\Tea\Model;

class UpdateCrmPersonalCustomerRequest extends Model
{
    /**
     * @description 公海领取客户：publicDraw 公海分配客户：publicAssign 其余场景：（不用传）
     *
     * @var string
     */
    public $action;

    /**
     * @var mixed[]
     */
    public $data;

    /**
     * @var mixed[]
     */
    public $extendData;

    /**
     * @var string
     */
    public $instanceId;

    /**
     * @var string
     */
    public $modifierNick;

    /**
     * @var string
     */
    public $modifierUserId;

    /**
     * @var permission
     */
    public $permission;

    /**
     * @var string
     */
    public $relationType;

    /**
     * @description 跳过uk查重
     *
     * @var bool
     */
    public $skipDuplicateCheck;
    protected $_name = [
        'action'             => 'action',
        'data'               => 'data',
        'extendData'         => 'extendData',
        'instanceId'         => 'instanceId',
        'modifierNick'       => 'modifierNick',
        'modifierUserId'     => 'modifierUserId',
        'permission'         => 'permission',
        'relationType'       => 'relationType',
        'skipDuplicateCheck' => 'skipDuplicateCheck',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->action) {
            $res['action'] = $this->action;
        }
        if (null !== $this->data) {
            $res['data'] = $this->data;
        }
        if (null !== $this->extendData) {
            $res['extendData'] = $this->extendData;
        }
        if (null !== $this->instanceId) {
            $res['instanceId'] = $this->instanceId;
        }
        if (null !== $this->modifierNick) {
            $res['modifierNick'] = $this->modifierNick;
        }
        if (null !== $this->modifierUserId) {
            $res['modifierUserId'] = $this->modifierUserId;
        }
        if (null !== $this->permission) {
            $res['permission'] = null !== $this->permission ? $this->permission->toMap() : null;
        }
        if (null !== $this->relationType) {
            $res['relationType'] = $this->relationType;
        }
        if (null !== $this->skipDuplicateCheck) {
            $res['skipDuplicateCheck'] = $this->skipDuplicateCheck;
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
        if (isset($map['action'])) {
            $model->action = $map['action'];
        }
        if (isset($map['data'])) {
            $model->data = $map['data'];
        }
        if (isset($map['extendData'])) {
            $model->extendData = $map['extendData'];
        }
        if (isset($map['instanceId'])) {
            $model->instanceId = $map['instanceId'];
        }
        if (isset($map['modifierNick'])) {
            $model->modifierNick = $map['modifierNick'];
        }
        if (isset($map['modifierUserId'])) {
            $model->modifierUserId = $map['modifierUserId'];
        }
        if (isset($map['permission'])) {
            $model->permission = permission::fromMap($map['permission']);
        }
        if (isset($map['relationType'])) {
            $model->relationType = $map['relationType'];
        }
        if (isset($map['skipDuplicateCheck'])) {
            $model->skipDuplicateCheck = $map['skipDuplicateCheck'];
        }

        return $model;
    }
}
