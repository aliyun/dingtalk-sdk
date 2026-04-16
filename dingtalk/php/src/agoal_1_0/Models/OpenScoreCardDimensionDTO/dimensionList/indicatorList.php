<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vagoal_1_0\Models\OpenScoreCardDimensionDTO\dimensionList;

use AlibabaCloud\Tea\Model;

class indicatorList extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $indicatorId;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $originCode;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $originId;
    protected $_name = [
        'indicatorId' => 'indicatorId',
        'originCode' => 'originCode',
        'originId' => 'originId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->indicatorId) {
            $res['indicatorId'] = $this->indicatorId;
        }
        if (null !== $this->originCode) {
            $res['originCode'] = $this->originCode;
        }
        if (null !== $this->originId) {
            $res['originId'] = $this->originId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return indicatorList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['indicatorId'])) {
            $model->indicatorId = $map['indicatorId'];
        }
        if (isset($map['originCode'])) {
            $model->originCode = $map['originCode'];
        }
        if (isset($map['originId'])) {
            $model->originId = $map['originId'];
        }

        return $model;
    }
}
