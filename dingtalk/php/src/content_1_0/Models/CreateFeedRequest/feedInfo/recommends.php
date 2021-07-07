<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontent_1_0\Models\CreateFeedRequest\feedInfo;

use AlibabaCloud\Tea\Model;

class recommends extends Model
{
    /**
     * @description 推荐物品的类别,0:课程,1:微应用
     *
     * @var int
     */
    public $type;

    /**
     * @description 推荐物品的id，可以时feedId或者是微应用Id
     *
     * @var string
     */
    public $objectId;
    protected $_name = [
        'type'     => 'type',
        'objectId' => 'objectId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->type) {
            $res['type'] = $this->type;
        }
        if (null !== $this->objectId) {
            $res['objectId'] = $this->objectId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return recommends
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['type'])) {
            $model->type = $map['type'];
        }
        if (isset($map['objectId'])) {
            $model->objectId = $map['objectId'];
        }

        return $model;
    }
}
