<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models;

use AlibabaCloud\Tea\Model;

class CampusDeleteCampusGroupRequest extends Model
{
    /**
     * @description 园区项目组ID
     *
     * @var int
     */
    public $campusProjectGroupId;
    protected $_name = [
        'campusProjectGroupId' => 'campusProjectGroupId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->campusProjectGroupId) {
            $res['campusProjectGroupId'] = $this->campusProjectGroupId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CampusDeleteCampusGroupRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['campusProjectGroupId'])) {
            $model->campusProjectGroupId = $map['campusProjectGroupId'];
        }

        return $model;
    }
}
