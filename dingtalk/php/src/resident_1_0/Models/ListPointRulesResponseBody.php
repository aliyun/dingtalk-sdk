<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vresident_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vresident_1_0\Models\ListPointRulesResponseBody\pointRuleList;
use AlibabaCloud\Tea\Model;

class ListPointRulesResponseBody extends Model
{
    /**
     * @description 查询所得积分规则集合
     *
     * @var pointRuleList[]
     */
    public $pointRuleList;
    protected $_name = [
        'pointRuleList' => 'pointRuleList',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->pointRuleList) {
            $res['pointRuleList'] = [];
            if (null !== $this->pointRuleList && \is_array($this->pointRuleList)) {
                $n = 0;
                foreach ($this->pointRuleList as $item) {
                    $res['pointRuleList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ListPointRulesResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['pointRuleList'])) {
            if (!empty($map['pointRuleList'])) {
                $model->pointRuleList = [];
                $n                    = 0;
                foreach ($map['pointRuleList'] as $item) {
                    $model->pointRuleList[$n++] = null !== $item ? pointRuleList::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
