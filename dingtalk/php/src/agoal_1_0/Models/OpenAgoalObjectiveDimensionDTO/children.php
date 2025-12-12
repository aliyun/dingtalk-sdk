<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vagoal_1_0\Models\OpenAgoalObjectiveDimensionDTO;

use AlibabaCloud\Tea\Model;

class children extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 662e006fe4b0f57ccbcxxxxx
     *
     * @var string
     */
    public $dimensionId;

    /**
     * @description This parameter is required.
     *
     * @example 这是子维度标题
     *
     * @var string
     */
    public $title;

    /**
     * @description This parameter is required.
     *
     * @example 100
     *
     * @var float
     */
    public $weight;
    protected $_name = [
        'dimensionId' => 'dimensionId',
        'title' => 'title',
        'weight' => 'weight',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->dimensionId) {
            $res['dimensionId'] = $this->dimensionId;
        }
        if (null !== $this->title) {
            $res['title'] = $this->title;
        }
        if (null !== $this->weight) {
            $res['weight'] = $this->weight;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return children
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['dimensionId'])) {
            $model->dimensionId = $map['dimensionId'];
        }
        if (isset($map['title'])) {
            $model->title = $map['title'];
        }
        if (isset($map['weight'])) {
            $model->weight = $map['weight'];
        }

        return $model;
    }
}
