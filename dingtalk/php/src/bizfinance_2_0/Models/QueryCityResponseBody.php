<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models\QueryCityResponseBody\citys;
use AlibabaCloud\Tea\Model;

class QueryCityResponseBody extends Model
{
    /**
     * @var citys[]
     */
    public $citys;
    protected $_name = [
        'citys' => 'citys',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->citys) {
            $res['citys'] = [];
            if (null !== $this->citys && \is_array($this->citys)) {
                $n = 0;
                foreach ($this->citys as $item) {
                    $res['citys'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryCityResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['citys'])) {
            if (!empty($map['citys'])) {
                $model->citys = [];
                $n = 0;
                foreach ($map['citys'] as $item) {
                    $model->citys[$n++] = null !== $item ? citys::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
