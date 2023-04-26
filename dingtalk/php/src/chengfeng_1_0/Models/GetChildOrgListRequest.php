<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vchengfeng_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetChildOrgListRequest extends Model
{
    /**
     * @example 123
     *
     * @var string
     */
    public $deptCode;
    protected $_name = [
        'deptCode' => 'deptCode',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->deptCode) {
            $res['deptCode'] = $this->deptCode;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetChildOrgListRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['deptCode'])) {
            $model->deptCode = $map['deptCode'];
        }

        return $model;
    }
}
