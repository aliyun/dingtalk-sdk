<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models\QuerySubscribeStatusRequest;

use AlibabaCloud\Tea\Model;

class body extends Model
{
    /**
     * @description 直播id列表
     *
     * @var string[]
     */
    public $liveIds;
    protected $_name = [
        'liveIds' => 'liveIds',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->liveIds) {
            $res['liveIds'] = $this->liveIds;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return body
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['liveIds'])) {
            if (!empty($map['liveIds'])) {
                $model->liveIds = $map['liveIds'];
            }
        }

        return $model;
    }
}
