<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models\BatchGetVoicePrintIdentifyConfigResponseBody\configItems;
use AlibabaCloud\Tea\Model;

class BatchGetVoicePrintIdentifyConfigResponseBody extends Model
{
    /**
     * @var configItems[]
     */
    public $configItems;
    protected $_name = [
        'configItems' => 'configItems',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->configItems) {
            $res['configItems'] = [];
            if (null !== $this->configItems && \is_array($this->configItems)) {
                $n = 0;
                foreach ($this->configItems as $item) {
                    $res['configItems'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return BatchGetVoicePrintIdentifyConfigResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['configItems'])) {
            if (!empty($map['configItems'])) {
                $model->configItems = [];
                $n = 0;
                foreach ($map['configItems'] as $item) {
                    $model->configItems[$n++] = null !== $item ? configItems::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
