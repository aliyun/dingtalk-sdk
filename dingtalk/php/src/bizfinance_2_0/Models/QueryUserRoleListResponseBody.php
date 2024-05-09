<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models\QueryUserRoleListResponseBody\financeEmpDeptOpenList;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models\QueryUserRoleListResponseBody\roleVOList;
use AlibabaCloud\Tea\Model;

class QueryUserRoleListResponseBody extends Model
{
    /**
     * @example COM_DEFAULT
     *
     * @var string
     */
    public $companyCode;

    /**
     * @var financeEmpDeptOpenList[]
     */
    public $financeEmpDeptOpenList;

    /**
     * @var roleVOList[]
     */
    public $roleVOList;
    protected $_name = [
        'companyCode'            => 'companyCode',
        'financeEmpDeptOpenList' => 'financeEmpDeptOpenList',
        'roleVOList'             => 'roleVOList',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->companyCode) {
            $res['companyCode'] = $this->companyCode;
        }
        if (null !== $this->financeEmpDeptOpenList) {
            $res['financeEmpDeptOpenList'] = [];
            if (null !== $this->financeEmpDeptOpenList && \is_array($this->financeEmpDeptOpenList)) {
                $n = 0;
                foreach ($this->financeEmpDeptOpenList as $item) {
                    $res['financeEmpDeptOpenList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->roleVOList) {
            $res['roleVOList'] = [];
            if (null !== $this->roleVOList && \is_array($this->roleVOList)) {
                $n = 0;
                foreach ($this->roleVOList as $item) {
                    $res['roleVOList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryUserRoleListResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['companyCode'])) {
            $model->companyCode = $map['companyCode'];
        }
        if (isset($map['financeEmpDeptOpenList'])) {
            if (!empty($map['financeEmpDeptOpenList'])) {
                $model->financeEmpDeptOpenList = [];
                $n                             = 0;
                foreach ($map['financeEmpDeptOpenList'] as $item) {
                    $model->financeEmpDeptOpenList[$n++] = null !== $item ? financeEmpDeptOpenList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['roleVOList'])) {
            if (!empty($map['roleVOList'])) {
                $model->roleVOList = [];
                $n                 = 0;
                foreach ($map['roleVOList'] as $item) {
                    $model->roleVOList[$n++] = null !== $item ? roleVOList::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
