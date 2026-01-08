<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models\PageQueryCorpPayAccountsResponseBody\accounts;
use AlibabaCloud\Tea\Model;

class PageQueryCorpPayAccountsResponseBody extends Model
{
    /**
     * @var accounts[]
     */
    public $accounts;
    protected $_name = [
        'accounts' => 'accounts',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->accounts) {
            $res['accounts'] = [];
            if (null !== $this->accounts && \is_array($this->accounts)) {
                $n = 0;
                foreach ($this->accounts as $item) {
                    $res['accounts'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return PageQueryCorpPayAccountsResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['accounts'])) {
            if (!empty($map['accounts'])) {
                $model->accounts = [];
                $n = 0;
                foreach ($map['accounts'] as $item) {
                    $model->accounts[$n++] = null !== $item ? accounts::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
