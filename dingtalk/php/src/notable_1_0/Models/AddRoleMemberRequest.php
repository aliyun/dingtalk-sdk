<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vnotable_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vnotable_1_0\Models\AddRoleMemberRequest\roleMemberList;
use AlibabaCloud\Tea\Model;

class AddRoleMemberRequest extends Model
{
    /**
     * @var roleMemberList[]
     */
    public $roleMemberList;

    /**
     * @description This parameter is required.
     *
     * @example union_id
     *
     * @var string
     */
    public $operatorId;
    protected $_name = [
        'roleMemberList' => 'roleMemberList',
        'operatorId' => 'operatorId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->roleMemberList) {
            $res['roleMemberList'] = [];
            if (null !== $this->roleMemberList && \is_array($this->roleMemberList)) {
                $n = 0;
                foreach ($this->roleMemberList as $item) {
                    $res['roleMemberList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->operatorId) {
            $res['operatorId'] = $this->operatorId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return AddRoleMemberRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['roleMemberList'])) {
            if (!empty($map['roleMemberList'])) {
                $model->roleMemberList = [];
                $n = 0;
                foreach ($map['roleMemberList'] as $item) {
                    $model->roleMemberList[$n++] = null !== $item ? roleMemberList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['operatorId'])) {
            $model->operatorId = $map['operatorId'];
        }

        return $model;
    }
}
