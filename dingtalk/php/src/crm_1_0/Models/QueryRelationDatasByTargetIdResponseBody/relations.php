<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\QueryRelationDatasByTargetIdResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\QueryRelationDatasByTargetIdResponseBody\relations\bizDataList;
use AlibabaCloud\Tea\Model;

class relations extends Model
{
    /**
     * @description 关系实例ID。
     *
     * @var string
     */
    public $relationId;

    /**
     * @description 关系类型。
     *
     * @var string
     */
    public $relationType;

    /**
     * @var bizDataList[]
     */
    public $bizDataList;
    protected $_name = [
        'relationId'   => 'relationId',
        'relationType' => 'relationType',
        'bizDataList'  => 'bizDataList',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->relationId) {
            $res['relationId'] = $this->relationId;
        }
        if (null !== $this->relationType) {
            $res['relationType'] = $this->relationType;
        }
        if (null !== $this->bizDataList) {
            $res['bizDataList'] = [];
            if (null !== $this->bizDataList && \is_array($this->bizDataList)) {
                $n = 0;
                foreach ($this->bizDataList as $item) {
                    $res['bizDataList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return relations
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['relationId'])) {
            $model->relationId = $map['relationId'];
        }
        if (isset($map['relationType'])) {
            $model->relationType = $map['relationType'];
        }
        if (isset($map['bizDataList'])) {
            if (!empty($map['bizDataList'])) {
                $model->bizDataList = [];
                $n                  = 0;
                foreach ($map['bizDataList'] as $item) {
                    $model->bizDataList[$n++] = null !== $item ? bizDataList::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
