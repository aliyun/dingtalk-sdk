<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models\RevokeSignRecordsResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models\RevokeSignRecordsResponseBody\result\failItems;
use AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models\RevokeSignRecordsResponseBody\result\successItems;
use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @var failItems[]
     */
    public $failItems;

    /**
     * @var successItems[]
     */
    public $successItems;
    protected $_name = [
        'failItems' => 'failItems',
        'successItems' => 'successItems',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->failItems) {
            $res['failItems'] = [];
            if (null !== $this->failItems && \is_array($this->failItems)) {
                $n = 0;
                foreach ($this->failItems as $item) {
                    $res['failItems'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->successItems) {
            $res['successItems'] = [];
            if (null !== $this->successItems && \is_array($this->successItems)) {
                $n = 0;
                foreach ($this->successItems as $item) {
                    $res['successItems'][$n++] = null !== $item ? $item->toMap() : $item;
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
        if (isset($map['failItems'])) {
            if (!empty($map['failItems'])) {
                $model->failItems = [];
                $n = 0;
                foreach ($map['failItems'] as $item) {
                    $model->failItems[$n++] = null !== $item ? failItems::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['successItems'])) {
            if (!empty($map['successItems'])) {
                $model->successItems = [];
                $n = 0;
                foreach ($map['successItems'] as $item) {
                    $model->successItems[$n++] = null !== $item ? successItems::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
