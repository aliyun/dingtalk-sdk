<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models\QueryBankResponseBody\supportBanks;
use AlibabaCloud\Tea\Model;

class QueryBankResponseBody extends Model
{
    /**
     * @var supportBanks[]
     */
    public $supportBanks;
    protected $_name = [
        'supportBanks' => 'supportBanks',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->supportBanks) {
            $res['supportBanks'] = [];
            if (null !== $this->supportBanks && \is_array($this->supportBanks)) {
                $n = 0;
                foreach ($this->supportBanks as $item) {
                    $res['supportBanks'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryBankResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['supportBanks'])) {
            if (!empty($map['supportBanks'])) {
                $model->supportBanks = [];
                $n = 0;
                foreach ($map['supportBanks'] as $item) {
                    $model->supportBanks[$n++] = null !== $item ? supportBanks::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
