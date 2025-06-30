<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models\QueryAlipayUserIdResponseBody\alipayBizUserList;
use AlibabaCloud\Tea\Model;

class QueryAlipayUserIdResponseBody extends Model
{
    /**
     * @var alipayBizUserList[]
     */
    public $alipayBizUserList;
    protected $_name = [
        'alipayBizUserList' => 'alipayBizUserList',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->alipayBizUserList) {
            $res['alipayBizUserList'] = [];
            if (null !== $this->alipayBizUserList && \is_array($this->alipayBizUserList)) {
                $n = 0;
                foreach ($this->alipayBizUserList as $item) {
                    $res['alipayBizUserList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryAlipayUserIdResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['alipayBizUserList'])) {
            if (!empty($map['alipayBizUserList'])) {
                $model->alipayBizUserList = [];
                $n = 0;
                foreach ($map['alipayBizUserList'] as $item) {
                    $model->alipayBizUserList[$n++] = null !== $item ? alipayBizUserList::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
