<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models;

use AlibabaCloud\Tea\Model;

class DeleteRecycleItemsRequest extends Model
{
    /**
     * @var string[]
     */
    public $recycleItemIds;

    /**
     * @example union_id
     *
     * @var string
     */
    public $unionId;
    protected $_name = [
        'recycleItemIds' => 'recycleItemIds',
        'unionId'        => 'unionId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->recycleItemIds) {
            $res['recycleItemIds'] = $this->recycleItemIds;
        }
        if (null !== $this->unionId) {
            $res['unionId'] = $this->unionId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return DeleteRecycleItemsRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['recycleItemIds'])) {
            if (!empty($map['recycleItemIds'])) {
                $model->recycleItemIds = $map['recycleItemIds'];
            }
        }
        if (isset($map['unionId'])) {
            $model->unionId = $map['unionId'];
        }

        return $model;
    }
}
