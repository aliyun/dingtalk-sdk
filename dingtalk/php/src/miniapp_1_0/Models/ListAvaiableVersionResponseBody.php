<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vminiapp_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vminiapp_1_0\Models\ListAvaiableVersionResponseBody\versions;
use AlibabaCloud\Tea\Model;

class ListAvaiableVersionResponseBody extends Model
{
    /**
     * @description result
     *
     * @var versions[]
     */
    public $versions;
    protected $_name = [
        'versions' => 'versions',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->versions) {
            $res['versions'] = [];
            if (null !== $this->versions && \is_array($this->versions)) {
                $n = 0;
                foreach ($this->versions as $item) {
                    $res['versions'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ListAvaiableVersionResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['versions'])) {
            if (!empty($map['versions'])) {
                $model->versions = [];
                $n               = 0;
                foreach ($map['versions'] as $item) {
                    $model->versions[$n++] = null !== $item ? versions::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
