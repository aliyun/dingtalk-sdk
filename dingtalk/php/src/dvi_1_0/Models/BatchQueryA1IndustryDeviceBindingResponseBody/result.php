<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\BatchQueryA1IndustryDeviceBindingResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\BatchQueryA1IndustryDeviceBindingResponseBody\result\results;
use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @var bool
     */
    public $partialSuccess;

    /**
     * @var results[]
     */
    public $results;
    protected $_name = [
        'partialSuccess' => 'partialSuccess',
        'results' => 'results',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->partialSuccess) {
            $res['partialSuccess'] = $this->partialSuccess;
        }
        if (null !== $this->results) {
            $res['results'] = [];
            if (null !== $this->results && \is_array($this->results)) {
                $n = 0;
                foreach ($this->results as $item) {
                    $res['results'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return result
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['partialSuccess'])) {
            $model->partialSuccess = $map['partialSuccess'];
        }
        if (isset($map['results'])) {
            if (!empty($map['results'])) {
                $model->results = [];
                $n = 0;
                foreach ($map['results'] as $item) {
                    $model->results[$n++] = null !== $item ? results::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
