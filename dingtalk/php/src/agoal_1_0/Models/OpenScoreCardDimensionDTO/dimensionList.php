<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vagoal_1_0\Models\OpenScoreCardDimensionDTO;

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
    protected $_name = [
        'dimensionId' => 'dimensionId',
        'indicatorIdList' => 'indicatorIdList',
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

        return $model;
    }
}
