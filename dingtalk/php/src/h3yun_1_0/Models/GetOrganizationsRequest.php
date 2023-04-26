<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vh3yun_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetOrganizationsRequest extends Model
{
    /**
     * @example 部门id。获取指定部门及其下的子部门（以及子部门的子部门等等，递归获取）。 如果不填，默认获取全量组织架构
     *
     * @var string
     */
    public $departmentId;
    protected $_name = [
        'departmentId' => 'departmentId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->departmentId) {
            $res['departmentId'] = $this->departmentId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetOrganizationsRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['departmentId'])) {
            $model->departmentId = $map['departmentId'];
        }

        return $model;
    }
}
