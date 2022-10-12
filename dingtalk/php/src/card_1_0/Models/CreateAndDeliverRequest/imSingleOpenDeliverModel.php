<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcard_1_0\Models\CreateAndDeliverRequest;

use AlibabaCloud\Tea\Model;

class imSingleOpenDeliverModel extends Model
{
    /**
     * @description 消息@人，
     *
     * @var string[]
     */
    public $atUserIds;
    protected $_name = [
        'atUserIds' => 'atUserIds',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->atUserIds) {
            $res['atUserIds'] = $this->atUserIds;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return imSingleOpenDeliverModel
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['atUserIds'])) {
            $model->atUserIds = $map['atUserIds'];
        }

        return $model;
    }
}
