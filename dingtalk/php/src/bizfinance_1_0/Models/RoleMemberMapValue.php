<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\RoleMemberMapValue\memberList;
use AlibabaCloud\Tea\Model;

class RoleMemberMapValue extends Model
{
    /**
     * @description 角色唯一标识
     *
     * @var string
     */
    public $roleCode;

    /**
     * @description 成员信息列表
     *
     * @var memberList[]
     */
    public $memberList;
    protected $_name = [
        'roleCode'   => 'roleCode',
        'memberList' => 'memberList',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->roleCode) {
            $res['roleCode'] = $this->roleCode;
        }
        if (null !== $this->memberList) {
            $res['memberList'] = [];
            if (null !== $this->memberList && \is_array($this->memberList)) {
                $n = 0;
                foreach ($this->memberList as $item) {
                    $res['memberList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return RoleMemberMapValue
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['roleCode'])) {
            $model->roleCode = $map['roleCode'];
        }
        if (isset($map['memberList'])) {
            if (!empty($map['memberList'])) {
                $model->memberList = [];
                $n                 = 0;
                foreach ($map['memberList'] as $item) {
                    $model->memberList[$n++] = null !== $item ? memberList::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
