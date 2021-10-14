<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\QueryPayAccountListResponseBody\payAccountVOList;
use AlibabaCloud\Tea\Model;

class QueryPayAccountListResponseBody extends Model
{
    /**
     * @description 账号列表
     *
     * @var payAccountVOList[]
     */
    public $payAccountVOList;
    protected $_name = [
        'payAccountVOList' => 'payAccountVOList',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->payAccountVOList) {
            $res['payAccountVOList'] = [];
            if (null !== $this->payAccountVOList && \is_array($this->payAccountVOList)) {
                $n = 0;
                foreach ($this->payAccountVOList as $item) {
                    $res['payAccountVOList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryPayAccountListResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['payAccountVOList'])) {
            if (!empty($map['payAccountVOList'])) {
                $model->payAccountVOList = [];
                $n                       = 0;
                foreach ($map['payAccountVOList'] as $item) {
                    $model->payAccountVOList[$n++] = null !== $item ? payAccountVOList::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
