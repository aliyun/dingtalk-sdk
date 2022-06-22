<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models;

use AlibabaCloud\Tea\Model;

class CampusGetCampusRequest extends Model
{
    /**
     * @description 园区部门ID
     *
     * @var int
     */
    public $campusDeptId;
    protected $_name = [
        'campusDeptId' => 'campusDeptId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->campusDeptId) {
            $res['campusDeptId'] = $this->campusDeptId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CampusGetCampusRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['campusDeptId'])) {
            $model->campusDeptId = $map['campusDeptId'];
        }

        return $model;
    }
}
