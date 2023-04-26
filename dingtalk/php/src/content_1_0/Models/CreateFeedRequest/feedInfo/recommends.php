<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontent_1_0\Models\CreateFeedRequest\feedInfo;

use AlibabaCloud\Tea\Model;

class recommends extends Model
{
    /**
     * @example c497****-8a89-****-bc9b-*****48610d3
     *
     * @var string
     */
    public $objectId;

    /**
     * @example 0
     *
     * @var int
     */
    public $type;
    protected $_name = [
        'objectId' => 'objectId',
        'type'     => 'type',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->objectId) {
            $res['objectId'] = $this->objectId;
        }
        if (null !== $this->type) {
            $res['type'] = $this->type;
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
        if (isset($map['objectId'])) {
            $model->objectId = $map['objectId'];
        }
        if (isset($map['type'])) {
            $model->type = $map['type'];
        }

        return $model;
    }
}
