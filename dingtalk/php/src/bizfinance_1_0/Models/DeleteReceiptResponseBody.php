<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\DeleteReceiptResponseBody\results;
use AlibabaCloud\Tea\Model;

class DeleteReceiptResponseBody extends Model
{
    /**
     * @description 结果列表
     *
     * @var results[]
     */
    public $results;
    protected $_name = [
        'results' => 'results',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
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
     * @return DeleteReceiptResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['results'])) {
            if (!empty($map['results'])) {
                $model->results = [];
                $n              = 0;
                foreach ($map['results'] as $item) {
                    $model->results[$n++] = null !== $item ? results::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
