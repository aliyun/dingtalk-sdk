<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models;

use AlibabaCloud\Tea\Model;

class DeleteRecycleFilesRequest extends Model
{
    /**
     * @description 回收站item id列表
     *
     * @var int[]
     */
    public $recycleItemIdList;

    /**
     * @description 回收站类型
     *
     * @var string
     */
    public $recycleType;

    /**
     * @description 用户id
     *
     * @var string
     */
    public $unionId;
    protected $_name = [
        'recycleItemIdList' => 'recycleItemIdList',
        'recycleType'       => 'recycleType',
        'unionId'           => 'unionId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->recycleItemIdList) {
            $res['recycleItemIdList'] = $this->recycleItemIdList;
        }
        if (null !== $this->recycleType) {
            $res['recycleType'] = $this->recycleType;
        }
        if (null !== $this->unionId) {
            $res['unionId'] = $this->unionId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return DeleteRecycleFilesRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['recycleItemIdList'])) {
            if (!empty($map['recycleItemIdList'])) {
                $model->recycleItemIdList = $map['recycleItemIdList'];
            }
        }
        if (isset($map['recycleType'])) {
            $model->recycleType = $map['recycleType'];
        }
        if (isset($map['unionId'])) {
            $model->unionId = $map['unionId'];
        }

        return $model;
    }
}
