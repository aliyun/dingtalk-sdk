<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\GetUserMetricDataResponseBody\metricDataList;
use AlibabaCloud\Tea\Model;

class GetUserMetricDataResponseBody extends Model
{
    /**
     * @var metricDataList[]
     */
    public $metricDataList;
    protected $_name = [
        'metricDataList' => 'metricDataList',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->metricDataList) {
            $res['metricDataList'] = [];
            if (null !== $this->metricDataList && \is_array($this->metricDataList)) {
                $n = 0;
                foreach ($this->metricDataList as $item) {
                    $res['metricDataList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetUserMetricDataResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['metricDataList'])) {
            if (!empty($map['metricDataList'])) {
                $model->metricDataList = [];
                $n = 0;
                foreach ($map['metricDataList'] as $item) {
                    $model->metricDataList[$n++] = null !== $item ? metricDataList::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
