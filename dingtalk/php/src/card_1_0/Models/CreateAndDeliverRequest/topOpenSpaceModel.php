<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcard_1_0\Models\CreateAndDeliverRequest;

use AlibabaCloud\Tea\Model;

class topOpenSpaceModel extends Model
{
    /**
     * @description 【必填】场域类型 (IM: IM, IM_SINGLE: IM单聊, IM_GROUP: IM群聊, ONE_BOX: 群吊顶, COOPERATION_FEED: 协作, WORK_BENCH: 工作台)
     *
     * @var string
     */
    public $spaceType;
    protected $_name = [
        'spaceType' => 'spaceType',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->spaceType) {
            $res['spaceType'] = $this->spaceType;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return topOpenSpaceModel
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['spaceType'])) {
            $model->spaceType = $map['spaceType'];
        }

        return $model;
    }
}
