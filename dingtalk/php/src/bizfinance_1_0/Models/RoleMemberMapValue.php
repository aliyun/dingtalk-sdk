<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\RoleMemberMapValue\memberList;
use AlibabaCloud\Tea\Model;

class RoleMemberMapValue extends Model
{
    /**
     * @var string
     */
    public $roleCode;

    /**
     * @var memberList[]
     */
    public $memberList;

    /**
     * @example COM_DEFAULT
     *
     * @var string
     */
    public $companyCode;
    protected $_name = [
        'roleCode'    => 'roleCode',
        'memberList'  => 'memberList',
        'companyCode' => 'companyCode',
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
        if (null !== $this->companyCode) {
            $res['companyCode'] = $this->companyCode;
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
        if (isset($map['companyCode'])) {
            $model->companyCode = $map['companyCode'];
        }

        return $model;
    }
}
