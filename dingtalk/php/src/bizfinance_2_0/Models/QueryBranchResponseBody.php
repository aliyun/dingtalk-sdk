<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models\QueryBranchResponseBody\supportSubBanks;
use AlibabaCloud\Tea\Model;

class QueryBranchResponseBody extends Model
{
    /**
     * @var supportSubBanks[]
     */
    public $supportSubBanks;
    protected $_name = [
        'supportSubBanks' => 'supportSubBanks',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->supportSubBanks) {
            $res['supportSubBanks'] = [];
            if (null !== $this->supportSubBanks && \is_array($this->supportSubBanks)) {
                $n = 0;
                foreach ($this->supportSubBanks as $item) {
                    $res['supportSubBanks'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryBranchResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['supportSubBanks'])) {
            if (!empty($map['supportSubBanks'])) {
                $model->supportSubBanks = [];
                $n = 0;
                foreach ($map['supportSubBanks'] as $item) {
                    $model->supportSubBanks[$n++] = null !== $item ? supportSubBanks::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
