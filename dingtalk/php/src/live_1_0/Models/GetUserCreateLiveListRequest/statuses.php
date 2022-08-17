<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models\GetUserCreateLiveListRequest;

use AlibabaCloud\Tea\Model;

class statuses extends Model
{
    /**
     * @description 直播状态列表
     *
     * @var int[]
     */
    public $statuses;
    protected $_name = [
        'statuses' => 'statuses',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->statuses) {
            $res['statuses'] = $this->statuses;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return statuses
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['statuses'])) {
            if (!empty($map['statuses'])) {
                $model->statuses = $map['statuses'];
            }
        }

        return $model;
    }
}
