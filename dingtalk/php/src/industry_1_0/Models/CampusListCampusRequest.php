<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models;

use AlibabaCloud\Tea\Model;

class CampusListCampusRequest extends Model
{
    /**
     * @description 项目组ID
     *
     * @var int
     */
    public $groupDeptId;
    protected $_name = [
        'groupDeptId' => 'groupDeptId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->groupDeptId) {
            $res['groupDeptId'] = $this->groupDeptId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CampusListCampusRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['groupDeptId'])) {
            $model->groupDeptId = $map['groupDeptId'];
        }

        return $model;
    }
}
