<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models;

use AlibabaCloud\Tea\Model;

class CampusUpdateCampusGroupRequest extends Model
{
    /**
     * @var int
     */
    public $campusProjectGroupId;

    /**
     * @description 扩展信息
     *
     * @var string
     */
    public $extend;

    /**
     * @description 项目组名
     *
     * @var string
     */
    public $name;
    protected $_name = [
        'campusProjectGroupId' => 'campusProjectGroupId',
        'extend'               => 'extend',
        'name'                 => 'name',
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
        if (null !== $this->extend) {
            $res['extend'] = $this->extend;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CampusUpdateCampusGroupRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['campusProjectGroupId'])) {
            $model->campusProjectGroupId = $map['campusProjectGroupId'];
        }
        if (isset($map['extend'])) {
            $model->extend = $map['extend'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }

        return $model;
    }
}
