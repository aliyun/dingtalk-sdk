<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryPermissionByUserIdRequest extends Model
{
    /**
     * @example COM_DEFAULT
     *
     * @var string
     */
    public $companyCode;

    /**
     * @var string
     */
    public $userId;
    protected $_name = [
        'companyCode' => 'companyCode',
        'userId'      => 'userId',
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
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryPermissionByUserIdRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['companyCode'])) {
            $model->companyCode = $map['companyCode'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
