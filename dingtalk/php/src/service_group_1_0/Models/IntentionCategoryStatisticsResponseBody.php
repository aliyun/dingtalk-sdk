<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\IntentionCategoryStatisticsResponseBody\intentionCategoryRecords;
use AlibabaCloud\Tea\Model;

class IntentionCategoryStatisticsResponseBody extends Model
{
    /**
     * @description 统计明细
     *
     * @var intentionCategoryRecords[]
     */
    public $intentionCategoryRecords;
    protected $_name = [
        'intentionCategoryRecords' => 'intentionCategoryRecords',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->intentionCategoryRecords) {
            $res['intentionCategoryRecords'] = [];
            if (null !== $this->intentionCategoryRecords && \is_array($this->intentionCategoryRecords)) {
                $n = 0;
                foreach ($this->intentionCategoryRecords as $item) {
                    $res['intentionCategoryRecords'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return IntentionCategoryStatisticsResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['intentionCategoryRecords'])) {
            if (!empty($map['intentionCategoryRecords'])) {
                $model->intentionCategoryRecords = [];
                $n                               = 0;
                foreach ($map['intentionCategoryRecords'] as $item) {
                    $model->intentionCategoryRecords[$n++] = null !== $item ? intentionCategoryRecords::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
