<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryPermissionRoleMemberRequest extends Model
{
    /**
     * @example COM_DEFAULT
     *
     * @var string
     */
    public $companyCode;

    /**
     * @description This parameter is required.
     *
     * @var string[]
     */
    public $roleCodeList;
    protected $_name = [
        'companyCode'  => 'companyCode',
        'roleCodeList' => 'roleCodeList',
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
        if (null !== $this->roleCodeList) {
            $res['roleCodeList'] = $this->roleCodeList;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryPermissionRoleMemberRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['companyCode'])) {
            $model->companyCode = $map['companyCode'];
        }
        if (isset($map['roleCodeList'])) {
            if (!empty($map['roleCodeList'])) {
                $model->roleCodeList = $map['roleCodeList'];
            }
        }

        return $model;
    }
}
