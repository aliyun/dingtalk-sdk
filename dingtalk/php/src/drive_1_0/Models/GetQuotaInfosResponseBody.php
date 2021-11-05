<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\GetQuotaInfosResponseBody\quotas;
use AlibabaCloud\Tea\Model;

class GetQuotaInfosResponseBody extends Model
{
    /**
     * @description 容量信息列表
     *
     * @var quotas[]
     */
    public $quotas;
    protected $_name = [
        'quotas' => 'quotas',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->quotas) {
            $res['quotas'] = [];
            if (null !== $this->quotas && \is_array($this->quotas)) {
                $n = 0;
                foreach ($this->quotas as $item) {
                    $res['quotas'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetQuotaInfosResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['quotas'])) {
            if (!empty($map['quotas'])) {
                $model->quotas = [];
                $n             = 0;
                foreach ($map['quotas'] as $item) {
                    $model->quotas[$n++] = null !== $item ? quotas::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
