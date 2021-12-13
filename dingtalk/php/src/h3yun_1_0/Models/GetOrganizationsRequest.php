<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vh3yun_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetOrganizationsRequest extends Model
{
    /**
     * @description 18f923a7-5a5e-426d-94ae-a55ad1a4b240
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
