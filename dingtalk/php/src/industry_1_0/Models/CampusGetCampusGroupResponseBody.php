<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models;

use AlibabaCloud\Tea\Model;

class CampusGetCampusGroupResponseBody extends Model
{
    /**
     * @example 项目扩展信息
     *
     * @var string
     */
    public $extend;

    /**
     * @example 测试项目组
     *
     * @var string
     */
    public $projectGroupName;
    protected $_name = [
        'extend' => 'extend',
        'projectGroupName' => 'projectGroupName',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->extend) {
            $res['extend'] = $this->extend;
        }
        if (null !== $this->projectGroupName) {
            $res['projectGroupName'] = $this->projectGroupName;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CampusGetCampusGroupResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['extend'])) {
            $model->extend = $map['extend'];
        }
        if (isset($map['projectGroupName'])) {
            $model->projectGroupName = $map['projectGroupName'];
        }

        return $model;
    }
}
