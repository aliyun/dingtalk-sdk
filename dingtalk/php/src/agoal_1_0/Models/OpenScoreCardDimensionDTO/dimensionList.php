<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vagoal_1_0\Models\OpenScoreCardDimensionDTO;

use AlibabaCloud\SDK\Dingtalk\Vagoal_1_0\Models\OpenScoreCardDimensionDTO\dimensionList\indicatorList;
use AlibabaCloud\Tea\Model;

class dimensionList extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $dimensionId;

    /**
     * @description This parameter is required.
     *
     * @var string[]
     */
    public $indicatorIdList;

    /**
     * @var indicatorList[]
     */
    public $indicatorList;
    protected $_name = [
        'dimensionId' => 'dimensionId',
        'indicatorIdList' => 'indicatorIdList',
        'indicatorList' => 'indicatorList',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->dimensionId) {
            $res['dimensionId'] = $this->dimensionId;
        }
        if (null !== $this->indicatorIdList) {
            $res['indicatorIdList'] = $this->indicatorIdList;
        }
        if (null !== $this->indicatorList) {
            $res['indicatorList'] = [];
            if (null !== $this->indicatorList && \is_array($this->indicatorList)) {
                $n = 0;
                foreach ($this->indicatorList as $item) {
                    $res['indicatorList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return dimensionList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['dimensionId'])) {
            $model->dimensionId = $map['dimensionId'];
        }
        if (isset($map['indicatorIdList'])) {
            if (!empty($map['indicatorIdList'])) {
                $model->indicatorIdList = $map['indicatorIdList'];
            }
        }
        if (isset($map['indicatorList'])) {
            if (!empty($map['indicatorList'])) {
                $model->indicatorList = [];
                $n = 0;
                foreach ($map['indicatorList'] as $item) {
                    $model->indicatorList[$n++] = null !== $item ? indicatorList::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
