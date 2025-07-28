<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CampusListCampusGroupResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @example 扩展
     *
     * @var string
     */
    public $extend;

    /**
     * @example 10101
     *
     * @var int
     */
    public $groupDeptId;

    /**
     * @example 测试项目组
     *
     * @var string
     */
    public $groupName;
    protected $_name = [
        'extend' => 'extend',
        'groupDeptId' => 'groupDeptId',
        'groupName' => 'groupName',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->extend) {
            $res['extend'] = $this->extend;
        }
        if (null !== $this->groupDeptId) {
            $res['groupDeptId'] = $this->groupDeptId;
        }
        if (null !== $this->groupName) {
            $res['groupName'] = $this->groupName;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return result
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['extend'])) {
            $model->extend = $map['extend'];
        }
        if (isset($map['groupDeptId'])) {
            $model->groupDeptId = $map['groupDeptId'];
        }
        if (isset($map['groupName'])) {
            $model->groupName = $map['groupName'];
        }

        return $model;
    }
}
