<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\QuerySalesInsightsResponseBody\result;

use AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\QuerySalesInsightsResponseBody\result\capabilityRadar\dimensions;
use AlibabaCloud\Tea\Model;

class capabilityRadar extends Model
{
    /**
     * @var dimensions[]
     */
    public $dimensions;
    protected $_name = [
        'dimensions' => 'dimensions',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->dimensions) {
            $res['dimensions'] = [];
            if (null !== $this->dimensions && \is_array($this->dimensions)) {
                $n = 0;
                foreach ($this->dimensions as $item) {
                    $res['dimensions'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return capabilityRadar
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['dimensions'])) {
            if (!empty($map['dimensions'])) {
                $model->dimensions = [];
                $n = 0;
                foreach ($map['dimensions'] as $item) {
                    $model->dimensions[$n++] = null !== $item ? dimensions::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
