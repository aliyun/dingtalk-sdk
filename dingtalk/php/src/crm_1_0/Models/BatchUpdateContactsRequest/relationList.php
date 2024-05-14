<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\BatchUpdateContactsRequest;

use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\BatchUpdateContactsRequest\relationList\bizDataList;
use AlibabaCloud\Tea\Model;

class relationList extends Model
{
    /**
     * @var bizDataList[]
     */
    public $bizDataList;

    /**
     * @var string[]
     */
    public $bizExtMap;

    /**
     * @description This parameter is required.
     *
     * @example fasdg8i814-0afsd
     *
     * @var string
     */
    public $relationId;
    protected $_name = [
        'bizDataList' => 'bizDataList',
        'bizExtMap'   => 'bizExtMap',
        'relationId'  => 'relationId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->bizDataList) {
            $res['bizDataList'] = [];
            if (null !== $this->bizDataList && \is_array($this->bizDataList)) {
                $n = 0;
                foreach ($this->bizDataList as $item) {
                    $res['bizDataList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->bizExtMap) {
            $res['bizExtMap'] = $this->bizExtMap;
        }
        if (null !== $this->relationId) {
            $res['relationId'] = $this->relationId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return relationList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['bizDataList'])) {
            if (!empty($map['bizDataList'])) {
                $model->bizDataList = [];
                $n                  = 0;
                foreach ($map['bizDataList'] as $item) {
                    $model->bizDataList[$n++] = null !== $item ? bizDataList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['bizExtMap'])) {
            $model->bizExtMap = $map['bizExtMap'];
        }
        if (isset($map['relationId'])) {
            $model->relationId = $map['relationId'];
        }

        return $model;
    }
}
