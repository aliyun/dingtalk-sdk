<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vagoal_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vagoal_1_0\Models\OpenScoreCardDimensionDTO\dimensionList;
use AlibabaCloud\Tea\Model;

class OpenScoreCardDimensionDTO extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var dimensionList[]
     */
    public $dimensionList;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $scoreCardId;
    protected $_name = [
        'dimensionList' => 'dimensionList',
        'scoreCardId' => 'scoreCardId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->dimensionList) {
            $res['dimensionList'] = [];
            if (null !== $this->dimensionList && \is_array($this->dimensionList)) {
                $n = 0;
                foreach ($this->dimensionList as $item) {
                    $res['dimensionList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->scoreCardId) {
            $res['scoreCardId'] = $this->scoreCardId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return OpenScoreCardDimensionDTO
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['dimensionList'])) {
            if (!empty($map['dimensionList'])) {
                $model->dimensionList = [];
                $n = 0;
                foreach ($map['dimensionList'] as $item) {
                    $model->dimensionList[$n++] = null !== $item ? dimensionList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['scoreCardId'])) {
            $model->scoreCardId = $map['scoreCardId'];
        }

        return $model;
    }
}
