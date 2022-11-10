<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\RestoreRecycleItemsRequest\option;
use AlibabaCloud\Tea\Model;

class RestoreRecycleItemsRequest extends Model
{
    /**
     * @description 可选参数
     *
     * @var option
     */
    public $option;

    /**
     * @description 回收项id列表
     * 30
     * @var string[]
     */
    public $recycleItemIds;

    /**
     * @description 用户id
     *
     * @var string
     */
    public $unionId;
    protected $_name = [
        'option'         => 'option',
        'recycleItemIds' => 'recycleItemIds',
        'unionId'        => 'unionId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->option) {
            $res['option'] = null !== $this->option ? $this->option->toMap() : null;
        }
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
     * @return RestoreRecycleItemsRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['option'])) {
            $model->option = option::fromMap($map['option']);
        }
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
