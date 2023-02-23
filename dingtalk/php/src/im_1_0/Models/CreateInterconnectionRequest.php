<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\CreateInterconnectionRequest\interconnections;
use AlibabaCloud\Tea\Model;

class CreateInterconnectionRequest extends Model
{
    /**
     * @description 要创建的钉外账号列表。
     *
     * @var interconnections[]
     */
    public $interconnections;
    protected $_name = [
        'interconnections' => 'interconnections',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->interconnections) {
            $res['interconnections'] = [];
            if (null !== $this->interconnections && \is_array($this->interconnections)) {
                $n = 0;
                foreach ($this->interconnections as $item) {
                    $res['interconnections'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreateInterconnectionRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['interconnections'])) {
            if (!empty($map['interconnections'])) {
                $model->interconnections = [];
                $n                       = 0;
                foreach ($map['interconnections'] as $item) {
                    $model->interconnections[$n++] = null !== $item ? interconnections::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
