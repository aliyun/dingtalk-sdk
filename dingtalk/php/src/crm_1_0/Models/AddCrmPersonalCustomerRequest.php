<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\AddCrmPersonalCustomerRequest\permission;
use AlibabaCloud\Tea\Model;

class AddCrmPersonalCustomerRequest extends Model
{
    /**
     * @example publicDraw
     *
     * @var string
     */
    public $action;

    /**
     * @var string
     */
    public $creatorNick;

    /**
     * @var string
     */
    public $creatorUserId;

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

    /**
     * @example crm_customer_personal
     *
     * @var string
     */
    public $relationType;

    /**
     * @example false
     *
     * @var bool
     */
    public $skipDuplicateCheck;
    protected $_name = [
        'action'             => 'action',
        'creatorNick'        => 'creatorNick',
        'creatorUserId'      => 'creatorUserId',
        'data'               => 'data',
        'extendData'         => 'extendData',
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
        if (null !== $this->creatorNick) {
            $res['creatorNick'] = $this->creatorNick;
        }
        if (null !== $this->creatorUserId) {
            $res['creatorUserId'] = $this->creatorUserId;
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
     * @return AddCrmPersonalCustomerRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['action'])) {
            $model->action = $map['action'];
        }
        if (isset($map['creatorNick'])) {
            $model->creatorNick = $map['creatorNick'];
        }
        if (isset($map['creatorUserId'])) {
            $model->creatorUserId = $map['creatorUserId'];
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
        if (isset($map['relationType'])) {
            $model->relationType = $map['relationType'];
        }
        if (isset($map['skipDuplicateCheck'])) {
            $model->skipDuplicateCheck = $map['skipDuplicateCheck'];
        }

        return $model;
    }
}
