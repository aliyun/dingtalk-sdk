<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models;

use AlibabaCloud\Tea\Model;

class CustomizeContactDeptCreateRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $code;

    /**
     * @var string[]
     */
    public $managerIdList;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $name;

    /**
     * @var int
     */
    public $order;

    /**
     * @description This parameter is required.
     *
     * @var int
     */
    public $parentDeptId;

    /**
     * @var int
     */
    public $refId;

    /**
     * @description This parameter is required.
     *
     * @var int
     */
    public $type;
    protected $_name = [
        'code' => 'code',
        'managerIdList' => 'managerIdList',
        'name' => 'name',
        'order' => 'order',
        'parentDeptId' => 'parentDeptId',
        'refId' => 'refId',
        'type' => 'type',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->code) {
            $res['code'] = $this->code;
        }
        if (null !== $this->managerIdList) {
            $res['managerIdList'] = $this->managerIdList;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->order) {
            $res['order'] = $this->order;
        }
        if (null !== $this->parentDeptId) {
            $res['parentDeptId'] = $this->parentDeptId;
        }
        if (null !== $this->refId) {
            $res['refId'] = $this->refId;
        }
        if (null !== $this->type) {
            $res['type'] = $this->type;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CustomizeContactDeptCreateRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['code'])) {
            $model->code = $map['code'];
        }
        if (isset($map['managerIdList'])) {
            if (!empty($map['managerIdList'])) {
                $model->managerIdList = $map['managerIdList'];
            }
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['order'])) {
            $model->order = $map['order'];
        }
        if (isset($map['parentDeptId'])) {
            $model->parentDeptId = $map['parentDeptId'];
        }
        if (isset($map['refId'])) {
            $model->refId = $map['refId'];
        }
        if (isset($map['type'])) {
            $model->type = $map['type'];
        }

        return $model;
    }
}
