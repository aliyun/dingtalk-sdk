<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models\QueryProvinceResponseBody\provinces;
use AlibabaCloud\Tea\Model;

class QueryProvinceResponseBody extends Model
{
    /**
     * @var provinces[]
     */
    public $provinces;
    protected $_name = [
        'provinces' => 'provinces',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->provinces) {
            $res['provinces'] = [];
            if (null !== $this->provinces && \is_array($this->provinces)) {
                $n = 0;
                foreach ($this->provinces as $item) {
                    $res['provinces'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryProvinceResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['provinces'])) {
            if (!empty($map['provinces'])) {
                $model->provinces = [];
                $n = 0;
                foreach ($map['provinces'] as $item) {
                    $model->provinces[$n++] = null !== $item ? provinces::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
