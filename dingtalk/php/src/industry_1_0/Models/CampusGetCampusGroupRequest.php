<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models;

use AlibabaCloud\Tea\Model;

class CampusGetCampusGroupRequest extends Model
{
    /**
     * @description 项目组ID
     *
     * @var int
     */
    public $groupId;
    protected $_name = [
        'groupId' => 'groupId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->groupId) {
            $res['groupId'] = $this->groupId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CampusGetCampusGroupRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['groupId'])) {
            $model->groupId = $map['groupId'];
        }

        return $model;
    }
}
