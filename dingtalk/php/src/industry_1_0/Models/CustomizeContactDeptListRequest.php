<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models;

use AlibabaCloud\Tea\Model;

class CustomizeContactDeptListRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example XXXX
     *
     * @var string
     */
    public $code;

    /**
     * @description This parameter is required.
     *
     * @example 65722123
     *
     * @var int
     */
    public $deptId;
    protected $_name = [
        'code'   => 'code',
        'deptId' => 'deptId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->code) {
            $res['code'] = $this->code;
        }
        if (null !== $this->deptId) {
            $res['deptId'] = $this->deptId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CustomizeContactDeptListRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['code'])) {
            $model->code = $map['code'];
        }
        if (isset($map['deptId'])) {
            $model->deptId = $map['deptId'];
        }

        return $model;
    }
}
