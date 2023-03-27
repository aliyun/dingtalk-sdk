<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\TeamModel;

use AlibabaCloud\Tea\Model;

class visitInfo extends Model
{
    /**
     * @description 加入团队时间
     *
     * @var string
     */
    public $joinTime;

    /**
     * @description 用户对这个团队的访问情况
     *
     * @var string
     */
    public $roleCode;
    protected $_name = [
        'joinTime' => 'joinTime',
        'roleCode' => 'roleCode',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->joinTime) {
            $res['joinTime'] = $this->joinTime;
        }
        if (null !== $this->roleCode) {
            $res['roleCode'] = $this->roleCode;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return visitInfo
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['joinTime'])) {
            $model->joinTime = $map['joinTime'];
        }
        if (isset($map['roleCode'])) {
            $model->roleCode = $map['roleCode'];
        }

        return $model;
    }
}
