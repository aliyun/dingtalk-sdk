<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetUserLastMetricResponseBody extends Model
{
    /**
     * @var MetricMapValue[]
     */
    public $metricMap;
    protected $_name = [
        'metricMap' => 'metricMap',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->metricMap) {
            $res['metricMap'] = [];
            if (null !== $this->metricMap && \is_array($this->metricMap)) {
                foreach ($this->metricMap as $key => $val) {
                    $res['metricMap'][$key] = null !== $val ? $val->toMap() : $val;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetUserLastMetricResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['metricMap'])) {
            $model->metricMap = $map['metricMap'];
        }

        return $model;
    }
}
