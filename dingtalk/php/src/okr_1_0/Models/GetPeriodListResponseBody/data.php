<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vokr_1_0\Models\GetPeriodListResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vokr_1_0\Models\GetPeriodListResponseBody\data\periodList;
use AlibabaCloud\Tea\Model;

class data extends Model
{
    /**
     * @var periodList[]
     */
    public $periodList;
    protected $_name = [
        'periodList' => 'periodList',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->periodList) {
            $res['periodList'] = [];
            if (null !== $this->periodList && \is_array($this->periodList)) {
                $n = 0;
                foreach ($this->periodList as $item) {
                    $res['periodList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return data
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['periodList'])) {
            if (!empty($map['periodList'])) {
                $model->periodList = [];
                $n                 = 0;
                foreach ($map['periodList'] as $item) {
                    $model->periodList[$n++] = null !== $item ? periodList::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
